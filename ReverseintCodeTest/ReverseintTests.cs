using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReverseintCode;

namespace ReverseintCodeTest
{
    [TestClass]
    public class ReverseintTests
    {
        [TestMethod]
        public void ReverseintCode_TesteNumerosPOsitivos()
        {
            var metodo = new Program();

            var resultado = metodo.Reverseint(5);
            var resultado2 = metodo.Reverseint(15);
            var resultado3 = metodo.Reverseint(90);
            var resultado4 = metodo.Reverseint(2359);

            Assert.AreEqual(5, resultado);
            Assert.AreEqual(51, resultado2);
            Assert.AreEqual(9, resultado3);
            Assert.AreEqual(9532, resultado4);
        }

        [TestMethod]
        public void ReverseintCode_TesteNumerosNegativos()
        {
            var metodo = new Program();

            var resultado = metodo.Reverseint(-5);
            var resultado2 = metodo.Reverseint(-15);
            var resultado3 = metodo.Reverseint(-90);
            var resultado4 = metodo.Reverseint(-2359);

            Assert.AreEqual(-5, resultado);
            Assert.AreEqual(-51, resultado2);
            Assert.AreEqual(-9, resultado3);
            Assert.AreEqual(-9532, resultado4);
        }
    }
}
