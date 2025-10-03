/* 
 
Program to Demonstrate the concept of Polymorphism via Method Overloading (Function
overloading/Static polymorphism/early binding).
 
 */

using System;

// 1. Base Class (Parent Class)
public class Student
{
    // Member Variables (Fields)
    public string Name;
    public int StudentID;
    public int Age;

    // --- Constructor for the Student class ---
    public Student(string name, int studentID, int age)
    {
        Console.WriteLine("Student constructor (with all params) called.");
        this.Name = name;
        this.StudentID = studentID;
        this.Age = age;
    }

    // Default constructor for demonstrating overloading
    public Student()
    {
        Console.WriteLine("Student default constructor called.");
        this.Name = "Not Set";
        this.StudentID = 0;
        this.Age = 0;
    }


    // --- Method Overloading (Static Polymorphism) ---
    // These methods have the same name 'SetDetails' but different parameters.
    // The compiler decides which one to call based on the arguments provided.

    public void SetDetails(string name)
    {
        Console.WriteLine("\nCalling SetDetails with just name...");
        this.Name = name;
    }

    public void SetDetails(string name, int studentID)
    {
        Console.WriteLine("\nCalling SetDetails with name and Student ID...");
        this.Name = name;
        this.StudentID = studentID;
    }

    public void SetDetails(string name, int studentID, int age)
    {
        Console.WriteLine("\nCalling SetDetails with name, Student ID, and age...");
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

// 2. Derived Class (Child Class) - Unchanged for this example
public class GraduateStudent : Student
{
    public string ResearchTopic;

    public GraduateStudent(string name, int studentID, int age, string researchTopic)
        : base(name, studentID, age)
    {
        Console.WriteLine("GraduateStudent constructor called.");
        this.ResearchTopic = researchTopic;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Research Topic: {ResearchTopic}");
        Console.WriteLine("-----------------------");
    }
}


// Main program class to run the code
public class Program
{
    public static void Main(string[] args)
    {
        // 3. Demonstrating Method Overloading
        Console.WriteLine("--- Demonstrating Method Overloading ---");
        Student studentForOverloading = new Student();
        studentForOverloading.DisplayDetails(); // Shows initial default values

        // Call the first version of SetDetails
        studentForOverloading.SetDetails("Charlie");
        studentForOverloading.DisplayDetails();

        // Call the second version of SetDetails
        studentForOverloading.SetDetails("David", 103);
        studentForOverloading.DisplayDetails();

        // Call the third version of SetDetails
        studentForOverloading.SetDetails("Eve", 104, 21);
        studentForOverloading.DisplayDetails();

        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey();
    }
}