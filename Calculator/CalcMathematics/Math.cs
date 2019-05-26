using System;
using System.Linq;

namespace calculator.CalcMathematics
{
    public class CalcMath
    {
        public static double YRoot(double a, double b)
        {
            return Math.Round(Math.Pow(Math.Abs(b), 1.0 / Math.Abs(a)) * Math.Sign(a));
        }

        public static double Fact(double number)
        {
            return Enumerable.Range(1, Convert.ToInt32(number)).Aggregate((i, r) => r * i);
        }

        public static double Root(double number)
        {
            return Math.Sqrt(number);
        }
    }
}