// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com
using System;
using System.Collections.Generic;
using System.IO;
using calculator.CalcMathematics;
using calculator.Parser.AST;
using calculator.Parser.Exceptions;

namespace calculator.Parser
{
    public class Parser
    {
        private readonly Tokenizer _tokenizer;

        public static ExprAst Parse(string str)
        {
            using (StringReader reader = new StringReader(str))
            {
                return Parse(new Tokenizer(reader));
            }
        }

        private static ExprAst Parse(Tokenizer tokenizer)
        {
            var parser = new Parser(tokenizer);

            return parser.ParseExprAst();
        }

        public Parser(Tokenizer tokenizer)
        {
            _tokenizer = tokenizer;
        }

        public ExprAst ParseExprAst()
        {
            var expr = ParseAddSubstract();
            if (_tokenizer.Token != Token.Eof)
            {
                throw new SyntaxException("Unexpected characters at end of expression");
            }

            return expr;
        }

        private ExprAst ParseAddSubstract()
        {
            var lhs = ParseMulDiv();

            while (true)
            {
                Func<double, double, double> op = null;

                if (_tokenizer.Token == Token.Plus)
                {
                    op = (a, b) => a + b;
                }
                else if (_tokenizer.Token == Token.Minus)
                {
                    op = (a, b) => a - b;
                }

                if (op == null)
                {
                    return lhs;
                }

                _tokenizer.NextToken();

                var rhs = ParseMulDiv();

                lhs = new BinaryExprAST(lhs, rhs, op);
            }
        }

        private ExprAst ParseMulDiv()
        {
            var lhs = ParseUnary();
            while (true)
            {
                Func<double, double, double> op = null;


                if (_tokenizer.Token == Token.Pow)
                {
                    op = Math.Pow;
                }

                if (_tokenizer.Token == Token.YRoot)
                {
                    op = CalcMath.YRoot;
                }

                if (_tokenizer.Token == Token.Mul)
                {
                    op = (a, b) => a * b;
                }
                else if(_tokenizer.Token == Token.Div)
                {
                    op = (a, b) => a / b;
                }

                if (op == null)
                {
                    return lhs;
                }

                _tokenizer.NextToken();

                var rhs = ParseUnary();

                lhs = new BinaryExprAST(lhs, rhs, op);
            }
        }

        private ExprAst ParseUnary()
        {
            while (true)
            {
                if (_tokenizer.Token == Token.Plus)
                {
                    _tokenizer.NextToken();
                    continue;
                }

                if (_tokenizer.Token == Token.Minus)
                {
                    _tokenizer.NextToken();
                    var rhs = ParseUnary();

                    return new UnaryExprAST(rhs, (a) => -a);
                }

                return ParseLeaf();
            }
        }

        private ExprAst ParseLeaf()
        {
            if (_tokenizer.Token == Token.Number)
            {
                var node = new NumberExprAst(_tokenizer.Number);
                _tokenizer.NextToken();
                return node;
            }

            if (_tokenizer.Token == Token.LParen)
            {
                _tokenizer.NextToken();

                var node = ParseAddSubstract();

                if (_tokenizer.Token != Token.RParen)
                {
                    throw new SyntaxException("Missing closing parenthesis");
                }

                _tokenizer.NextToken();

                return node;
            }

            if (_tokenizer.Token == Token.Identifier)
            {
                var name = _tokenizer.Identifier;
                _tokenizer.NextToken();

                if (_tokenizer.Token != Token.LParen)
                {
                    return new VariableExprAST(name);
                }
                
                _tokenizer.NextToken();

                var args = new List<ExprAst>();
                while (true)
                {
                    args.Add(ParseAddSubstract());

                    if (_tokenizer.Token == Token.Comma)
                    {
                        _tokenizer.NextToken();
                        continue;
                    }

                    break;
                }

                if (_tokenizer.Token != Token.RParen)
                {
                    throw new SyntaxException("Missing closing parenthesis");
                }

                _tokenizer.NextToken();

                return new FunctionExprAst(name, args.ToArray());
            }

            throw new SyntaxException($"Unexpected token: {_tokenizer.Token}");
        }
    }
}