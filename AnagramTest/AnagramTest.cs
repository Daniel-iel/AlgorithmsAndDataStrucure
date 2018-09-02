using AnagramCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnagramTest
{
    [TestClass]
    public class AnagramTest
    {
        [TestMethod]
        public void Anagram1()
        {
            var result = Program.Anagram1("hello", "llohe");
            var result2 = Program.Anagram1("Whoa! Hi!", "Hi! Whoa!");
            var result3 = Program.Anagram1("One One", "Two two two");
            var result4 = Program.Anagram1("One one", "One one c");
            var result5 = Program.Anagram1("A tree, a life, a bench", "A tree, a fence, a yard");

            Assert.IsTrue(result);
            Assert.IsTrue(result2);
            Assert.IsFalse(result3);
            Assert.IsFalse(result4);
            Assert.IsFalse(result5);
        }

        [TestMethod]
        public void Anagram2()
        {
            var result = Program.Anagram2("hello", "llohe");
            var result2 = Program.Anagram2("Whoa! Hi!", "Hi! Whoa!");
            var result3 = Program.Anagram2("One One", "Two two two");
            var result4 = Program.Anagram2("One one", "One one c");
            var result5 = Program.Anagram2("A tree, a life, a bench", "A tree, a fence, a yard");

            Assert.IsTrue(result);
            Assert.IsTrue(result2);
            Assert.IsFalse(result3);
            Assert.IsFalse(result4);
            Assert.IsFalse(result5);
        }

        [TestMethod]
        public void Anagram3()
        {
            var result = Program.Anagram3("hello", "llohe");
            var result2 = Program.Anagram3("Whoa! Hi!", "Hi! Whoa!");
            var result3 = Program.Anagram3("One One", "Two two two");
            var result4 = Program.Anagram3("One one", "One one c");
            var result5 = Program.Anagram3("A tree, a life, a bench", "A tree, a fence, a yard");

            Assert.IsTrue(result);
            Assert.IsTrue(result2);
            Assert.IsFalse(result3);
            Assert.IsFalse(result4);
            Assert.IsFalse(result5);
        }
    }
}
