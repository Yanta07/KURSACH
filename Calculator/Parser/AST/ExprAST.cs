// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com
using calculator.Parser.Context;

namespace calculator.Parser.AST
{
    public abstract class ExprAst
    {
        public abstract double Eval(IContext context);
    }
}