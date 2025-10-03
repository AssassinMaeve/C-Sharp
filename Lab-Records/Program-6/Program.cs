/* 
 
Write a C# program to demonstrate the concept of Inheritance and constructor.
 
*/

using System;

// 1. Base Class (Parent Class)
// This is the blueprint for creating Student objects.
public class Student
{
    // Member Variables (Fields)
    public string Name;
    public int StudentID;
    public int Age;

    // --- Constructor for the Student class ---
    // A constructor is a special method that is called when an object is created.
    // It's used to initialize the object's data members.
    public Student(string name, int studentID, int age)
    {
        Console.WriteLine("Student constructor called.");
        this.Name = name;
        this.StudentID = studentID;
        this.Age = age;
    }

    // Member Method - Marked as 'virtual' so it can be overridden by derived classes.
    public virtual void DisplayDetails()
    {
        Console.WriteLine("--- Student Details ---");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Student ID: {StudentID}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine("-----------------------");
    }
}

// 2. Derived Class (Child Class)
// GraduateStudent inherits from the Student class.
// This means a GraduateStudent "is a" Student and gets all its public members.
public class GraduateStudent : Student
{
    // This is a member specific to the GraduateStudent class.
    public string ResearchTopic;

    // --- Constructor for the GraduateStudent class ---
    // It takes parameters for the base class and its own members.
    // The ': base(name, studentID, age)' part calls the constructor of the base class (Student).
    public GraduateStudent(string name, int studentID, int age, string researchTopic)
        : base(name, studentID, age)
    {
        Console.WriteLine("GraduateStudent constructor called.");
        // Initialize its own member
        this.ResearchTopic = researchTopic;
    }

    // --- Method Overriding ---
    // This provides a specific implementation of DisplayDetails for GraduateStudent.
    public override void DisplayDetails()
    {
        // Call the base class method first to display common details
        base.DisplayDetails();
        // Then display the details specific to the GraduateStudent
        Console.WriteLine($"Research Topic: {ResearchTopic}");
        Console.WriteLine("-----------------------");
    }
}


// Main program class to run the code
public class Program
{
    // The Main method is the entry point of the application.
    public static void Main(string[] args)
    {
        // 3. Object Creation using Constructors
        Console.WriteLine("Creating a regular Student object:");
        // This calls the Student constructor
        Student student1 = new Student("Alice", 101, 20);
        student1.DisplayDetails();

        Console.WriteLine("\nCreating a Graduate Student object:");
        // This calls the Student constructor first, then the GraduateStudent constructor
        GraduateStudent gradStudent1 = new GraduateStudent("Bob", 102, 25, "Artificial Intelligence");
        gradStudent1.DisplayDetails();

        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey();
    }
}

