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
    }
}
