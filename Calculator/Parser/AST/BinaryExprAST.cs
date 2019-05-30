// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com
using System;
using calculator.Parser.Context;

namespace calculator.Parser.AST
{
    public class BinaryExprAST : ExprAst
    {
        private readonly ExprAst _lhs;
        private readonly ExprAst _rhs;
        private readonly Func<double, double, double> _op;

        public BinaryExprAST(ExprAst lhs, ExprAst rhs, Func<double, double, double> op)
        {
            _lhs = lhs;
            _rhs = rhs;
            _op = op;
        }


        public override double Eval(IContext context)
        {
            var lhsEval = _lhs.Eval(context);
            var rhsEval = _rhs.Eval(context);

            var result = _op(lhsEval, rhsEval);

            return result;
        }
    }
}