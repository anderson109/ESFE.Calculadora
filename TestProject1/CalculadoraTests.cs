using ESFE.Calculadora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class CalculadoraTests
    {
        [Fact]
        public void Add_ShouldReturnCorrecrSum()
        {
            Calculadora calculadora = new Calculadora();
            double num1 = 5.0;
            double num2 = 3.0;

            double result = calculadora.Add(num1, num2);

            Assert.Equal(8.0, result);
        }

        [Fact]
        public void Substract_ShouldReturnCorrectDifference()
        {
            Calculadora calculadora = new Calculadora();
            double num1 = 8.0;
            double num2 = 3.0;

            double result = calculadora.Subtract(num1, num2);

            Assert.Equal(5.0, result);
        }

        [Fact]
        public void MultiPly_ShouldReturnCorrectProduct()
        {
            Calculadora calculadora = new Calculadora();
            double num1 = 4.0;
            double num2 = 2.0;

            double result = calculadora.Multiply(num1, num2);

            Assert.Equal(8.0, result);
        }

        [Fact]
        public void Divide_ShouldReturnCorrectQuotient()
        {
            Calculadora calculadora = new Calculadora();
            double num1 = 10.0;
            double num2 = 2.0;

            double result = calculadora.Divide(num1, num2);

            Assert.Equal(5.0, result);
        }

        [Fact]
        public void Divide_ByZero_ShouldThrowException()
        {
            Calculadora calculadora = new Calculadora();
            double num1 = 5.0;
            double num2 = 0.0;

            ;

            Assert.Throws<ArgumentException>(() => calculadora.Divide(num1,num2));
        }
    }
}
