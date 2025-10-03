/*
 
Write a C# program to show class and object creation(student class)

 */

using System;

// 1. Class Definition
// This is the blueprint for creating Student objects.
public class Student
{
    // Member Variables (Fields) - These store the data for each student.
    public string Name;
    public int StudentID;
    public int Age;

    // Member Method - This defines an action the object can perform.
    public void DisplayDetails()
    {
        Console.WriteLine("--- Student Details ---");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Student ID: {StudentID}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine("-----------------------");
    }
}

// Main program class to run the code
public class Program
{
    // The Main method is the entry point of the application.
    public static void Main(string[] args)
    {
        // 2. Object Creation (Instantiation)
        // We are creating an instance of the Student class called 'student1'.
        // 'student1' is an object.
        Student student1 = new Student();

        // 3. Assigning values to the object's properties
        student1.Name = "Alice";
        student1.StudentID = 101;
        student1.Age = 20;

        // 4. Calling the object's method
        // The student1 object now has its own data and can perform actions.
        student1.DisplayDetails();

        // Let's create another object to show they are independent
        Student student2 = new Student();
        student2.Name = "Bob";
        student2.StudentID = 102;
        student2.Age = 22;

        student2.DisplayDetails();

        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey();
    }
}
