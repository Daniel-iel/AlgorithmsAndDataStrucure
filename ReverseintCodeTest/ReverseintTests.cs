using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReverseintCode;

namespace ReverseintCodeTest
{
    [TestClass]
    public class ReverseintTests
    {
        [TestMethod]
        public void Reverseint_TesteNumerosPOsitivos()
        {
            var resultado = Program.Reverseint(5);
            var resultado2 = Program.Reverseint(15);
            var resultado3 = Program.Reverseint(90);
            var resultado4 = Program.Reverseint(2359);

            Assert.AreEqual(5, resultado);
            Assert.AreEqual(51, resultado2);
            Assert.AreEqual(9, resultado3);
            Assert.AreEqual(9532, resultado4);
        }

        [TestMethod]
        public void Reverseint_TesteNumerosNegativos()
        {
            var resultado = Program.Reverseint(-5);
            var resultado2 = Program.Reverseint(-15);
            var resultado3 = Program.Reverseint(-90);
            var resultado4 = Program.Reverseint(-2359);

            Assert.AreEqual(-5, resultado);
            Assert.AreEqual(-51, resultado2);
            Assert.AreEqual(-9, resultado3);
            Assert.AreEqual(-9532, resultado4);
        }

        [TestMethod]
        public void Reverseint1_TesteNumerosPOsitivos()
        {
            var resultado = Program.Reverseint1(5);
            var resultado2 = Program.Reverseint1(15);
            var resultado3 = Program.Reverseint1(90);
            var resultado4 = Program.Reverseint1(2359);

            Assert.AreEqual(5, resultado);
            Assert.AreEqual(51, resultado2);
            Assert.AreEqual(9, resultado3);
            Assert.AreEqual(9532, resultado4);
        }

        [TestMethod]
        public void Reverseint1_TesteNumerosNegativos()
        {
            var resultado = Program.Reverseint1(-5);
            var resultado2 = Program.Reverseint1(-15);
            var resultado3 = Program.Reverseint1(-90);
            var resultado4 = Program.Reverseint1(-2359);

            Assert.AreEqual(-5, resultado);
            Assert.AreEqual(-51, resultado2);
            Assert.AreEqual(-9, resultado3);
            Assert.AreEqual(-9532, resultado4);
        }
    }
}
