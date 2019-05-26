using System;
using System.Linq;

namespace calculator.CalcMathematics
{
    public class CalcMath
    {
        public static double YRoot(double a, double b)
        {
            return Math.Round(Math.Pow(Math.Abs(a), 1.0 / b) * Math.Sign(a));
        }
    }
}