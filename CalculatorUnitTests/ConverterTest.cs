using calculator.Converter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorUnitTests
{
    [TestClass]
    public class ConverterTest
    {
        [TestMethod]
        public void TempTest()
        {
            Assert.AreEqual(Converting.Temp("Кельвин", "Цельсий", 1), -272.15);
            Assert.AreEqual(Converting.Temp("Цельсий", "Фаренгейт", 1), 33.8);
        }

        [TestMethod]
        public void MassTest()
        {
            Assert.AreEqual(Converting.Mass("Тонна", "Центнер"), 10);
            Assert.AreEqual(Converting.Mass("Грамм", "КилоГрамм"), 0.001);
            Assert.AreEqual(Converting.Mass("Фунт", "Грамм"), 453, 59237);
        }

        [TestMethod]
        public void SITest()
        {
            Assert.AreEqual(Converting.SI("Мили", "Футы"), 5280);
            Assert.AreEqual(Converting.SI("Квадратные Метры", "Гектары"), 0.0001);
            Assert.AreEqual(Converting.SI("Кубические Метры", "Литры"), 1000);
            Assert.AreEqual(Converting.SI("Узлы", "Метры в секунду"), 0.51444);
        }
    }
}
