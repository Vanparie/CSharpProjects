# Student Management System – C# Console App

This is a simple Object-Oriented Programming (OOP) project written in C# that models a basic student management system for learning purposes.

##  Technologies Used

- C# (.NET 6)
- Visual Studio 2022 / VS Code
- Console application
- Git for version control


## OOP Concepts Applied

| Concept         | Implementation                                                   |
|----------------|-------------------------------------------------------------------|
| **Encapsulation** | Properties with getters/setters ('StudentId', 'Email', etc.)         |
| **Abstraction**   | Classes expose essential methods ('Greet()', 'ShowDetails()')       |
| **Inheritance**   | 'Student' and 'Trainer' inherit from 'Person'                      |
| **Polymorphism**  | Inherited methods like 'Greet()' work for both 'Student' and 'Trainer' |
| **Composition**   | A 'Course' contains a 'Trainer'; 'Enrollment' links 'Student' and 'Course' |



## Features Implemented

- Create students and trainers
- Assign trainers to courses
- Enroll students in courses
- Display course info
- Display student enrollments
- Print detailed summaries using methods like 'Greet()' and 'ShowStudentDetails()'



## Project Structure

CSharpProjects/
|
StudentManagementSystem/
│
├── Person.cs // Base class for all people
├── Student.cs // Inherits from Person
├── Trainer.cs // Inherits from Person
├── Course.cs // Uses Trainer 
├── Enrollment.cs // Connects Student and Course
└── Program.cs // Main entry point – puts it all together




##  How to Run

1. Open the project in Visual Studio or VS Code.
2. Make sure you're targeting .NET 6.0 or higher.
3. Run 'Program.cs'.
4. View the output in the terminal.


## Author

Davidson Leparie 
- Backend developer; Passionate about problem-solving through code  
- Samburu North Technical and Vocational College


## Future Improvements

- Add user input for dynamic enrollments
- Save and load data using files or database
- Build a web version using ASP.NET MVC


CHEERS!
