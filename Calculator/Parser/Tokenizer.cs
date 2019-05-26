// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com
// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

using System.Globalization;
using System.IO;
using System.Text;

namespace calculator.Parser
{
    public class Tokenizer
    {
        private readonly TextReader _textReader;
        private char _curChar;

        public Token Token { get; private set; }
        public string Identifier { get; private set; }
        public double Number { get; private set; }

        public Tokenizer(TextReader textReader)
        {
            _textReader = textReader;
            NextChar();
            NextToken();
        }

        private void NextChar()
        {
            int ch = _textReader.Read();

            _curChar = ch < 0 ? '\0' : (char) ch;
        }

        public void NextToken()
        {
            while (char.IsWhiteSpace(_curChar))
            {
                NextChar();
            }

            switch (_curChar)
            {
                case '\0':
                    Token = Token.Eof;
                    return;

                case '+':
                    NextChar();
                    Token = Token.Plus;
                    return;

                case '-':
                    NextChar();
                    Token = Token.Minus;
                    return;
                case '*':
                    NextChar();
                    Token = Token.Mul;
                    return;
                case '/':
                    NextChar();
                    Token = Token.Div;
                    return;
                case '(':
                    NextChar();
                    Token = Token.LParen;
                    return;
                case ')':
                    NextChar();
                    Token = Token.RParen;
                    return;
                case ',':
                    NextChar();
                    Token = Token.Comma;
                    return;
                case '.':
                    NextChar();
                    Token = Token.NumberSplit;
                    return;
                case '^':
                    NextChar();
                    Token = Token.Pow;
                    return;
            }

            if (_curChar == 'y')
            {
                NextChar();
                if (_curChar == 'r')
                {
                    NextChar();
                    Token = Token.YRoot;
                }
            }

            if (char.IsDigit(_curChar) || _curChar == '.')
            {
                var stringBuilder = new StringBuilder();
                bool decimalPoint = false;

                while (char.IsDigit(_curChar) || (!decimalPoint && _curChar == '.'))
                {
                    stringBuilder.Append(_curChar);
                    decimalPoint = _curChar == '.';
                    NextChar();
                }

                Number = double.Parse(stringBuilder.ToString(), CultureInfo.InvariantCulture);
                Token = Token.Number;
            }

            if (char.IsLetterOrDigit(_curChar) || _curChar == '_')
            {
                var stringBuilder = new StringBuilder();

                while (char.IsLetterOrDigit(_curChar) || _curChar == '_')
                {
                    stringBuilder.Append(_curChar);
                    NextChar();
                }

                Identifier = stringBuilder.ToString();
                Token = Token.Identifier;
            }
        }
    }
}