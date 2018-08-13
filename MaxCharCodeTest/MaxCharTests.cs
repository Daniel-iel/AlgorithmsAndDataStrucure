using MaxCharCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MaxCharCodeTest
{
    [TestClass]
    public class MaxCharTests
    {
        [TestMethod]
        public void FindsThemostFrequentlyUsedChar()
        {   
            var result = Program.maxChar("abcdefghijklmnaaaaa");
            var result2 = Program.maxChar("ab1c1d1e1f1g1");

            Assert.AreEqual('a', result);
            Assert.AreEqual('1', result2);
        }
    }
}
