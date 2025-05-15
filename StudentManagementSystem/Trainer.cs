
namespace CSharpProjects.StudentManagementSystem
{
    public class Trainer : Person
    {
        // Department the trainer belongs to
        public string Department { get; set; }

        // Constructor: initializes Name, Email (via base) and Department
        public Trainer(string name, string email, string department)
            : base(name, email)
        {
            Department = department;
        }

        // Display trainer-specific details
        public void ShowTrainerDetails()
        {
            Console.WriteLine($"Trainer: {Name} | Email: {Email} | Department: {Department}");
        }
    }
}
