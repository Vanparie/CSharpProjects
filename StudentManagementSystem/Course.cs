using System;

namespace CSharpProjects.StudentManagementSystem
{
    public class Course
    {
        // Properties describing what they hold
        public string CourseName { get; set; }
        public string CourseCode { get; set; }
        public Trainer AssignedTrainer { get; set; }

        // Constructor takes all 3 values and assigns them
        public Course(string courseName, string courseCode, Trainer assignedTrainer)
        {
            CourseName = courseName;
            CourseCode = courseCode;
            AssignedTrainer = assignedTrainer;
        }

        // Method to print course summary
        public void ShowCourseInfo()
        {
            Console.WriteLine($"Course: {CourseName} ({CourseCode}) – Trainer: {AssignedTrainer.Name}");
        }
    }
}

