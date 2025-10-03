/* 
 
Write a C# program to demonstrate the concept of Polymorphism via Method Overriding/
Dynamic method dispatch [run time polymorphism (shape class)] and Abstract class.
 
 */

using System;

// 1. Abstract Base Class
// An abstract class cannot be created directly. It acts as a blueprint for other classes.
public abstract class Shape
{
    // An abstract method has no implementation. 
    // It forces any child class to provide its own version of this method.
    public abstract void Draw();
}

// 2. Concrete Derived Classes
// These classes inherit from Shape and provide the required implementation for the Draw method.

// Circle class
public class Circle : Shape
{
    // Here we provide the specific implementation for Draw() for a Circle.
    public override void Draw()
    {
        Console.WriteLine("Drawing a Circle: O");
    }
}

// Rectangle class
public class Rectangle : Shape
{
    // Here we provide the specific implementation for Draw() for a Rectangle.
    public override void Draw()
    {
        Console.WriteLine("Drawing a Rectangle: []");
    }
}


// Main program class to run the code
public class Program
{
    public static void Main(string[] args)
    {
        // 3. Demonstrating Runtime Polymorphism
        Console.WriteLine("--- Demonstrating Runtime Polymorphism ---");

        // Create a 'Shape' reference. It can hold an object of any class that inherits from Shape.
        Shape myShape;

        // Point the 'Shape' reference to a new Circle object.
        myShape = new Circle();
        // The program decides at runtime to call the Circle's version of Draw().
        myShape.Draw();

        // Now, point the same 'Shape' reference to a new Rectangle object.
        myShape = new Rectangle();
        // The program now decides at runtime to call the Rectangle's version of Draw().
        myShape.Draw();

        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey();
    }
}