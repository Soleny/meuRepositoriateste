using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exemplo1;

namespace Testes
{
    [TestClass]
    public class TestaCalculadora
    {
        [TestMethod]
        public void TestaSoma ()
        {
            Calculadora c = new Calculadora();
            int resultado = c.soma(3, 4);
            Assert.AreEqual(7, resultado);


                             
        }
    }
}
