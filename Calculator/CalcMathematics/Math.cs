// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

using System;
using System.Linq;

namespace calculator.CalcMathematics
{
    public class CalcMath
    {
        public double pi { get; }
        public double e { get; }

        private static double _tolerance = 1e-8;

        public CalcMath()
        {
            pi = Math.PI;
            e = Math.E;
        }

        public static double YRoot(double a, double b)
        {
            return Math.Pow(Math.Abs(b), 1.0 / Math.Abs(a)) * Math.Sign(a);
        }

        public static double Fact(double number)
        {
            return Enumerable.Range(1, Convert.ToInt32(number)).Aggregate((i, r) => r * i);
        }

        public static double Root(double number)
        {
            return Math.Sqrt(number);
        }

        public static double Cos(double number)
        {
            if (Math.Abs(Math.Round(number, 5) - Math.Round(Math.PI / 2, 5)) < _tolerance || Math.Abs(number - 3 * Math.PI / 2) < _tolerance)
                return 0;
            return Math.Cos(number);
        }

        public static double Sin(double number)
        {
            if (Math.Abs(number - Math.PI) < _tolerance || Math.Abs(Math.Round(number, 5) - Math.Round(2 * Math.PI, 5)) < _tolerance)
                return 0;
            return Math.Sin(number);
        }

        public static double Tan(double number)
        {
            if (Math.Abs(Math.Round(number, 5) - Math.Round(Math.PI / 2, 5)) < _tolerance || Math.Abs(number - 3 * Math.PI / 2) < _tolerance)
                return (double.NaN);
            if (Math.Abs(number - Math.PI) < _tolerance) 
                return 0;
            return Math.Tan(number);
        }

        public static double Acos(double number)
        {
            return Math.Acos(number) * 180 / Math.PI;
        }

        public static double Asin(double number)
        {
            return Math.Asin(number) * 180 / Math.PI;
        }

        public static double Atan(double number)
        {
            return Math.Atan(number) * 180 / Math.PI;
        }

        public static double Log(double number)
        {
            return Math.Log10(number);
        }

        public static double Ln(double number)
        {
            return Math.Log(number);
        }

        public static double Proc(double number)
        {
            return number / 100;
        }
    }
}