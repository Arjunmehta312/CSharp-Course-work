using System;

namespace StudentGradingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueEntering = true;

            while (continueEntering)
            {
                int marks;

                // Input marks with validation
                while (true)
                {
                    Console.Write("Enter marks (0-100): ");
                    if (int.TryParse(Console.ReadLine(), out marks) && marks >= 0 && marks <= 100)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter marks between 0 and 100.");
                    }
                }

                // Determine grade using if-else
                string grade;
                if (marks >= 90)
                    grade = "A";
                else if (marks >= 80)
                    grade = "B";
                else if (marks >= 70)
                    grade = "C";
                else if (marks >= 60)
                    grade = "D";
                else
                    grade = "Fail";

                // Provide remarks using switch
                string remarks;
                switch (grade)
                {
                    case "A":
                        remarks = "Excellent";
                        break;
                    case "B":
                        remarks = "Very Good";
                        break;
                    case "C":
                        remarks = "Good";
                        break;
                    case "D":
                        remarks = "Needs Improvement";
                        break;
                    default:
                        remarks = "Better Luck Next Time";
                        break;
                }

                // Display the grade and remarks
                Console.WriteLine($"Grade: {grade}");
                Console.WriteLine($"Remarks: {remarks}");

                // Ask if the user wants to input marks for another student
                Console.Write("Do you want to enter marks for another student? (Yes/No): ");
                string response = Console.ReadLine()?.Trim().ToLower();
                if (response != "yes")
                {
                    continueEntering = false;
                }
            }

            Console.WriteLine("Goodbye!");
        }
    }
}
