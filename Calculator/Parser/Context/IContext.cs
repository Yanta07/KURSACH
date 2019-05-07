namespace calculator.Parser.Context
{
    public interface IContext
    {
        double ResolveVar(string name);
        double CallFunction(string name, double[] args);
    }
}