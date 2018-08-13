using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringReversalCode;

namespace StringReversalCodeTest
{
    [TestClass]
    public class StringReversalTests
    {
        [TestMethod]
        public void reverse1()
        {
            var result1 = Program.reverse1("abcd");
            var result2 = Program.reverse1("  abcd");

            Assert.AreEqual("dcba", result1);
            Assert.AreEqual("dcba  ", result2);
        }

        [TestMethod]
        public void reverse2()
        {
            var result1 = Program.reverse2("abcd");
            var result2 = Program.reverse2("  abcd");

            Assert.AreEqual("dcba", result1);
            Assert.AreEqual("dcba  ", result2);
        }

        [TestMethod]
        public void reverse3()
        {
            var result1 = Program.reverse3("abcd");
            var result2 = Program.reverse3("  abcd");

            Assert.AreEqual("dcba", result1);
            Assert.AreEqual("dcba  ", result2);
        }
    }
}
