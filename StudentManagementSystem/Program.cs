using System;
using System.Collections.Generic;

namespace CSharpProjects.StudentManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create trainers
            var trainerA = new Trainer("Dr. Leparie", "leparie@tvet.com", "SoftwareDev");
            var trainerB = new Trainer("Ms. Kim", "kim@tvet.com", "FashionDesign");

            // Use inherited Greet() and own method
            trainerA.Greet();
            trainerA.ShowTrainerDetails();

            trainerB.Greet();
            trainerB.ShowTrainerDetails();

            Console.WriteLine();

            // Create courses with assigned trainers
            Course sdev101 = new Course("Object Oriented Programming", "SDEV101", trainerA);
            Course fas202 = new Course("Dress Making", "FAS202", trainerB);

            sdev101.ShowCourseInfo();
            fas202.ShowCourseInfo();

            Console.WriteLine();

            // Create students
            Student student1 = new Student("Nass", "nass@college.com", "S1234");
            Student student2 = new Student("Brian", "brian@college.com", "S5678");
            Student student3 = new Student("Cindy", "cindy@college.com", "S9012");

            // Use inherited Greet() and own method
            student1.Greet();
            student1.ShowStudentDetails();

            student2.Greet();
            student2.ShowStudentDetails();

            student3.Greet();
            student3.ShowStudentDetails();

            Console.WriteLine();

            // Enroll students in courses
            var enrollments = new List<Enrollment>
            {
                new Enrollment(student1, sdev101),
                new Enrollment(student2, sdev101),
                new Enrollment(student3, fas202),
                new Enrollment(student1, fas202),
            };

            // Loop through enrollments and print who is in which course
            Console.WriteLine("=== Enrollment List ===");
            foreach (var e in enrollments)
            {
                e.ShowEnrollment();
            }
        }
    }
}
