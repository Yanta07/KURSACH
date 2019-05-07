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