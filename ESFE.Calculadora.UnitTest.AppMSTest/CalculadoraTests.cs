using Microsoft.VisualStudio.TestTools.UnitTesting;
using ESFE.Calculadora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.Calculadora.Tests
{
    [TestClass()]
    public class CalculadoraTests
    {
        [TestMethod()]
        public void AddTest()
        {
            Calculadora calculadora = new Calculadora();

            double result = calculadora.Add(5, 3);

            Assert.AreEqual(8, result);
        }

        [TestMethod()]
        public void SubtractTest()
        {
            Calculadora calculadora = new Calculadora();

            double result = calculadora.Subtract(5, 3);

            Assert.AreEqual(2, result);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            Calculadora calculadora = new Calculadora();

            double result = calculadora.Multiply(5, 3);

            Assert.AreEqual(15, result);
        }

        [TestMethod()]
        public void DivideTest()
        {
            Calculadora calculadora = new Calculadora();

            double result = calculadora.Divide(6,2);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DivideByZeroTest()
        {
            Calculadora calculadora = new Calculadora();

            double result = calculadora.Divide(5, 0);
        }
    }
}