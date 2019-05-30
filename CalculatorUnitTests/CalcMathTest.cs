using calculator.CalcMathematics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorUnitTests
{
    [TestClass]
    public class CalcMathTest
    {
        [TestMethod]
        public void YRootTest()
        {
            Assert.AreEqual(CalcMath.YRoot(2, 4), 2);
            Assert.AreEqual(CalcMath.YRoot(4, 256), 4);
        }

        [TestMethod]
        public void RootTest()
        {
            Assert.AreEqual(CalcMath.Root(4), 2);
            Assert.AreEqual(CalcMath.Root(256), 16);
        }

        [TestMethod]
        public void FactorialTest()
        {
            Assert.AreEqual(CalcMath.Fact(5), 120);
            Assert.AreEqual(CalcMath.Fact(4), 24);
        }

        [TestMethod]
        public void CosTest()
        {
            Assert.AreEqual(CalcMath.Cos(3.1415926535897931), -1);
            Assert.AreEqual(CalcMath.Cos(1.5707963267949), 0);
        }

        [TestMethod]
        public void SinTest()
        {
            Assert.AreEqual(CalcMath.Sin(3.1415926535897931), 0);
            Assert.AreEqual(CalcMath.Sin(4.71238898038469), -1);
        }

        [TestMethod]
        public void TanTest()
        {
            Assert.AreEqual(CalcMath.Tan(3.1415926535897931), 0);
            Assert.AreEqual(CalcMath.Tan(4.71238898038469), double.NaN);
        }

        [TestMethod]
        public void AcosTest()
        {
            Assert.AreEqual(CalcMath.Acos(0), 90);
            Assert.AreEqual(CalcMath.Acos(8), double.NaN);
        }

        [TestMethod]
        public void AsinTest()
        {
            Assert.AreEqual(CalcMath.Asin(1), 90);
            Assert.AreEqual(CalcMath.Asin(8), double.NaN);
        }

        [TestMethod]
        public void AtanTest()
        {
            Assert.AreEqual(CalcMath.Atan(1), 45);
            Assert.AreEqual(CalcMath.Atan(0), 0);
        }

        [TestMethod]
        public void LogTest()
        {
            Assert.AreEqual(CalcMath.Log(0), double.NegativeInfinity);
            Assert.AreEqual(CalcMath.Log(1), 0);
        }

        [TestMethod]
        public void LnTest()
        {
            Assert.AreEqual(CalcMath.Ln(0), double.NegativeInfinity);
            Assert.AreEqual(CalcMath.Ln(1), 0);
        }

        [TestMethod]
        public void ProcTest()
        {
            Assert.AreEqual(CalcMath.Proc(200), 2);
            Assert.AreEqual(CalcMath.Proc(1000), 10);
        }
    }
}
