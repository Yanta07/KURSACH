using calculator.Parser.Context;

namespace calculator.Parser.AST
{
    public abstract class ExprAst
    {
        public abstract double Eval(IContext context);
    }
}