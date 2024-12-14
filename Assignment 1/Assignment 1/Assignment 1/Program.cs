using System;

namespace TextFormatter
{
    public class SimpleTextFormatter
    {
        public static void Main(string[] args)
        {
            // Prompt the user for input
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            // Check for empty input
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("You entered an empty string. Please try again.");
                return;
            }

            // Display the original string
            Console.WriteLine($"Original String: {input}");

            // Convert to uppercase
            string uppercase = input.ToUpper();
            Console.WriteLine($"Uppercase: {uppercase}");

            // Reverse the string
            string reversed = ReverseString(input);
            Console.WriteLine($"Reversed: {reversed}");

            // Replace spaces with underscores
            string spacesReplaced = input.Replace(" ", "_");
            Console.WriteLine($"Spaces Replaced: {spacesReplaced}");

            // Extra feature: Count the number of characters and words
            Console.WriteLine($"Character Count: {input.Length}");
            Console.WriteLine($"Word Count: {input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length}");
        }

        // Method to reverse a string
        private static string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
