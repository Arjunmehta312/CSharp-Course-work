using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public static void Main()
        {
            Console.Write("Enter the starting number: ");
            int start;
            while (!int.TryParse(Console.ReadLine(), out start) || start < 0)
            {
                Console.Write("Invalid input. Please enter a positive integer: ");
            }

            Console.Write("Enter the ending number: ");
            int end;
            while (!int.TryParse(Console.ReadLine(), out end) || end <= start)
            {
                Console.Write("Invalid input. Please enter a number greater than the starting number: ");
            }

            bool foundPrime = false;
            Console.Write("Prime numbers between {0} and {1} are: ", start, end);
            for (int i = start; i <= end; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write(i + " ");
                    foundPrime = true;
                }
            }

            if (!foundPrime)
            {
                Console.WriteLine("No prime numbers found in the given range.");
            }
        }

        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}