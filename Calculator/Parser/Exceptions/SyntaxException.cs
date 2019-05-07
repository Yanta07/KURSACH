using System;

namespace calculator.Parser.Exceptions
{
    public class SyntaxException : Exception
    {
        public SyntaxException(string message) : base(message) { }
    }
}