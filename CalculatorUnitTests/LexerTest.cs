using System.IO;
using calculator.Parser;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorUnitTests
{
    [TestClass]
    public class LexerTest
    {
        [TestMethod]
        public void TokenizerTest()
        {
            var testString = "2       + 3 - 4.5";

            var tokenizer = new Tokenizer(new StringReader(testString));

            Assert.AreEqual(tokenizer.Token, Token.Number);
            Assert.AreEqual(tokenizer.Number, 2);
            tokenizer.NextToken();

            Assert.AreEqual(tokenizer.Token, Token.Plus);
            tokenizer.NextToken();

            Assert.AreEqual(tokenizer.Token, Token.Number);
            Assert.AreEqual(tokenizer.Number, 3);
            tokenizer.NextToken();

            Assert.AreEqual(tokenizer.Token, Token.Minus);
            tokenizer.NextToken();

            Assert.AreEqual(tokenizer.Token, Token.Number);
            Assert.AreEqual(tokenizer.Number, 4.5);
            tokenizer.NextToken();
        }
    }
}
