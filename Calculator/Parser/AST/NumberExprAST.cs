// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com
using calculator.Parser.Context;

namespace calculator.Parser.AST
{
    public class NumberExprAst : ExprAst
    {
        private readonly double _value;

        public NumberExprAst(double value)
        {
            _value = value;
        }

        public override double Eval(IContext context)
        {
            return _value;
        }
    }
}