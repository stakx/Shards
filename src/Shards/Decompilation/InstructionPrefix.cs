// Copyright (c) 2021 stakx
// License available at https://github.com/stakx/Shards/blob/main/LICENSE.md.

namespace Shards.Decompilation
{
    using System;
    using System.Diagnostics;

    /// <summary>
    ///   An instruction prefix of an <see cref="Instruction"/>.
    /// </summary>
    public readonly struct InstructionPrefix
    {
        private readonly OpCode opCode;
        private readonly int argument;

        internal InstructionPrefix(OpCode opCode, int argument = 0)
        {
            this.opCode = opCode;
            this.argument = argument;
        }

        /// <summary>
        ///   Determines whether this instruction prefix is invalid.
        /// </summary>
        public bool IsInvalid => !this.opCode.IsPrefix();

        /// <summary>
        ///   Gets the op-code of this instruction prefix.
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
        ///   Determines whether this instruction prefix has an immediate argument.
        /// </summary>
        public bool HasArgument
        {
            get
            {
                Debug.Assert(!this.IsInvalid);

                return this.opCode == OpCode.Constrained || this.opCode == OpCode.Unaligned;
            }
        }

        /// <summary>
        ///   Gets this instruction's immediate argument in the form of an <see langword="int"/>.
        /// </summary>
        /// <remarks>
        ///   Before calling this method, you must ensure that this instruction prefix has an immediate argument.
        ///   This is done by inferring the presence of an argument from <see cref="OpCode"/>, or
        ///   by querying the <see cref="HasArgument"/> property.
        /// </remarks>
        /// <returns>
        ///   The immediate argument.
        /// </returns>
        /// <exception cref="InvalidOperationException">
        ///   The instruction prefix has no immediate argument.
        /// </exception>
        public int GetArgumentAsInt32()
        {
            Debug.Assert(!this.IsInvalid);

            if (this.HasArgument)
            {
                return this.argument;
            }

            throw new InvalidOperationException("There is no argument.");
        }
    }
}
