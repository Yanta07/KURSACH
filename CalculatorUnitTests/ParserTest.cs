using System;
using System.IO;
using calculator.Parser;
using calculator.Parser.Context;
using calculator.Parser.Exceptions;
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

            Assert.AreEqual(Parser.Parse("2 ^ 3 -2 @ 16").Eval(null), 4);

            Assert.AreEqual(Parser.Parse("2 ^ 3 -- 3 @ 64").Eval(null), 12);
            
            Assert.AreEqual(Parser.Parse("-- 3 @ 64").Eval(null), 4, 1e-6);
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
        public void ScientificNotationTest()
        {
            Assert.AreEqual(Parser.Parse("1E-6").Eval(null), 1e-6);

            Assert.AreEqual(Parser.Parse("1E+6").Eval(null), 1e+6);

            Assert.AreEqual(Parser.Parse("10E+2").Eval(null), 10e+2);
        }

        [TestMethod]
        public void OperationsOrderTest()
        {
            Assert.AreEqual(Parser.Parse("10 + 15 * 15").Eval(null), 235);

            Assert.AreEqual(Parser.Parse("(10 + 15) * 15").Eval(null), 375);

            Assert.AreEqual(Parser.Parse("-(10 + 15) * 15").Eval(null), -375);

            Assert.AreEqual(Parser.Parse("-(-(10 + 15) + 5) * 15").Eval(null), 300);
        }

        [TestMethod]
        public void MissingRParan()
        {
            try
            {
                Parser.Parse("2+(3-1").Eval(null);
            }
            catch (Exception e)
            {
                Assert.AreEqual(e.Message,"Missing closing parenthesis");
            }
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

        class TestVar
        {
            public TestVar(double epsilon)
            {
                this.Epsilon = epsilon;
            }

            public double GetEpsilon()
            {
                return this.Epsilon;
            }

            public double Epsilon { get; }
        }

        [TestMethod]
        public void TestVariable()
        {
            var lib = new TestVar(1e-8);

            var context = new ReflectionContext(lib);

            Assert.AreEqual(Parser.Parse("Epsilon").Eval(context), 1e-8);

            try
            {
                Parser.Parse("pi").Eval(context);
            }
            catch (Exception e)
            {
                Assert.IsTrue(e is InvalidDataException);
            }
        }

        [TestMethod]
        public void TestSyntaxException()
        {
            try
            {
                Parser.Parse("2+").Eval(null);
            }
            catch (Exception e)
            {
                Assert.IsTrue(e is SyntaxException);
            }
        }

        [TestMethod]
        public void TestLibrary()
        {
            var lib = new TestLib();

            var context = new ReflectionContext(lib);

            Assert.AreEqual(Parser.Parse("Sqrt(4)").Eval(context), 2);

            Assert.AreEqual(Parser.Parse("SqrtWithArg(4, 2)").Eval(context), 2);


            try
            {
                Parser.Parse("Pow(4)").Eval(context);
            }
            catch (Exception e)
            {
                Assert.IsTrue(e is InvalidDataException);
            }
        }
    }
}
