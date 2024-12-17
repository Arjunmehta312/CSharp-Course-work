using System;
using System.Collections.Generic;
using System.Linq;

namespace CRUDWithEntityFramework
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Grade { get; set; }
    }

    public class AppDbContext
    {
        public List<Student> Students { get; set; } = new List<Student>();
    }

    class Program
    {
        static void Main(string[] args)
        {
            var context = new AppDbContext();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nChoose an operation:");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. View All Students");
                Console.WriteLine("3. Update Student");
                Console.WriteLine("4. Delete Student");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddStudent(context);
                        break;
                    case "2":
                        ViewStudents(context);
                        break;
                    case "3":
                        UpdateStudent(context);
                        break;
                    case "4":
                        DeleteStudent(context);
                        break;
                    case "5":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        private static void AddStudent(AppDbContext context)
        {
            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter Grade: ");
            string grade = Console.ReadLine();

            var student = new Student { Id = context.Students.Count + 1, Name = name, Age = age, Grade = grade };
            context.Students.Add(student);
            Console.WriteLine("Student added successfully!");
        }

        private static void ViewStudents(AppDbContext context)
        {
            var students = context.Students;
            Console.WriteLine("\nAll Students:");
            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}, Grade: {student.Grade}");
            }
        }

        private static void UpdateStudent(AppDbContext context)
        {
            Console.Write("Enter Student ID to Update: ");
            int id = int.Parse(Console.ReadLine());
            var student = context.Students.FirstOrDefault(s => s.Id == id);

            if (student != null)
            {
                Console.Write("Enter New Name: ");
                student.Name = Console.ReadLine();
                Console.Write("Enter New Age: ");
                student.Age = int.Parse(Console.ReadLine());
                Console.Write("Enter New Grade: ");
                student.Grade = Console.ReadLine();
                Console.WriteLine("Student updated successfully!");
            }
            else
            {
                Console.WriteLine("Student not found!");
            }
        }

        private static void DeleteStudent(AppDbContext context)
        {
            Console.Write("Enter Student ID to Delete: ");
            int id = int.Parse(Console.ReadLine());
            var student = context.Students.FirstOrDefault(s => s.Id == id);

            if (student != null)
            {
                context.Students.Remove(student);
                Console.WriteLine("Student deleted successfully!");
            }
            else
            {
                Console.WriteLine("Student not found!");
            }
        }
    }
}