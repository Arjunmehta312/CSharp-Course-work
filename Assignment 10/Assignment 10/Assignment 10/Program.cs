using System;

namespace DelegateMathOperations
{
    delegate int MathOperation(int a, int b);

    class Program
    {
        static int Add(int a, int b) => a + b;
        static int Subtract(int a, int b) => a - b;
        static int Multiply(int a, int b) => a * b;
        static int Divide(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                return 0;
            }
            return a / b;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Choose an operation: ");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            int choice = int.Parse(Console.ReadLine());

            MathOperation operation = null;

            switch (choice)
            {
                case 1:
                    operation = Add;
                    break;
                case 2:
                    operation = Subtract;
                    break;
                case 3:
                    operation = Multiply;
                    break;
                case 4:
                    operation = Divide;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    return;
            }

            int result = operation(num1, num2);
            Console.WriteLine($"The result is: {result}");
        }
    }
}
