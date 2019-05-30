// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com
namespace calculator.Parser.Context
{
    public interface IContext
    {
        double ResolveVar(string name);
        double CallFunction(string name, double[] args);
    }
}