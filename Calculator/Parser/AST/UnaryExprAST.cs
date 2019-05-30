// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com
using System;
using calculator.Parser.Context;

namespace calculator.Parser.AST
{
    public class UnaryExprAST : ExprAst
    {
        private readonly ExprAst _rhs;
        private readonly Func<double, double> _op;

        public UnaryExprAST(ExprAst rhs, Func<double, double> op)
        {
            _rhs = rhs;
            _op = op;
        }

        public override double Eval(IContext context)
        {
            var rhsResult = _rhs.Eval(context);

            var result = _op(rhsResult);

            return result;
        }
    }
}