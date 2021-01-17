// Copyright (c) 2021 stakx
// License available at https://github.com/stakx/Shards/blob/main/LICENSE.md.

namespace Shards.Decompilation
{
    /// <summary>
    ///   An op-code.
    /// </summary>
    /// <remarks>
    ///   The numerical value corresponds to a Little Endian reading of the op-code's byte sequence
    ///   as it would appear in an IL instruction block.
    /// </remarks>
    public enum OpCode : short
    {
        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.2.1-constrained.md">III.2.1</a>.
        /// </remarks>
        Constrained = 0x16fe,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.2.2-no.md">III.2.2</a>.
        /// </remarks>
        No = 0x19fe,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.2.3-readonly.md">III.2.3</a>.
        /// </remarks>
        Readonly = 0x1efe,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.2.4-tail.md">III.2.4</a>.
        /// </remarks>
        Tail = 0x14fe,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.2.5-unaligned.md">III.2.5</a>.
        /// </remarks>
        Unaligned = 0x12fe,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.2.6-volatile.md">III.2.6</a>.
        /// </remarks>
        Volatile = 0x13fe,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.1-add.md">III.3.1</a>.
        /// </remarks>
        Add = 0x58,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.2-add.ovf.signed.md">III.3.2</a>.
        /// </remarks>
        Add_ovf = 0xd6,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.2-add.ovf.signed.md">III.3.2</a>.
        /// </remarks>
        Add_ovf_un = 0xd7,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.3-and.md">III.3.3</a>.
        /// </remarks>
        And = 0x5f,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.4-arglist.md">III.3.4</a>.
        /// </remarks>
        Arglist = 0x00fe,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.5-beq.length.md">III.3.5</a>.
        /// </remarks>
        Beq = 0x3b,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.5-beq.length.md">III.3.5</a>.
        /// </remarks>
        Beq_s = 0x2e,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.6-bge.length.md">III.3.6</a>.
        /// </remarks>
        Bge = 0x3c,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.6-bge.length.md">III.3.6</a>.
        /// </remarks>
        Bge_s = 0x2f,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.7-bge.un.length.md">III.3.7</a>.
        /// </remarks>
        Bge_un = 0x41,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.7-bge.un.length.md">III.3.7</a>.
        /// </remarks>
        Bge_un_s = 0x34,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.8-bgt.length.md">III.3.8</a>.
        /// </remarks>
        Bgt = 0x3d,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.8-bgt.length.md">III.3.8</a>.
        /// </remarks>
        Bgt_s = 0x30,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.9-bgt.un.length.md">III.3.9</a>.
        /// </remarks>
        Bgt_un = 0x42,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.9-bgt.un.length.md">III.3.9</a>.
        /// </remarks>
        Bgt_un_s = 0x35,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.10-ble.length.md">III.3.10</a>.
        /// </remarks>
        Ble = 0x3e,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.10-ble.length.md">III.3.10</a>.
        /// </remarks>
        Ble_s = 0x31,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.11-ble.un.length.md">III.3.11</a>.
        /// </remarks>
        Ble_un = 0x43,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.11-ble.un.length.md">III.3.11</a>.
        /// </remarks>
        Ble_un_s = 0x36,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.12-blt.length.md">III.3.12</a>.
        /// </remarks>
        Blt = 0x3f,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.12-blt.length.md">III.3.12</a>.
        /// </remarks>
        Blt_s = 0x32,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.13-blt.un.length.md">III.3.13</a>.
        /// </remarks>
        Blt_un = 0x44,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.13-blt.un.length.md">III.3.13</a>.
        /// </remarks>
        Blt_un_s = 0x37,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.14-bne.un.length.md">III.3.14</a>.
        /// </remarks>
        Bne_un = 0x40,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.14-bne.un.length.md">III.3.14</a>.
        /// </remarks>
        Bne_un_s = 0x33,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.15-br.length.md">III.3.15</a>.
        /// </remarks>
        Br = 0x38,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.15-br.length.md">III.3.15</a>.
        /// </remarks>
        Br_s = 0x2b,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.16-break.md">III.3.16</a>.
        /// </remarks>
        Break = 0x01,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.17-brfalse.length.md">III.3.17</a>.
        /// </remarks>
        Brfalse = 0x39,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.17-brfalse.length.md">III.3.17</a>.
        /// </remarks>
        Brfalse_s = 0x2c,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.17-brfalse.length.md">III.3.17</a>.
        /// </remarks>
        Brnull = Brfalse,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.17-brfalse.length.md">III.3.17</a>.
        /// </remarks>
        Brnull_s = Brfalse_s,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.17-brfalse.length.md">III.3.17</a>.
        /// </remarks>
        Brzero = Brfalse,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.17-brfalse.length.md">III.3.17</a>.
        /// </remarks>
        Brzero_s = Brfalse_s,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.18-brtrue.length.md">III.3.18</a>.
        /// </remarks>
        Brtrue = 0x3a,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.18-brtrue.length.md">III.3.18</a>.
        /// </remarks>
        Brtrue_s = 0x2d,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.18-brtrue.length.md">III.3.18</a>.
        /// </remarks>
        Brinst = Brtrue,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.18-brtrue.length.md">III.3.18</a>.
        /// </remarks>
        Brinst_s = Brtrue_s,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.19-call.md">III.3.19</a>.
        /// </remarks>
        Call = 0x28,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.20-calli.md">III.3.20</a>.
        /// </remarks>
        Calli = 0x29,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.21-ceq.md">III.3.21</a>.
        /// </remarks>
        Ceq = 0x01fe,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.22-cgt.md">III.3.22</a>.
        /// </remarks>
        Cgt = 0x02fe,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.23-cgt-un.md">III.3.23</a>.
        /// </remarks>
        Cgt_un = 0x03fe,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.24-ckfinite.md">III.3.24</a>.
        /// </remarks>
        Ckfinite = 0xc3,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.25-clt.md">III.3.25</a>.
        /// </remarks>
        Clt = 0x04fe,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.26-clt-un.md">III.3.26</a>.
        /// </remarks>
        Clt_un = 0x05fe,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.27-conv-to-type.md">III.3.27</a>.
        /// </remarks>
        Conv_i1 = 0x67,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.27-conv-to-type.md">III.3.27</a>.
        /// </remarks>
        Conv_i2 = 0x68,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.27-conv-to-type.md">III.3.27</a>.
        /// </remarks>
        Conv_i4 = 0x69,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.27-conv-to-type.md">III.3.27</a>.
        /// </remarks>
        Conv_i8 = 0x6a,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.27-conv-to-type.md">III.3.27</a>.
        /// </remarks>
        Conv_r4 = 0x6b,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.27-conv-to-type.md">III.3.27</a>.
        /// </remarks>
        Conv_r8 = 0x6c,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.27-conv-to-type.md">III.3.27</a>.
        /// </remarks>
        Conv_u1 = 0xd2,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.27-conv-to-type.md">III.3.27</a>.
        /// </remarks>
        Conv_u2 = 0xd1,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.27-conv-to-type.md">III.3.27</a>.
        /// </remarks>
        Conv_u4 = 0x6d,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.27-conv-to-type.md">III.3.27</a>.
        /// </remarks>
        Conv_u8 = 0x6e,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.27-conv-to-type.md">III.3.27</a>.
        /// </remarks>
        Conv_i = 0xd3,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.27-conv-to-type.md">III.3.27</a>.
        /// </remarks>
        Conv_u = 0xe0,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.27-conv-to-type.md">III.3.27</a>.
        /// </remarks>
        Conv_r_un = 0x76,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.28-conv-ovf-to-type.md">III.3.28</a>.
        /// </remarks>
        Conv_ovf_i1 = 0xb3,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.28-conv-ovf-to-type.md">III.3.28</a>.
        /// </remarks>
        Conv_ovf_i2 = 0xb5,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.28-conv-ovf-to-type.md">III.3.28</a>.
        /// </remarks>
        Conv_ovf_i4 = 0xb7,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.28-conv-ovf-to-type.md">III.3.28</a>.
        /// </remarks>
        Conv_ovf_i8 = 0xb9,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.28-conv-ovf-to-type.md">III.3.28</a>.
        /// </remarks>
        Conv_ovf_u1 = 0xb4,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.28-conv-ovf-to-type.md">III.3.28</a>.
        /// </remarks>
        Conv_ovf_u2 = 0xb6,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.28-conv-ovf-to-type.md">III.3.28</a>.
        /// </remarks>
        Conv_ovf_u4 = 0xb8,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.28-conv-ovf-to-type.md">III.3.28</a>.
        /// </remarks>
        Conv_ovf_u8 = 0xba,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.28-conv-ovf-to-type.md">III.3.28</a>.
        /// </remarks>
        Conv_ovf_i = 0xd4,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.28-conv-ovf-to-type.md">III.3.28</a>.
        /// </remarks>
        Conv_ovf_u = 0xd5,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.29-conv-ovf-to-type-un.md">III.3.29</a>.
        /// </remarks>
        Conv_ovf_i1_un = 0x82,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.29-conv-ovf-to-type-un.md">III.3.29</a>.
        /// </remarks>
        Conv_ovf_i2_un = 0x83,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.29-conv-ovf-to-type-un.md">III.3.29</a>.
        /// </remarks>
        Conv_ovf_i4_un = 0x84,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.29-conv-ovf-to-type-un.md">III.3.29</a>.
        /// </remarks>
        Conv_ovf_i8_un = 0x85,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.29-conv-ovf-to-type-un.md">III.3.29</a>.
        /// </remarks>
        Conv_ovf_u1_un = 0x86,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.29-conv-ovf-to-type-un.md">III.3.29</a>.
        /// </remarks>
        Conv_ovf_u2_un = 0x87,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.29-conv-ovf-to-type-un.md">III.3.29</a>.
        /// </remarks>
        Conv_ovf_u4_un = 0x88,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.29-conv-ovf-to-type-un.md">III.3.29</a>.
        /// </remarks>
        Conv_ovf_u8_un = 0x89,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.29-conv-ovf-to-type-un.md">III.3.29</a>.
        /// </remarks>
        Conv_ovf_i_un = 0x8a,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.29-conv-ovf-to-type-un.md">III.3.29</a>.
        /// </remarks>
        Conv_ovf_u_un = 0x8b,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.30-cpblk.md">III.3.30</a>.
        /// </remarks>
        Cpblk = 0x17fe,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.31-div.md">III.3.31</a>.
        /// </remarks>
        Div = 0x5b,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.32-div-un.md">III.3.32</a>.
        /// </remarks>
        Div_un = 0x5c,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.33-dup.md">III.3.33</a>.
        /// </remarks>
        Dup = 0x25,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.34-endfilter.md">III.3.34</a>.
        /// </remarks>
        Endfilter = 0x11fe,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.35-endfinally.md">III.3.35</a>.
        /// </remarks>
        Endfinally = 0xdc,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.35-endfinally.md">III.3.35</a>.
        /// </remarks>
        Endfault = Endfinally,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.36-initblk.md">III.3.36</a>.
        /// </remarks>
        Initblk = 0x18fe,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.37-jmp.md">III.3.37</a>.
        /// </remarks>
        Jmp = 0x27,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.38-ldarg-length.md">III.3.38</a>.
        /// </remarks>
        Ldarg = 0x09fe,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.38-ldarg-length.md">III.3.38</a>.
        /// </remarks>
        Ldarg_s = 0x0e,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.38-ldarg-length.md">III.3.38</a>.
        /// </remarks>
        Ldarg_0 = 0x02,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.38-ldarg-length.md">III.3.38</a>.
        /// </remarks>
        Ldarg_1 = 0x03,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.38-ldarg-length.md">III.3.38</a>.
        /// </remarks>
        Ldarg_2 = 0x04,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.38-ldarg-length.md">III.3.38</a>.
        /// </remarks>
        Ldarg_3 = 0x05,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.39-ldarga-length.md">III.3.39</a>.
        /// </remarks>
        Ldarga = 0x0afe,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.39-ldarga-length.md">III.3.39</a>.
        /// </remarks>
        Ldarga_s = 0x0f,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.40-ldc-type.md">III.3.40</a>.
        /// </remarks>
        Ldc_i4 = 0x20,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.40-ldc-type.md">III.3.40</a>.
        /// </remarks>
        Ldc_i8 = 0x21,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.40-ldc-type.md">III.3.40</a>.
        /// </remarks>
        Ldc_r4 = 0x22,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.40-ldc-type.md">III.3.40</a>.
        /// </remarks>
        Ldc_r8 = 0x23,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.40-ldc-type.md">III.3.40</a>.
        /// </remarks>
        Ldc_i4_0 = 0x16,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.40-ldc-type.md">III.3.40</a>.
        /// </remarks>
        Ldc_i4_1 = 0x17,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.40-ldc-type.md">III.3.40</a>.
        /// </remarks>
        Ldc_i4_2 = 0x18,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.40-ldc-type.md">III.3.40</a>.
        /// </remarks>
        Ldc_i4_3 = 0x19,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.40-ldc-type.md">III.3.40</a>.
        /// </remarks>
        Ldc_i4_4 = 0x1a,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.40-ldc-type.md">III.3.40</a>.
        /// </remarks>
        Ldc_i4_5 = 0x1b,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.40-ldc-type.md">III.3.40</a>.
        /// </remarks>
        Ldc_i4_6 = 0x1c,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.40-ldc-type.md">III.3.40</a>.
        /// </remarks>
        Ldc_i4_7 = 0x1d,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.40-ldc-type.md">III.3.40</a>.
        /// </remarks>
        Ldc_i4_8 = 0x1e,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.40-ldc-type.md">III.3.40</a>.
        /// </remarks>
        Ldc_i4_m1 = 0x15,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.40-ldc-type.md">III.3.40</a>.
        /// </remarks>
        Ldc_i4_s = 0x1f,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.41-ldftn.md">III.3.41</a>.
        /// </remarks>
        Ldftn = 0x06fe,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.42-ldind-type.md">III.3.42</a>.
        /// </remarks>
        Ldind_i1 = 0x46,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.42-ldind-type.md">III.3.42</a>.
        /// </remarks>
        Ldind_i2 = 0x48,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.42-ldind-type.md">III.3.42</a>.
        /// </remarks>
        Ldind_i4 = 0x4a,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.42-ldind-type.md">III.3.42</a>.
        /// </remarks>
        Ldind_i8 = 0x4c,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.42-ldind-type.md">III.3.42</a>.
        /// </remarks>
        Ldind_u1 = 0x47,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.42-ldind-type.md">III.3.42</a>.
        /// </remarks>
        Ldind_u2 = 0x49,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.42-ldind-type.md">III.3.42</a>.
        /// </remarks>
        Ldind_u4 = 0x4b,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.42-ldind-type.md">III.3.42</a>.
        /// </remarks>
        Ldind_r4 = 0x4e,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.42-ldind-type.md">III.3.42</a>.
        /// </remarks>
        Ldind_u8 = Ldind_i8,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.42-ldind-type.md">III.3.42</a>.
        /// </remarks>
        Ldind_r8 = 0x4f,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.42-ldind-type.md">III.3.42</a>.
        /// </remarks>
        Ldind_i = 0x4d,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.42-ldind-type.md">III.3.42</a>.
        /// </remarks>
        Ldind_ref = 0x50,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.43-ldloc.md">III.3.43</a>.
        /// </remarks>
        Ldloc = 0x0cfe,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.43-ldloc.md">III.3.43</a>.
        /// </remarks>
        Ldloc_s = 0x11,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.43-ldloc.md">III.3.43</a>.
        /// </remarks>
        Ldloc_0 = 0x06,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.43-ldloc.md">III.3.43</a>.
        /// </remarks>
        Ldloc_1 = 0x07,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.43-ldloc.md">III.3.43</a>.
        /// </remarks>
        Ldloc_2 = 0x08,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.43-ldloc.md">III.3.43</a>.
        /// </remarks>
        Ldloc_3 = 0x09,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.44-ldloca-length.md">III.3.44</a>.
        /// </remarks>
        Ldloca = 0x0dfe,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.44-ldloca-length.md">III.3.44</a>.
        /// </remarks>
        Ldloca_s = 0x12,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.45-ldnull.md">III.3.45</a>.
        /// </remarks>
        Ldnull = 0x14,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.46-leave-length.md">III.3.46</a>.
        /// </remarks>
        Leave = 0xdd,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.46-leave-length.md">III.3.46</a>.
        /// </remarks>
        Leave_s = 0xde,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.47-localloc.md">III.3.47</a>.
        /// </remarks>
        Localloc = 0x0ffe,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.48-mul.md">III.3.48</a>.
        /// </remarks>
        Mul = 0x5a,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.49-mul-ovf-type.md">III.3.49</a>.
        /// </remarks>
        Mul_ovf = 0xd8,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.49-mul-ovf-type.md">III.3.49</a>.
        /// </remarks>
        Mul_ovf_un = 0xd9,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.50-neg.md">III.3.50</a>.
        /// </remarks>
        Neg = 0x65,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.51-nop.md">III.3.51</a>.
        /// </remarks>
        Nop = 0x00,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.52-not.md">III.3.52</a>.
        /// </remarks>
        Not = 0x66,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.53-or.md">III.3.53</a>.
        /// </remarks>
        Or = 0x60,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.54-pop.md">III.3.54</a>.
        /// </remarks>
        Pop = 0x26,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.55-rem.md">III.3.55</a>.
        /// </remarks>
        Rem = 0x5d,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.56-rem-un.md">III.3.56</a>.
        /// </remarks>
        Rem_un = 0x5e,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.57-ret.md">III.3.57</a>.
        /// </remarks>
        Ret = 0x2a,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.58-shl.md">III.3.58</a>.
        /// </remarks>
        Shl = 0x62,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.59-shr.md">III.3.59</a>.
        /// </remarks>
        Shr = 0x63,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.60-shr-un.md">III.3.60</a>.
        /// </remarks>
        Shr_un = 0x64,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.61-starg-length.md">III.3.61</a>.
        /// </remarks>
        Starg = 0x0bfe,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.61-starg-length.md">III.3.61</a>.
        /// </remarks>
        Starg_s = 0x10,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.62-stind-type.md">III.3.62</a>.
        /// </remarks>
        Stind_i1 = 0x52,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.62-stind-type.md">III.3.62</a>.
        /// </remarks>
        Stind_i2 = 0x53,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.62-stind-type.md">III.3.62</a>.
        /// </remarks>
        Stind_i4 = 0x54,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.62-stind-type.md">III.3.62</a>.
        /// </remarks>
        Stind_i8 = 0x55,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.62-stind-type.md">III.3.62</a>.
        /// </remarks>
        Stind_r4 = 0x56,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.62-stind-type.md">III.3.62</a>.
        /// </remarks>
        Stind_r8 = 0x57,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.62-stind-type.md">III.3.62</a>.
        /// </remarks>
        Stind_i = 0xdf,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.62-stind-type.md">III.3.62</a>.
        /// </remarks>
        Stind_ref = 0x51,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.63-stloc.md">III.3.63</a>.
        /// </remarks>
        Stloc = 0x0efe,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.63-stloc.md">III.3.63</a>.
        /// </remarks>
        Stloc_s = 0x13,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.63-stloc.md">III.3.63</a>.
        /// </remarks>
        Stloc_0 = 0x0a,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.63-stloc.md">III.3.63</a>.
        /// </remarks>
        Stloc_1 = 0x0b,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.63-stloc.md">III.3.63</a>.
        /// </remarks>
        Stloc_2 = 0x0c,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.63-stloc.md">III.3.63</a>.
        /// </remarks>
        Stloc_3 = 0x0d,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.64-sub.md">III.3.64</a>.
        /// </remarks>
        Sub = 0x59,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.65-sub-ovf-type.md">III.3.65</a>.
        /// </remarks>
        Sub_ovf = 0xda,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.65-sub-ovf-type.md">III.3.65</a>.
        /// </remarks>
        Sub_ovf_un = 0xdb,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.66-switch.md">III.3.66</a>.
        /// </remarks>
        Switch = 0x45,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.3.67-xor.md">III.3.67</a>.
        /// </remarks>
        Xor = 0x61,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.4.1-box.md">III.4.1</a>.
        /// </remarks>
        Box = 0x8c,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.4.2-callvirt.md">III.4.2</a>.
        /// </remarks>
        Callvirt = 0x6f,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.4.3-castclass.md">III.4.3</a>.
        /// </remarks>
        Castclass = 0x74,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.4.4-cpobj.md">III.4.4</a>.
        /// </remarks>
        Cpobj = 0x70,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.4.5-initobj.md">III.4.5</a>.
        /// </remarks>
        Initobj = 0x15fe,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.4.6-isinst.md">III.4.6</a>.
        /// </remarks>
        Isinst = 0x75,

        /// <summary>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.4.7-ldelem.md">III.4.7</a>.
        /// </summary>
        Ldelem = 0xa3,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.4.8-ldelem-type.md">III.4.8</a>.
        /// </remarks>
        Ldelem_i1 = 0x90,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.4.8-ldelem-type.md">III.4.8</a>.
        /// </remarks>
        Ldelem_i2 = 0x92,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.4.8-ldelem-type.md">III.4.8</a>.
        /// </remarks>
        Ldelem_i4 = 0x94,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.4.8-ldelem-type.md">III.4.8</a>.
        /// </remarks>
        Ldelem_i8 = 0x96,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.4.8-ldelem-type.md">III.4.8</a>.
        /// </remarks>
        Ldelem_u1 = 0x91,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.4.8-ldelem-type.md">III.4.8</a>.
        /// </remarks>
        Ldelem_u2 = 0x93,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.4.8-ldelem-type.md">III.4.8</a>.
        /// </remarks>
        Ldelem_u4 = 0x95,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.4.8-ldelem-type.md">III.4.8</a>.
        /// </remarks>
        Ldelem_u8 = Ldelem_i8,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.4.8-ldelem-type.md">III.4.8</a>.
        /// </remarks>
        Ldelem_r4 = 0x98,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.4.8-ldelem-type.md">III.4.8</a>.
        /// </remarks>
        Ldelem_r8 = 0x99,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.4.8-ldelem-type.md">III.4.8</a>.
        /// </remarks>
        Ldelem_i = 0x97,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.4.8-ldelem-type.md">III.4.8</a>.
        /// </remarks>
        Ldelem_ref = 0x9a,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.4.9-ldelema.md">III.4.9</a>.
        /// </remarks>
        Ldelema = 0x8f,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.4.10-ldfld.md">III.4.10</a>.
        /// </remarks>
        Ldfld = 0x7b,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.4.11-ldflda.md">III.4.11</a>.
        /// </remarks>
        Ldflda = 0x7c,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.4.12-ldlen.md">III.4.12</a>.
        /// </remarks>
        Ldlen = 0x8e,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.4.13-ldobj.md">III.4.13</a>.
        /// </remarks>
        Ldobj = 0x71,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.4.14-ldsfld.md">III.4.14</a>.
        /// </remarks>
        Ldsfld = 0x7e,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.4.15-ldsflda.md">III.4.15</a>.
        /// </remarks>
        Ldsflda = 0x7f,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.4.16-ldstr.md">III.4.16</a>.
        /// </remarks>
        Ldstr = 0x72,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.4.17-ldtoken.md">III.4.17</a>.
        /// </remarks>
        Ldtoken = 0xd0,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.4.18-ldvirtftn.md">III.4.18</a>.
        /// </remarks>
        Ldvirtfn = 0x07fe,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.4.19-mkrefany.md">III.4.19</a>.
        /// </remarks>
        Mkrefany = 0xc6,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.4.20-newarr.md">III.4.20</a>.
        /// </remarks>
        Newarr = 0x8d,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.4.21-newobj.md">III.4.21</a>.
        /// </remarks>
        Newobj = 0x73,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.4.22-refanytype.md">III.4.22</a>.
        /// </remarks>
        Refanytype = 0x1dfe,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.4.23-refanyval.md">III.4.23</a>.
        /// </remarks>
        Refanyval = 0xc2,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.4.24-rethrow.md">III.4.24</a>.
        /// </remarks>
        Rethrow = 0x1afe,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.4.25-sizeof.md">III.4.25</a>.
        /// </remarks>
        Sizeof = 0x1cfe,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.4.26-stelem.md">III.4.26</a>.
        /// </remarks>
        Stelem = 0xa4,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.4.27-stelem-type.md">III.4.27</a>.
        /// </remarks>
        Stelem_i1 = 0x9c,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.4.27-stelem-type.md">III.4.27</a>.
        /// </remarks>
        Stelem_i2 = 0x9d,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.4.27-stelem-type.md">III.4.27</a>.
        /// </remarks>
        Stelem_i4 = 0x9e,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.4.27-stelem-type.md">III.4.27</a>.
        /// </remarks>
        Stelem_i8 = 0x9f,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.4.27-stelem-type.md">III.4.27</a>.
        /// </remarks>
        Stelem_r4 = 0xa0,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.4.27-stelem-type.md">III.4.27</a>.
        /// </remarks>
        Stelem_r8 = 0xa1,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.4.27-stelem-type.md">III.4.27</a>.
        /// </remarks>
        Stelem_i = 0x9b,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.4.27-stelem-type.md">III.4.27</a>.
        /// </remarks>
        Stelem_ref = 0xa2,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.4.28-stfld.md">III.4.28</a>.
        /// </remarks>
        Stfld = 0x7d,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.4.29-stobj.md">III.4.29</a>.
        /// </remarks>
        Stobj = 0x81,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.4.30-stsfld.md">III.4.30</a>.
        /// </remarks>
        Stsfld = 0x80,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.4.31-throw.md">III.4.31</a>.
        /// </remarks>
        Throw = 0x7a,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.4.32-unbox.md">III.4.32</a>.
        /// </remarks>
        Unbox = 0x79,

        /// <remarks>
        ///   Specified in ECMA-335 section <a href="https://github.com/stakx/ecma-335/blob/master/docs/iii.4.33-unbox-any.md">III.4.33</a>.
        /// </remarks>
        Unbox_any = 0xa5,
    }
}
