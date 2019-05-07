using calculator.Parser.Context;

namespace calculator.Parser.AST
{
    public class FunctionExprAst : ExprAst
    {
        private readonly string _funcName;
        private readonly ExprAst[] _funcArgNodes;

        public FunctionExprAst(string funcName, ExprAst[] funcArgNodes)
        {
            _funcName = funcName;
            _funcArgNodes = funcArgNodes;
        }


        public override double Eval(IContext context)
        {
            var argsEval = new double[_funcArgNodes.Length];

            for (int i = 0; i < _funcArgNodes.Length; i++)
            {
                argsEval[i] = _funcArgNodes[i].Eval(context);
            }

            return context.CallFunction(_funcName, argsEval);
        }
    }
}