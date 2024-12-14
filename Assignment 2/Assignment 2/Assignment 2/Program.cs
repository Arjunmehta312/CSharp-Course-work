using System;

class BasicCalculator
{
    static void Main(string[] args)
    {
        bool continueCalculation = true;

        while (continueCalculation)
        {
            Console.WriteLine("Enter the first number:");
            string input1 = Console.ReadLine();
            if (!double.TryParse(input1, out double number1))
            {
                Console.WriteLine("Invalid input. Please enter a numeric value.");
                continue;
            }

            Console.WriteLine("Enter the second number:");
            string input2 = Console.ReadLine();
            if (!double.TryParse(input2, out double number2))
            {
                Console.WriteLine("Invalid input. Please enter a numeric value.");
                continue;
            }

            Console.WriteLine("Select operation: (1) Addition (2) Subtraction (3) Multiplication (4) Division");
            string choice = Console.ReadLine();

            double result;
            switch (choice)
            {
                case "1":
                    result = number1 + number2;
                    Console.WriteLine($"Result: {number1} + {number2} = {result}");
                    break;
                case "2":
                    result = number1 - number2;
                    Console.WriteLine($"Result: {number1} - {number2} = {result}");
                    break;
                case "3":
                    result = number1 * number2;
                    Console.WriteLine($"Result: {number1} * {number2} = {result}");
                    break;
                case "4":
                    if (number2 == 0)
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    else
                    {
                        result = number1 / number2;
                        Console.WriteLine($"Result: {number1} / {number2} = {result}");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operation choice. Please select a valid option (1-4).");
                    break;
            }

            Console.WriteLine("Do you want to perform another calculation? (Yes/No):");
            string response = Console.ReadLine()?.Trim().ToLower();
            continueCalculation = response == "yes";

            if (!continueCalculation)
            {
                Console.WriteLine("Goodbye!");
            }
        }
    }
}
