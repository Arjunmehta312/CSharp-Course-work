using System;

class AreaCalculator
{
    // Method to calculate the area of a rectangle
    static double CalculateArea(double length, double breadth)
    {
        return length * breadth;
    }

    // Method to calculate the area of a circle
    static double CalculateArea(double radius)
    {
        return Math.PI * radius * radius;
    }

    // Method to calculate the area of a triangle
    static double CalculateArea(double baseLength, double height, bool isTriangle)
    {
        return 0.5 * baseLength * height;
    }

    static void Main(string[] args)
    {
        bool continueCalculation = true;

        while (continueCalculation)
        {
            Console.WriteLine("Choose a shape to calculate the area:");
            Console.WriteLine("1. Rectangle");
            Console.WriteLine("2. Circle");
            Console.WriteLine("3. Triangle");
            Console.Write("Enter your choice: ");
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3)
            {
                Console.Write("Invalid choice. Please enter 1, 2, or 3: ");
            }

            switch (choice)
            {
                case 1:
                    Console.Write("Enter the length of the rectangle: ");
                    double length = GetPositiveNumber();
                    Console.Write("Enter the breadth of the rectangle: ");
                    double breadth = GetPositiveNumber();
                    Console.WriteLine($"Area of the rectangle: {CalculateArea(length, breadth)}");
                    break;

                case 2:
                    Console.Write("Enter the radius of the circle: ");
                    double radius = GetPositiveNumber();
                    Console.WriteLine($"Area of the circle: {CalculateArea(radius):F2}");
                    break;

                case 3:
                    Console.Write("Enter the base of the triangle: ");
                    double baseLength = GetPositiveNumber();
                    Console.Write("Enter the height of the triangle: ");
                    double height = GetPositiveNumber();
                    Console.WriteLine($"Area of the triangle: {CalculateArea(baseLength, height, true)}");
                    break;
            }

            Console.Write("Do you want to calculate the area of another shape? (Yes/No): ");
            string response = Console.ReadLine()?.Trim().ToLower();
            continueCalculation = response == "yes";
        }

        Console.WriteLine("Goodbye!");
    }

    // Helper method to ensure positive number input
    static double GetPositiveNumber()
    {
        double number;
        while (!double.TryParse(Console.ReadLine(), out number) || number <= 0)
        {
            Console.Write("Invalid input. Please enter a positive number: ");
        }
        return number;
    }
}
