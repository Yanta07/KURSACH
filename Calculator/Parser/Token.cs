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
        Eof = -1
    }
}
