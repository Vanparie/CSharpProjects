using System;

namespace CSharpProjects.StudentManagementSystem
{
    // Define the Person base class
    public class Person
    {
        // Encapsulated properties with getters/setters
        public string Name { get; set; }
        public string Email { get; set; }

        // Constructor to initialize person
        public Person(string name, string email)
        {
            Name = name;
            Email = email;
        }

        // Greet method for every person
        public void Greet()
        {
            Console.WriteLine($"Hello, my name is {Name}.");
        }
    }

}