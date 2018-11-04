using CapitalizeCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CapitalizeTest
{
    [TestClass]
    public class CapitalizeCodeTest
    {
        [TestMethod]
        public void Captalize1()
        {
            var result = Program.Captalize1("hello world");

            Assert.AreEqual(result, "Hello World", false);
        }
    }
}
