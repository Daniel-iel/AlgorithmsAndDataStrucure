using FizzBuzzCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzTest
{
    [TestClass]
    public class FizzBuzzCodeTests
    {
        [TestMethod]
        public void FizzBuzz()
        {
            var result = Program.FizzBuzz(15);

            Assert.AreEqual("1", result[0]);
            Assert.AreEqual("2", result[1]);
            Assert.AreEqual("fizz", result[2]);
            Assert.AreEqual("4", result[3]);
            Assert.AreEqual("buzz", result[4]);
            Assert.AreEqual("fizz", result[5]);
            Assert.AreEqual("7", result[6]);
            Assert.AreEqual("8", result[7]);
            Assert.AreEqual("fizz", result[8]);
            Assert.AreEqual("buzz", result[9]);
            Assert.AreEqual("11", result[10]);
            Assert.AreEqual("fizz", result[11]);
            Assert.AreEqual("13", result[12]);
            Assert.AreEqual("14", result[13]);
            Assert.AreEqual("fizzbuzz", result[14]);
        }
    }
}
