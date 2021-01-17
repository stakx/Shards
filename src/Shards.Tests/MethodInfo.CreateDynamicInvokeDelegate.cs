// Copyright (c) 2021 stakx
// License available at https://github.com/stakx/Shards/blob/main/LICENSE.md.

namespace Shards.Tests
{
    using System;

    using Xunit;

    public partial class MethodInfoExtensionsTests
    {
        [Fact]
        public void CreateDynamicInvokeDelegate_no_virtual_dispatch()
        {
            var method = typeof(I).GetMethod(nameof(I.Echo), new[] { typeof(int) });
            var dynamicInvoke = method.CreateDynamicInvokeDelegate(virtualDispatch: false);

            var instance = new C();
            var arguments = new object[] { 42 };
            var returnValue = dynamicInvoke(instance, arguments);

            Assert.Equal(42, returnValue);
        }

        [Fact]
        public void CreateDynamicInvokeDelegate_virtual_dispatch()
        {
            var method = typeof(I).GetMethod(nameof(I.Echo), new[] { typeof(int) });
            var dynamicInvoke = method.CreateDynamicInvokeDelegate(virtualDispatch: true);

            var instance = new C();
            var arguments = new object[] { 42 };
            var returnValue = dynamicInvoke(instance, arguments);

            Assert.Equal(-42, returnValue);
        }

        [Fact]
        public void CreateDynamicInvokeDelegate_reference_type_arguments_polymorphism()
        {
            var method = typeof(I).GetMethod(nameof(I.Echo), new[] { typeof(object) });
            var dynamicInvoke = method.CreateDynamicInvokeDelegate(virtualDispatch: false);

            var instance = new C();
            var arguments = new object[] { "42" };
            var returnValue = dynamicInvoke(instance, arguments);

            Assert.Equal("42", returnValue);
        }

        [Fact(Skip = "Coercion of primitive values has not been implemented yet.")]
        public void CreateDynamicInvokeDelegate_value_type_arguments_coercion()
        {
            var method = typeof(I).GetMethod(nameof(I.Echo), new[] { typeof(short) });
            var dynamicInvoke = method.CreateDynamicInvokeDelegate(virtualDispatch: false);

            var instance = new C();
            var arguments = new object[] { 42 };
            var returnValue = dynamicInvoke(instance, arguments);

            Assert.Equal(42, returnValue);
        }

        [Fact]
        public void CreateDynamicInvokeDelegate_by_ref_argument()
        {
            var method = typeof(I).GetMethod(nameof(I.PostIncrement));
            var dynamicInvoke = method.CreateDynamicInvokeDelegate(virtualDispatch: false);

            var instance = new C();
            var arguments = new object[] { 42 };
            var returnValue = dynamicInvoke(instance, arguments);

            Assert.Equal(42, returnValue);
            Assert.Equal(43, arguments[0]);
        }

        [Fact]
        public void CreateDynamicInvokeDelegate_by_ref_argument_updated_when_method_throws()
        {
            var method = typeof(I).GetMethod(nameof(I.IncrementAndThrow));
            var dynamicInvoke = method.CreateDynamicInvokeDelegate(virtualDispatch: false);

            var instance = new C();
            var arguments = new object[] { 42 };
            Assert.Throws<ArithmeticException>(() => dynamicInvoke(instance, arguments));

            Assert.Equal(43, arguments[0]);
        }

        public interface I
        {
            int Echo(int arg)
            {
                return arg;
            }

            short Echo(short arg)
            {
                return arg;
            }

            object Echo(object arg)
            {
                return arg;
            }

            int PostIncrement(ref int arg)
            {
                return arg++;
            }

            int IncrementAndThrow(ref int arg)
            {
                arg++;
                throw new ArithmeticException();
            }
        }

        public class C : I
        {
            public int Echo(int arg)
            {
                return -arg;
            }
        }
    }
}
