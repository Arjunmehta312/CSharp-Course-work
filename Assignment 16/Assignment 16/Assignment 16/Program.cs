using System;

namespace Assignment16
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            Console.WriteLine("Calculator Application");
            Console.WriteLine("Add: " + calculator.Add(5, 3));
            Console.WriteLine("Subtract: " + calculator.Subtract(5, 3));
            Console.WriteLine("Multiply: " + calculator.Multiply(5, 3));
            Console.WriteLine("Divide: " + calculator.Divide(6, 3));
        }
    }

    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public double Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }
            return (double)a / b;
        }
    }
}
