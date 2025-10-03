/*
  
Write a C# program to demonstrate the concept of Interface.
 
 */

using System;

// 1. Interface Definition
// An interface is a contract. It only contains method signatures, not implementations.
// Any class that "implements" this interface MUST provide its own code for these methods.
public interface IDrawable
{
    // An interface method does not have a body.
    void Draw();
}

// 2. Concrete Classes Implementing the Interface
// These classes promise to follow the contract defined by IDrawable.

// Circle class
public class Circle : IDrawable
{
    // This class provides its specific implementation for the Draw() method.
    public void Draw()
    {
        Console.WriteLine("Drawing a Circle: O");
    }
}

// Rectangle class
public class Rectangle : IDrawable
{
    // This class also provides its own implementation for Draw().
    public void Draw()
    {
        Console.WriteLine("Drawing a Rectangle: []");
    }
}


// Main program class to run the code
public class Program
{
    public static void Main(string[] args)
    {
        // 3. Demonstrating Polymorphism with Interfaces
        Console.WriteLine("--- Demonstrating Interfaces ---");

        // Create an 'IDrawable' reference. It can hold an object of any class that implements the interface.
        IDrawable myDrawable;

        // Point the 'IDrawable' reference to a new Circle object.
        myDrawable = new Circle();
        // This calls the Circle's implementation of the Draw method.
        myDrawable.Draw();

        // Now, point the same reference to a new Rectangle object.
        myDrawable = new Rectangle();
        // This calls the Rectangle's implementation of the Draw method.
        myDrawable.Draw();

        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey();
    }
}