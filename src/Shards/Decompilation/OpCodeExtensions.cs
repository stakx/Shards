// Copyright (c) 2021 stakx
// License available at https://github.com/stakx/Shards/blob/main/LICENSE.md.

namespace Shards.Decompilation
{
    using System.ComponentModel;

    using Debug = System.Diagnostics.Debug;

    using static OpCode;
    using static OpCodeArgumentLength;

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static class OpCodeExtensions
    {
        /// <summary>
        ///   Gets the length in bytes of the immediate argument expected to follow this op-code.
        /// </summary>
        /// <returns>
        ///   The length in bytes of this op-code's immediate argument.
        /// </returns>
        public static OpCodeArgumentLength GetArgumentLength(this OpCode opCode)
        {
            switch (opCode)
            {
                case Add:
                case Add_ovf:
                case Add_ovf_un:
                case And:
                case Arglist:
                case Break:
                case Ceq:
                case Cgt:
                case Cgt_un:
                case Ckfinite:
                case Clt:
                case Clt_un:
                case Conv_i1:
                case Conv_i2:
                case Conv_i4:
                case Conv_i8:
                case Conv_r4:
                case Conv_r8:
                case Conv_u1:
                case Conv_u2:
                case Conv_u4:
                case Conv_u8:
                case Conv_i:
                case Conv_u:
                case Conv_r_un:
                case Conv_ovf_i1:
                case Conv_ovf_i2:
                case Conv_ovf_i4:
                case Conv_ovf_i8:
                case Conv_ovf_u1:
                case Conv_ovf_u2:
                case Conv_ovf_u4:
                case Conv_ovf_u8:
                case Conv_ovf_i:
                case Conv_ovf_u:
                case Conv_ovf_i1_un:
                case Conv_ovf_i2_un:
                case Conv_ovf_i4_un:
                case Conv_ovf_i8_un:
                case Conv_ovf_u1_un:
                case Conv_ovf_u2_un:
                case Conv_ovf_u4_un:
                case Conv_ovf_u8_un:
                case Conv_ovf_i_un:
                case Conv_ovf_u_un:
                case Cpblk:
                case Div:
                case Div_un:
                case Dup:
                case Endfilter:
                case Endfinally:  // Endfault
                case Initblk:
                case Ldarg_0:
                case Ldarg_1:
                case Ldarg_2:
                case Ldarg_3:
                case Ldc_i4_0:
                case Ldc_i4_1:
                case Ldc_i4_2:
                case Ldc_i4_3:
                case Ldc_i4_4:
                case Ldc_i4_5:
                case Ldc_i4_6:
                case Ldc_i4_7:
                case Ldc_i4_8:
                case Ldc_i4_m1:
                case Ldind_i1:
                case Ldind_i2:
                case Ldind_i4:
                case Ldind_i8:  // Ldind_u8
                case Ldind_u1:
                case Ldind_u2:
                case Ldind_u4:
                case Ldind_r4:
                case Ldind_r8:
                case Ldind_i:
                case Ldind_ref:
                case Ldloc_0:
                case Ldloc_1:
                case Ldloc_2:
                case Ldloc_3:
                case Ldnull:
                case Localloc:
                case Mul:
                case Mul_ovf:
                case Mul_ovf_un:
                case Neg:
                case Nop:
                case Not:
                case Or:
                case Pop:
                case Rem:
                case Rem_un:
                case Ret:
                case Shl:
                case Shr:
                case Shr_un:
                case Stind_i1:
                case Stind_i2:
                case Stind_i4:
                case Stind_i8:
                case Stind_r4:
                case Stind_r8:
                case Stind_i:
                case Stind_ref:
                case Stloc_0:
                case Stloc_1:
                case Stloc_2:
                case Stloc_3:
                case Sub:
                case Sub_ovf:
                case Sub_ovf_un:
                case Xor:
                case Ldelem_i1:
                case Ldelem_i2:
                case Ldelem_i4:
                case Ldelem_i8:  // Ldelem_u8
                case Ldelem_u1:
                case Ldelem_u2:
                case Ldelem_u4:
                case Ldelem_r4:
                case Ldelem_r8:
                case Ldelem_i:
                case Ldelem_ref:
                case Ldlen:
                case Refanytype:
                case Rethrow:
                case Stelem_i1:
                case Stelem_i2:
                case Stelem_i4:
                case Stelem_i8:
                case Stelem_r4:
                case Stelem_r8:
                case Stelem_i:
                case Stelem_ref:
                case Throw:
                {
                    return Zero;
                }

                case Beq_s:
                case Bge_s:
                case Bge_un_s:
                case Bgt_s:
                case Bgt_un_s:
                case Ble_s:
                case Ble_un_s:
                case Blt_s:
                case Blt_un_s:
                case Bne_un_s:
                case Br_s:
                case Brfalse_s:  // Brnull_s, Brzero_s
                case Brtrue_s:
                case Ldarg_s: // !!!
                case Ldarga_s:
                case Ldc_i4_s:
                case Ldloc_s:
                case Ldloca_s:
                case Leave_s:
                case Starg_s:
                case Stloc_s:
                {
                    return One;
                }

                case Ldarg:
                case Ldarga:
                case Ldloc:
                case Ldloca:
                case Starg:
                case Stloc:
                {
                    return Two;
                }

                case Beq:
                case Bge:
                case Bge_un:
                case Bgt:
                case Bgt_un:
                case Ble:
                case Ble_un:
                case Blt:
                case Blt_un:
                case Bne_un:
                case Br:
                case Brfalse:  // Brnull, Brzero
                case Brtrue:
                case Call:
                case Calli:
                case Jmp:
                case Ldc_i4:
                case Ldc_r4:
                case Ldftn:
                case Leave:
                case Box:
                case Callvirt:
                case Castclass:
                case Cpobj:
                case Initobj:
                case Isinst:
                case Ldelem:
                case Ldelema:
                case Ldfld:
                case Ldflda:
                case Ldobj:
                case Ldsfld:
                case Ldsflda:
                case Ldstr:
                case Ldtoken:
                case Ldvirtfn:
                case Mkrefany:
                case Newarr:
                case Newobj:
                case Refanyval:
                case Sizeof:
                case Stelem:
                case Stfld:
                case Stobj:
                case Stsfld:
                case Unbox:
                case Unbox_any:
                {
                    return Four;
                }

                case Ldc_i8:
                case Ldc_r8:
                {
                    return Eight;
                }

                case Switch:
                {
                    return Unknown;
                }

                default:
                {
                    Debug.Fail($"Unknown op-code {opCode:x4}.");

                    return Unknown;
                }
            }
        }

        /// <summary>
        ///   Gets the length in bytes of this op-code (either 1 or 2).
        /// </summary>
        public static int GetLength(this OpCode opCode)
        {
            return ((int)opCode & 0x00ff) == 0xfe ? 2 : 1;
        }

        /// <summary>
        ///   Determines whether this op-code identifies an instruction prefix.
        /// </summary>
        /// <returns>
        ///   <see langword="true"/> if the op-code identifies an instruction prefix;
        ///   otherwise, <see langword="false"/>.
        /// </returns>
        public static bool IsPrefix(this OpCode opCode)
        {
            switch (opCode)
            {
                case Constrained:
                case No:
                case Readonly:
                case Unaligned:
                case Tail:
                case Volatile:
                    return true;

                default:
                    return false;
            }
        }
    }

    /// <summary>
    ///   The length of an op-code's immediate argument, including the special value <see cref="Unknown"/>.
    /// </summary>
    /// <remarks>
    ///   All enumeration values except <see cref="Unknown"/> have numerical values corresponding to their length in bytes.
    /// </remarks>
    public enum OpCodeArgumentLength
    {
        /// <summary>
        ///   The op-code does not have any immediate argument.
        /// </summary>
        Zero = 0,

        /// <summary>
        ///   This op-code has a 1-byte immediate argument.
        /// </summary>
        One = 1,

        /// <summary>
        ///   This op-code has a 2-byte immediate argument.
        /// </summary>
        Two = 2,

        /// <summary>
        ///   This op-code has a 4-byte immediate argument.
        /// </summary>
        Four = 4,

        /// <summary>
        ///   This op-code has an 8-byte immediate argument.
        /// </summary>
        Eight = 8,

        /// <summary>
        ///   The length of the op-code's immediate argument is not known.
        /// </summary>
        /// <remarks>
        ///   This value applies to the <c>switch</c> instruction's op-code,
        ///   as well as to unrecognized op-codes.
        /// </remarks>
        Unknown = -1,
    }
}
