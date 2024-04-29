namespace StringLibraryTest;
public class Calculator {
    public int Add(int a, int b) => a + b;

    public int Subtract(int a, int b) => a - b;

    public int Multiply(int a, int b) => a * b;

    public int Divide(int a, int b)
    if (b==0) {
        throw new DivideByZeroException("Cannot divide by zero");

    else => a / b;
    } 

    public bool IsPrime (int number) {
        if (number <= 1) {
            return false
        }
        for (int i = 2; i < number; i++) {
            if (number % i == 0){
                return false;
            }
        }
        return true;
    }
   }
[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestAdicao()
    {
        int resultado = Calculator.Add(5, 3);
        Assert.AreEqual(8, resultado);
    }

    public void TestSubtracao()
    {
        int resultado = Calculator.Substract(5, 3);
        Assert.AreEqual(2, resultado);
    }

    public void TestMultiply()
    {
        int resultado = Calculator.Multiply(5, 3);
        Assert.AreEqual(15, resultado);
    }

    public void TestDivide()
    {
        int resultado = Calculator.Divide(10, 2);
        Assert.AreEqual(2, resultado);
    }

    public void TestIsPrime()
    {
        bool resultado = Callculator.IsPrime(true, false);
        Assert.AreEqual(true, resultado);
    }
}

public class Program 
{
    public static void Main(String[]args)
    {
        Calculator calculator = new Calculator();

        Console.WriteLine("Soma: " + calculator.Add(5,3));
        Console.WriteLine("Subtração: " + calculator.Substract(5,3));
        Console.WriteLine("Multiplicação: " + calculator.Multiply(5,3));
        Console.WriteLine("Divisão: " + calculator.Divide(10,2));

        Console.WriteLine("É primo?" + calculator.IsPrime(7));
    }
}