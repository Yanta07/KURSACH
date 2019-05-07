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
        LParen,
        RParen,
        NumberSplit,
        Comma,
        Eof = -1
    }
}
