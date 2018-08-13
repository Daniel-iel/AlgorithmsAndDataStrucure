using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalindromeCode;

namespace PalindromeCodeTest
{
    [TestClass]
    public class PolindromeTest
    {
        [TestMethod]
        public void Palindrome1()
        {
            var result1 = Program.Palindrome1("aba");
            var result2 = Program.Palindrome1(" aba");
            var result3 = Program.Palindrome1("aba ");
            var result4 = Program.Palindrome1("greetings");
            var result5 = Program.Palindrome1("1000000001");
            var result6 = Program.Palindrome1("Fish hsif");
            var result7 = Program.Palindrome1("pennep");

            Assert.IsTrue(result1);
            Assert.IsFalse(result2);
            Assert.IsFalse(result3);
            Assert.IsFalse(result4);
            Assert.IsTrue(result5);
            Assert.IsFalse(result6);
            Assert.IsTrue(result7);
        }

        [TestMethod]
        public void Palindrome2()
        {
            var result1 = Program.Palindrome2("aba");
            var result2 = Program.Palindrome2(" aba");
            var result3 = Program.Palindrome2("aba ");
            var result4 = Program.Palindrome2("greetings");
            var result5 = Program.Palindrome2("1000000001");
            var result6 = Program.Palindrome2("Fish hsif");
            var result7 = Program.Palindrome2("pennep");

            Assert.IsTrue(result1);
            Assert.IsFalse(result2);
            Assert.IsFalse(result3);
            Assert.IsFalse(result4);
            Assert.IsTrue(result5);
            Assert.IsFalse(result6);
            Assert.IsTrue(result7);
        }

        [TestMethod]
        public void Palindrome3()
        {
            var result1 = Program.Palindrome3("aba");
            var result2 = Program.Palindrome3(" aba");
            var result3 = Program.Palindrome3("aba ");
            var result4 = Program.Palindrome3("greetings");
            var result5 = Program.Palindrome3("1000000001");
            var result6 = Program.Palindrome3("Fish hsif");
            var result7 = Program.Palindrome3("pennep");

            Assert.IsTrue(result1);
            Assert.IsFalse(result2);
            Assert.IsFalse(result3);
            Assert.IsFalse(result4);
            Assert.IsTrue(result5);
            Assert.IsFalse(result6);
            Assert.IsTrue(result7);
        }
    }
}
