using System;
using System.IO;

namespace FileBasedCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "Counter.txt";

            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, "0");
            }

            int counter = int.Parse(File.ReadAllText(filePath));

            while (true)
            {
                Console.WriteLine($"\nCurrent Counter Value: {counter}");
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Increment");
                Console.WriteLine("2. Decrement");
                Console.WriteLine("3. Reset");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        counter++;
                        Console.WriteLine("Counter incremented.");
                        break;
                    case "2":
                        counter--;
                        Console.WriteLine("Counter decremented.");
                        break;
                    case "3":
                        counter = 0;
                        Console.WriteLine("Counter reset.");
                        break;
                    case "4":
                        File.WriteAllText(filePath, counter.ToString());
                        Console.WriteLine("Exiting... Counter value saved.");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        continue;
                }

                File.WriteAllText(filePath, counter.ToString());
            }
        }
    }
}
