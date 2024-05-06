// See https://aka.ms/new-console-template for more information
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorLibrary;

namespace CalculatorTest
{
    [TestClass]
    public class CalculatorTests
    {
        private readonly ICalculator _calculator;

        public CalculatorTests()
        {
            _calculator = new Calculator();
        }

        [TestMethod]
        public void TestAdd()
        {
            Assert.AreEqual(8, _calculator.Add(5, 3));
        }

        [TestMethod]
        public void TestSubtract()
        {
            Assert.AreEqual(2, _calculator.Subtract(5, 3));
        }

        [TestMethod]
        public void TestMultiply()
        {
            Assert.AreEqual(15, _calculator.Multiply(5, 3));
        }

        [TestMethod]
        public void TestDivide()
        {
            Assert.AreEqual(2, _calculator.Divide(10, 5));
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivideByZero()
        {
            _calculator.Divide(10, 0);
        }

        [TestMethod]
        public void TestIsPrime()
        {
            Assert.IsTrue(_calculator.IsPrime(7));
            Assert.IsFalse(_calculator.IsPrime(9));
        }
    }
}


namespace CalculatorLibrary
{
    public interface ICalculator
    {
        int Add(int a, int b);
        int Subtract(int a, int b);
        int Multiply(int a, int b);
        int Divide(int a, int b);
        bool IsPrime(int number);
    }

    public class Calculator : ICalculator
    {
        public int Add(int a, int b) => a + b;

        public int Subtract(int a, int b) => a - b;

        public int Multiply(int a, int b) => a * b;

        public int Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero");
            }
            return a / b;
        }

        public bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}


