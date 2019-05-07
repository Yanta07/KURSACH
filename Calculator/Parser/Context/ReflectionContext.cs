using System.IO;
using System.Linq;

namespace calculator.Parser.Context
{
    public class ReflectionContext : IContext
    {
        private readonly object _target;

        public ReflectionContext(object target)
        {
            _target = target;
        }


        public double ResolveVar(string name)
        {
            var obj = _target.GetType().GetProperty(name);

            if (obj == null)
            {
                throw new InvalidDataException($"Unknown variable: {name}");
            }

            return (double) obj.GetValue(_target);
        }

        public double CallFunction(string name, double[] args)
        {
            var objs = _target.GetType().GetMethod(name);
            if (objs == null)
            {
                throw new InvalidDataException($"Unknown function: {name}");
            }

            var objsArgs = args.Select(x => (object) x).ToArray();

            return (double) objs.Invoke(_target, objsArgs);
        }
    }
}