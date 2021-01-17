// Copyright (c) 2021 stakx
// License available at https://github.com/stakx/Shards/blob/main/LICENSE.md.

namespace Shards
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;

    using Shards.Decompilation;

    public static partial class MethodBaseExtensions
    {
        public static Instruction[] Decode(this MethodBase method)
        {
            var code = method.GetMethodBody().GetILAsByteArray();

            var instructions = new List<Instruction>(capacity: code.Length / 2);
            var offset = 0;

            while (offset < code.Length)
            {
                var instruction = Instruction.Decode(code, offset);
                if (instruction.IsInvalid)
                {
                    throw new InvalidProgramException($"The IL contains an unrecognized or invalid instruction at byte offset {offset}.");
                }

                instructions.Add(instruction);
                offset += instruction.Length;
            }

            return instructions.ToArray();
        }
    }
}
