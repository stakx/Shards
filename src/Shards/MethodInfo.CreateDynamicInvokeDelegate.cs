// Copyright (c) 2021 stakx
// License available at https://github.com/stakx/Shards/blob/main/LICENSE.md.
namespace Shards
{
    using System;
    using System.Reflection;
    using System.Reflection.Emit;

    using static System.Reflection.Emit.OpCodes;

    using DynamicInvokeFunc = System.Func<object, object[], object>;

    public static partial class MethodInfoExtensions
    {
        private static readonly Type[] DynamicInvokeMethodParameterTypes = new[] { typeof(object), typeof(object[]) };

        /// <summary>
        ///  Returns a delegate that can be used to dynamically invoke this method, either virtually, or non-virtually.
        /// </summary>
        /// <param name="method">
        ///   The method that the delegate should invoke.
        /// </param>
        /// <param name="virtualDispatch">
        ///   Determines whether the delegate should invoke this method virtually, or non-virtually.
        ///   Non-virtual dispatch can be useful e.g. when invoking a specific base method implementation.
        /// </param>
        /// <returns>
        ///   A delegate that will invoke this method. Its first parameter is an <see langword="object"/>
        ///   specifying the instance (i.e., the <see langword="this"/> reference). This should be
        ///   <see langword="null"/> for a static method. Its second parameter is an <see langword="object"/>[]
        ///   array containing the arguments. The delegate returns the method's return value (or
        ///   <see langword="null"/> in the case of a <see langword="void"/> method) as an <see langword="object"/>.
        /// </returns>
        public static DynamicInvokeFunc CreateDynamicInvokeDelegate(this MethodInfo method, bool virtualDispatch)
        {
            var dynamicInvokeMethod = new DynamicMethod(name: string.Empty, typeof(object), DynamicInvokeMethodParameterTypes) { InitLocals = false };
            var code = dynamicInvokeMethod.GetILGenerator();

            var returnValue = code.DeclareLocal(typeof(object));
            code.Emit(Ldnull);
            code.Emit(Stloc, returnValue);

            var parameterTypes = Array.ConvertAll(method.GetParameters(), p => p.ParameterType);
            var argumentTypes = Array.ConvertAll(parameterTypes, p => p.IsByRef ? p.GetElementType() : p);
            var parameterCount = parameterTypes.Length;
            var arguments = new LocalBuilder[parameterCount];
            for (var i = 0; i < parameterCount; i++)
            {
                arguments[i] = code.DeclareLocal(argumentTypes[i]);
                code.Emit(Ldarg_1);
                code.Emit(Ldc_I4, i);
                code.Emit(Ldelem_Ref);
                code.Emit(Unbox_Any, argumentTypes[i]);  // TODO: may need to coerce primitive types
                code.Emit(Stloc, arguments[i]);
            }

            code.BeginExceptionBlock();

            if (!method.IsStatic)
            {
                code.Emit(Ldarg_0);
                code.Emit(Castclass, method.DeclaringType);
            }

            for (var i = 0; i < parameterCount; i++)
            {
                code.Emit(parameterTypes[i].IsByRef ? Ldloca : Ldloc, arguments[i]);
            }

            code.Emit(virtualDispatch ? Callvirt : Call, method);

            if (method.ReturnType != typeof(void))
            {
                code.Emit(Box, method.ReturnType);
                code.Emit(Stloc, returnValue);
            }

            var returnLabel = code.DefineLabel();
            code.Emit(Leave, returnLabel);

            code.BeginFinallyBlock();

            for (var i = 0; i < parameterCount; i++)
            {
                if (parameterTypes[i].IsByRef)
                {
                    code.Emit(Ldarg_1);
                    code.Emit(Ldc_I4, i);
                    code.Emit(Ldloc, arguments[i]);
                    code.Emit(Box, argumentTypes[i]);
                    code.Emit(Stelem_Ref);
                }
            }

            code.EndExceptionBlock();

            code.MarkLabel(returnLabel);
            code.Emit(Ldloc, returnValue);
            code.Emit(Ret);

            return (DynamicInvokeFunc)dynamicInvokeMethod.CreateDelegate(typeof(DynamicInvokeFunc));
        }
    }
}
