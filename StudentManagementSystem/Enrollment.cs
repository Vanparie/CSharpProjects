using System;

namespace CSharpProjects.StudentManagementSystem
{
    public class Enrollment
    {
        
        public Student EnrolledStudent { get; set; }
        public Course SelectedCourse { get; set; }

        // assign student and course during creation
        public Enrollment(Student enrolledStudent, Course selectedCourse)
        {
            EnrolledStudent = enrolledStudent;
            SelectedCourse = selectedCourse;
        }

        // Displays enrollment summary
        public void ShowEnrollment()
        {
            Console.WriteLine($"{EnrolledStudent.Name} is enrolled in {SelectedCourse.CourseName}");
        }
    }
}
