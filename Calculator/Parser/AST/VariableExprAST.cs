// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com
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