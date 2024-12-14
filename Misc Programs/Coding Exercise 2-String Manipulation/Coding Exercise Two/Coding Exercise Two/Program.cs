using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public static void Main(string[] args)
        {
            // Initialize variables
            int employeeId = 20;
            string companyName = "UTCLI";

            // String Concatenation
            Console.WriteLine("String Concatenation");
            Console.WriteLine("Hello, my employee ID is " + employeeId + " and my company name is " + companyName);

            // String Composite Formatting
            Console.WriteLine("String Composite Formatting");
            Console.WriteLine("Hello, my employee ID is {0} and my company name is {1}", employeeId, companyName);

            // String Interpolation
            Console.WriteLine("String Interpolation");
            Console.WriteLine($"Hello, my employee ID is {employeeId} and my company name is {companyName}");
        }
    }
}
