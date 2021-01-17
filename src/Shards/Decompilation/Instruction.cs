// Copyright (c) 2021 stakx
// License available at https://github.com/stakx/Shards/blob/main/LICENSE.md.

namespace Shards.Decompilation
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;

    using Debug = System.Diagnostics.Debug;

    /// <summary>
    ///   A single IL instruction, including its op-code, prefixes, and immediate argument(s).
    /// </summary>
    [DebuggerDisplay("{OpCode}")]
    public readonly struct Instruction
    {
        /// <summary>
        ///   Represents an invalid IL instruction
        /// </summary>
        public static readonly Instruction Invalid = default;

        /// <summary>
        ///   Decodes one IL instruction at the specified position in the given instruction block.
        /// </summary>
        /// <param name="code">
        ///   An IL instruction block (containing bytecode).
        /// </param>
        /// <param name="startOffset">
        ///   The byte offset in <paramref name="code"/> where decoding should start.
        /// </param>
        /// <returns>
        ///   If decoding was successful, a usable <see cref="Instruction"/> instance;
        ///   otherwise, <see cref="Instruction.Invalid"/>. You should check for the latter
        ///   by querying the <see cref="Instruction.IsInvalid"/> property.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        ///   <paramref name="code"/> is <see langword="null"/>.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        ///   <paramref name="startOffset"/> is not a valid byte offset.
        /// </exception>
        public static Instruction Decode(byte[] code, int startOffset)
        {
            if (code == null)
            {
                throw new ArgumentNullException(nameof(code));
            }

            if (startOffset < 0 || code.Length <= startOffset)
            {
                throw new ArgumentOutOfRangeException(nameof(startOffset));
            }

            int codeEndOffset = code.Length;

            int prefixesLength = 0;
            int offset = startOffset;

            while (true)
            {
                if (offset >= codeEndOffset) return default /* Invalid */;
                var first = code[offset];
                offset += 1;

                OpCode opCode;
                if (first == 0xfe)
                {
                    if (offset >= codeEndOffset) return default /* Invalid */;
                    var second = code[offset];
                    offset += 1;

                    opCode = (OpCode)(first | second << 8);
                }
                else
                {
                    opCode = (OpCode)first;
                }

                switch (opCode)
                {
                    case OpCode.Constrained:
                    {
                        if (offset + 4 > codeEndOffset) return default /* Invalid */;
                        offset += 4;

                        prefixesLength += opCode.GetLength() + 4;

                        break;
                    }

                    case OpCode.No:
                    case OpCode.Readonly:
                    case OpCode.Tail:
                    case OpCode.Volatile:
                    {
                        prefixesLength += opCode.GetLength();
                        break;
                    }

                    case OpCode.Unaligned:
                    {
                        if (offset >= codeEndOffset) return default /* Invalid */;
                        offset += 1;

                        prefixesLength += opCode.GetLength() + 1;

                        break;
                    }

                    case OpCode.Switch:
                    {
                        if (offset + 4 > codeEndOffset) return default /* Invalid */;
                        int n = GetFour(code, offset);
                        offset += 4;

                        var endOffset = offset + n * 4;
                        if (endOffset > codeEndOffset) return default /* Invalid */;

                        return new Instruction(code, startOffset, endOffset, prefixesLength, opCode);
                    }

                    default:
                    {
                        var argumentLength = opCode.GetArgumentLength();
                        if (argumentLength == OpCodeArgumentLength.Unknown) return default /* Invalid */;

                        var endOffset = offset + (int)argumentLength;
                        if (endOffset > codeEndOffset) return default /* Invalid */;

                        return new Instruction(code, startOffset, endOffset, prefixesLength, opCode);
                    }
                }
            }
        }

        private static short GetTwo(byte[] code, int offset)
        {
            Debug.Assert(0 <= offset && offset + 2 <= code.Length);

            return unchecked((short)(code[offset]
                                   | code[offset + 1] << 8));
        }

        private static int GetFour(byte[] code, int offset)
        {
            Debug.Assert(0 <= offset && offset + 4 <= code.Length);

            return unchecked(code[offset]
                           | code[offset + 1] << 8
                           | code[offset + 2] << 16
                           | code[offset + 3] << 24);
        }

        private static long GetEight(byte[] code, int offset)
        {
            Debug.Assert(0 <= offset && offset + 8 <= code.Length);

            return unchecked((long)code[offset]
                           | (long)code[offset + 1] << 8
                           | (long)code[offset + 2] << 16
                           | (long)code[offset + 3] << 24
                           | (long)code[offset + 4] << 32
                           | (long)code[offset + 5] << 40
                           | (long)code[offset + 6] << 48
                           | (long)code[offset + 7] << 56);
        }

        private readonly byte[] code;
        private readonly int startOffsetAndPrefixesLength;
        private readonly ushort length;
        private readonly OpCode opCode;

        private Instruction(byte[] code, int startOffset, int endOffset, int prefixesLength, OpCode opCode)
        {
            Debug.Assert(0 <= startOffset && startOffset <= code.Length);

            if (startOffset > 0xff_ffff)
            {
                throw new NotSupportedException("Instructions beyond the first 16 MiB of a method's body are not supported.");
            }

            Debug.Assert(0 <= endOffset && endOffset <= code.Length);
            Debug.Assert(startOffset < endOffset);

            if (endOffset - startOffset > 0xffff)
            {
                throw new NotSupportedException("Instructions longer than 64 KiB are not supported.");
            }

            Debug.Assert(prefixesLength >= 0);

            if (prefixesLength > 0xff)
            {
                throw new NotSupportedException("Instructions with more than 255 bytes of prefixes are not supported.");
            }

            Debug.Assert(0 <= prefixesLength && startOffset + prefixesLength < code.Length);
            Debug.Assert(opCode.GetLength() is > 0 and <= 2);
            Debug.Assert(opCode.GetLength() == 1 ? (OpCode)code[startOffset + prefixesLength] == opCode
                                                 : (OpCode)GetTwo(code, startOffset + prefixesLength) == opCode);

            this.code = code;
            this.startOffsetAndPrefixesLength = startOffset << 8 | prefixesLength;
            this.length = (ushort)(endOffset - startOffset);
            this.opCode = opCode;
        }

        /// <summary>
        ///   Determines whether this <see cref="Instruction"/> instance is invalid.
        /// </summary>
        /// <remarks>
        ///   Query this property right after retrieving this instance from <see cref="Decode"/>.
        /// </remarks>
        public bool IsInvalid => this.length == 0;

        /// <summary>
        ///   The IL instruction block from which this instance was decoded.
        /// </summary>
        public IReadOnlyList<byte> Code
        {
            get
            {
                Debug.Assert(!this.IsInvalid);

                return this.code ?? Array.Empty<byte>();
            }
        }

        /// <summary>
        ///   Gets the byte offset in the IL instruction block (<see cref="Code"/>) where this instruction starts.
        /// </summary>
        public int StartOffset
        {
            get
            {
                Debug.Assert(!this.IsInvalid);

                return this.startOffsetAndPrefixesLength >> 8;
            }
        }

        /// <summary>
        ///   Gets the total length in bytes of this instruction.
        /// </summary>
        public int Length
        {
            get
            {
                Debug.Assert(!this.IsInvalid);

                return this.length;
            }
        }

        /// <summary>
        ///   Determines whether this instruction has any prefixes.
        /// </summary>
        public bool HasPrefixes
        {
            get
            {
                Debug.Assert(!this.IsInvalid);

                return (this.startOffsetAndPrefixesLength & 0xff) > 0;
            }
        }

        /// <summary>
        ///   Gets the total length in bytes of this instruction's prefixes,
        ///   or 0 if it does not have any prefixes.
        /// </summary>
        public int PrefixesLength
        {
            get
            {
                Debug.Assert(!this.IsInvalid);

                return this.startOffsetAndPrefixesLength & 0xff;
            }
        }

        /// <summary>
        ///   Gets this instruction's op-code.
        /// </summary>
        public OpCode OpCode
        {
            get
            {
                Debug.Assert(!this.IsInvalid);

                return this.opCode;
            }
        }

        /// <summary>
        ///   Gets the length in bytes of this instruction's op-code.
        /// </summary>
        public int OpCodeLength
        {
            get
            {
                Debug.Assert(!this.IsInvalid);

                return this.length > 0 ? this.opCode.GetLength() : 0;
            }
        }

        /// <summary>
        ///   Determines whether this instruction has any immediate argument(s).
        /// </summary>
        public bool HasArgument
        {
            get
            {
                Debug.Assert(!this.IsInvalid);

                return this.ArgumentLength > 0;
            }
        }

        /// <summary>
        ///   Gets the total length in bytes of this instruction's immediate argument(s),
        ///   or 0 if it does not have any immediate argument.
        /// </summary>
        public int ArgumentLength
        {
            get
            {
                Debug.Assert(!this.IsInvalid);

                return this.Length - this.PrefixesLength - this.OpCodeLength;
            }
        }

        /// <summary>
        ///   Gets this instruction's immediate argument in the form of an <see langword="int"/>.
        /// </summary>
        /// <remarks>
        ///   Before calling this method, you must ensure that this instruction has an immediate argument,
        ///   and that it can fit inside an <see langword="int"/>. This is typically done by inferring
        ///   the argument type from <see cref="OpCode"/>, or by querying <see cref="HasArgument"/> and/or
        ///   <see cref="ArgumentLength"/>.
        /// </remarks>
        /// <returns>
        ///   The immediate argument.
        /// </returns>
        /// <exception cref="InvalidOperationException">
        ///   The immediate argument has a size other than 1, 2, or 4 bytes.
        /// </exception>
        public int GetArgumentAsInt32()
        {
            Debug.Assert(!this.IsInvalid);

            var argumentLength = this.ArgumentLength;

            if (argumentLength == 4)
            {
                return GetFour(code, this.StartOffset + this.Length - 4);
            }
            else if (argumentLength == 1)
            {
                return this.code[this.StartOffset + this.Length - 1];
            }
            else if (argumentLength == 2)
            {
                return GetTwo(code, this.StartOffset + this.Length - 2);
            }

            throw new InvalidOperationException("There is either no argument, or it has a size other than 1, 2, or 4 bytes.");
        }

        /// <summary>
        ///   Gets this instruction's immediate argument in the form of a <see langword="double"/>.
        /// </summary>
        /// <remarks>
        ///   Calling this method only makes sense for the <c>ldc.r4</c> and <c>ldc.r8</c> instructions,
        ///   as only those have a floating-point immediate argument.
        ///   <para>
        ///     Before calling this method, you must ensure that this instruction has an immediate argument,
        ///     and that it can fit inside a <see langword="double"/>. This is typically done by inferring
        ///     the argument type from <see cref="OpCode"/>, or by querying <see cref="HasArgument"/> and/or
        ///   <see cref="ArgumentLength"/>.
        ///   </para>
        /// </remarks>
        /// <returns>
        ///   The immediate argument.
        /// </returns>
        /// <exception cref="InvalidOperationException">
        ///   The immediate argument has a size other than 4 or 8 bytes.
        /// </exception>
        public unsafe double GetArgumentAsDouble()
        {
            Debug.Assert(!this.IsInvalid);

            var argumentLength = this.ArgumentLength;

            if (argumentLength == 8)
            {
                var bytes = GetEight(this.code, this.StartOffset + this.Length - 8);
                var converted = *(double*)&bytes;
                return converted;
            }
            else if (argumentLength == 4)
            {
                var bytes = GetFour(this.code, this.StartOffset + this.Length - 4);
                var converted = *(float*)&bytes;
                return converted;
            }

            throw new InvalidOperationException("There is either no argument, or it has a size other than 4 or 8 bytes.");
        }

        /// <summary>
        ///   Gets this instruction's immediate arguments as a sequence of <see langword="int"/>s.
        /// </summary>
        /// <remarks>
        ///   Calling this method is only valid for a <c>switch</c> instruction; that is,
        ///   the <see cref="OpCode"/> property must equal <see cref="OpCode.Switch"/>.
        /// </remarks>
        /// <returns>
        ///   The immediate arguments. Those are this <c>switch</c> instruction's branch targets.
        /// </returns>
        /// <exception cref="InvalidOperationException">
        ///   The instruction is not a <c>switch</c> instruction.
        /// </exception>
        public IEnumerable<int> GetArgumentsAsInt32s()
        {
            Debug.Assert(!this.IsInvalid);

            if (this.opCode != OpCode.Switch)
            {
                throw new InvalidOperationException("This instruction is not a `switch` instruction.");
            }

            var argumentLength = this.ArgumentLength;

            Debug.Assert(argumentLength >= 4 && argumentLength % 4 == 0);

            var offset = this.StartOffset + this.Length - argumentLength;

            var argumentCount = GetFour(code, offset);
            offset += 4;

            Debug.Assert(argumentCount == argumentLength / 4 - 1);

            for (int i = 0; i < argumentCount; i += 1)
            {
                yield return GetFour(code, offset);
                offset += 4;
            }
        }

        /// <summary>
        ///   Gets this instructions prefixes as a sequence of <see cref="InstructionPrefix"/>,
        ///   or an empty sequence if this instruction does not have any prefixes.
        /// </summary>
        /// <returns>
        ///   The instruction prefixes, if any; otherwise, an empty sequence.
        /// </returns>
        public IEnumerable<InstructionPrefix> GetPrefixes()
        {
            var offset = this.StartOffset;
            var prefixesEndOffset = this.StartOffset + this.PrefixesLength;

            while (true)
            {
                if (offset >= prefixesEndOffset) yield break;
                var first = code[offset];
                offset += 1;

                OpCode opCode;
                if (first == 0xfe)
                {
                    Debug.Assert(offset < prefixesEndOffset);

                    var second = code[offset];
                    offset += 1;

                    opCode = (OpCode)(first | second << 8);
                }
                else
                {
                    opCode = (OpCode)first;
                }

                switch (opCode)
                {
                    case OpCode.Constrained:
                    {
                        Debug.Assert(offset + 4 <= prefixesEndOffset);
                        var argument = GetFour(code, offset);
                        offset += 4;

                        yield return new InstructionPrefix(opCode, argument);
                        continue;
                    }

                    case OpCode.No:
                    case OpCode.Readonly:
                    case OpCode.Tail:
                    case OpCode.Volatile:
                    {
                        yield return new InstructionPrefix(opCode);
                        continue;
                    }

                    case OpCode.Unaligned:
                    {
                        Debug.Assert(offset < prefixesEndOffset);
                        var argument = code[offset];
                        offset += 1;

                        yield return new InstructionPrefix(opCode, argument);
                        continue;
                    }
                }
            }
        }
    }
}
