using System;
using calculator.Parser;
using calculator.Parser.Context;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorUnitTests
{
    [TestClass]
    public class ParserTest
    {
        [TestMethod]
        public void AddSubstractTest()
        {
            Assert.AreEqual(Parser.Parse("15 + 15").Eval(null), 30);

            Assert.AreEqual(Parser.Parse("15 - 10").Eval(null), 5);

            Assert.AreEqual(Parser.Parse("15 + 15  -  15 + 10").Eval(null), 25);
        }

        [TestMethod]
        public void MulDivTest()
        {
            Assert.AreEqual(Parser.Parse("15 * 15").Eval(null), 225);

            Assert.AreEqual(Parser.Parse("15 / 10").Eval(null), 1.5);

            Assert.AreEqual(Parser.Parse("15 * 15  *  15 / 10").Eval(null), 337.5);
        }

        [TestMethod]
        public void PowYRootTest()
        {
            Assert.AreEqual(Parser.Parse("2 ^ 3").Eval(null), 8);

            Assert.AreEqual(Parser.Parse("2 ^ 3 -16 yr 2").Eval(null), 4);

            Assert.AreEqual(Parser.Parse("2 ^ 3 -- 64 yr 3").Eval(null), 12);
            
            Assert.AreEqual(Parser.Parse("-- 64 yr 3").Eval(null), 4);
        }

        [TestMethod]
        public void UnaryTest()
        {
            Assert.AreEqual(Parser.Parse("-10").Eval(null), -10);

            Assert.AreEqual(Parser.Parse("+10").Eval(null), 10);

            Assert.AreEqual(Parser.Parse("--10").Eval(null), 10);

            Assert.AreEqual(Parser.Parse("--++-+--10").Eval(null), -10);

            Assert.AreEqual(Parser.Parse("10 + -20 - + 45").Eval(null), -55);
        }


        [TestMethod]
        public void OperationsOrderTest()
        {
            Assert.AreEqual(Parser.Parse("10 + 15 * 15").Eval(null), 235);

            Assert.AreEqual(Parser.Parse("(10 + 15) * 15").Eval(null), 375);

            Assert.AreEqual(Parser.Parse("-(10 + 15) * 15").Eval(null), -375);

            Assert.AreEqual(Parser.Parse("-(-(10 + 15) + 5) * 15").Eval(null), 300);
        }

        class TestLib
        {
            public double Sqrt(double value)
            {
                return Math.Sqrt(value);
            }

            public double SqrtWithArg(double value, double power)
            {
                return Math.Pow(value, 1.0 / power);
            }
        }

        [TestMethod]
        public void TestLibrary()
        {
            var lib = new TestLib();

            var context = new ReflectionContext(lib);

            Assert.AreEqual(Parser.Parse("Sqrt(4)").Eval(context), 2);

            Assert.AreEqual(Parser.Parse("SqrtWithArg(4, 2)").Eval(context), 2);
        }
    }
}
