using System;
using System.Collections.Generic;

namespace StudentRegistry
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Students:");
            List<Student> students = new List<Student>() {
               new Student("John", "Doe", "R"),
               new Student("Nathan", "Vontz", "W"),
               new Student("Jake", "Run", "S")
            };

            var cis501 = new Course()
            {
                CreditHours = 3,
                Name = "CIS 501",
                Number = 13798676,
            };

            var cis308 = new Course()
            {
                CreditHours = 1,
                Name = "CIS 308",
                Number = 8979643,
            };

            var cis400 = new Course()
            {
                CreditHours = 3,
                Name = "CIS 400",
                Number = 12321456,
            };

            var m = new Student("Minnie", "Jantz", "F");
            m.EnrollInCourse(cis400);
            m.EnrollInCourse(cis308);
            m.EnrollInCourse(cis501);

            m.CompleteCourse(cis308, Grade.B);
            m.CompleteCourse(cis400, Grade.A);
            m.DropCourse(cis501);

            students.Add(m);

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

        }
    }
}
