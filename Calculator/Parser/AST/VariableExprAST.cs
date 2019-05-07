using calculator.Parser.Context;

namespace calculator.Parser.AST
{
    public class VariableExprAST : ExprAst
    {
        private readonly string _varName;

        public VariableExprAST(string varName)
        {
            _varName = varName;
        }

        public override double Eval(IContext context)
        {
            return context.ResolveVar(_varName);
        }
    }
}