
namespace CSharpProjects.StudentManagementSystem
{
    public class Student : Person
    {
        public string StudentId { get; set; }

        // Student constructor calls the base class constructor using base(...)
        public Student(string name, string email, string studentId)
            : base(name, email)
        {
            StudentId = studentId;
        }

        public void ShowStudentDetails()
        {
            Console.WriteLine($"🎓 Student: {Name} | Email: {Email} | ID: {StudentId}");
        }
    }

}
