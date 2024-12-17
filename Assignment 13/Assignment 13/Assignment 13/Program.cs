using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParallelStudentProcessing
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Grade { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student { Id = 1, Name = "Alice", Grade = 85 },
                new Student { Id = 2, Name = "Bob", Grade = 72 },
                new Student { Id = 3, Name = "Charlie", Grade = 90 },
                new Student { Id = 4, Name = "David", Grade = 60 },
                new Student { Id = 5, Name = "Eve", Grade = 35 },
                new Student { Id = 6, Name = "Frank", Grade = 40 },
                new Student { Id = 7, Name = "Grace", Grade = 75 },
                new Student { Id = 8, Name = "Hannah", Grade = 88 },
                new Student { Id = 9, Name = "Ian", Grade = 20 },
                new Student { Id = 10, Name = "Jack", Grade = 50 }
            };

            double averageGrade = 0;
            Task calculateAverage = Task.Run(() =>
            {
                averageGrade = students.Average(s => s.Grade);
                Console.WriteLine($"Average Grade: {averageGrade:F2}");
            });

            calculateAverage.Wait();

            Task displayAboveAverage = Task.Run(() =>
            {
                var aboveAverageStudents = students.Where(s => s.Grade > averageGrade).ToList();
                Console.WriteLine("\nStudents scoring above the average:");
                foreach (var student in aboveAverageStudents)
                {
                    Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Grade: {student.Grade}");
                }
            });

            Task countFailures = Task.Run(() =>
            {
                int failedCount = students.Count(s => s.Grade < 40);
                Console.WriteLine($"\nNumber of students who failed: {failedCount}");
            });

            Task.WaitAll(displayAboveAverage, countFailures);

            Console.WriteLine("\nProcessing complete.");
        }
    }
}
