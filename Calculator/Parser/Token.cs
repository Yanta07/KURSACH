// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com
namespace calculator.Parser
{
    public enum Token
    {
        Number,
        Identifier,
        Plus,
        Minus,
        Mul,
        Div,
        Pow,
        YRoot,
        LParen,
        RParen,
        NumberSplit,
        Comma,
        Eof = -1
    }
}
