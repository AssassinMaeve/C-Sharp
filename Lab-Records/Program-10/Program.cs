/* 
 
 Write a C# program to demonstrate the concept of Exception Handling and user defined exception
 
*/

using System;

// 1. User-Defined Exception Class
// It's good practice to create custom exceptions by inheriting from the base 'Exception' class.
// This allows you to create specific error types for your application's logic.
public class InvalidAgeException : Exception
{
    // We create a constructor that takes a message and passes it to the base Exception class.
    public InvalidAgeException(string message) : base(message)
    {
    }
}

// A simple class to demonstrate the logic
public class AgeValidator
{
    // This method validates the age. If the age is invalid, it 'throws' our custom exception.
    public static void Validate(int age)
    {
        if (age < 0 || age > 120)
        {
            // Throwing a new instance of our custom exception.
            throw new InvalidAgeException("Age is invalid. It must be between 0 and 120.");
        }
        Console.WriteLine("Age is valid and has been accepted.");
    }
}


public class Program
{
    public static void Main(string[] args)
    {
        // 2. Exception Handling with try-catch-finally
        try
        {
            // The 'try' block contains code that might throw an exception.
            Console.WriteLine("--- Demonstrating Exception Handling ---");
            Console.Write("Please enter your age: ");
            string input = Console.ReadLine();

            // This line can throw a FormatException if the input is not a number.
            int age = int.Parse(input);

            // This line can throw our custom InvalidAgeException.
            AgeValidator.Validate(age);
        }
        catch (InvalidAgeException ex)
        {
            // This 'catch' block specifically handles our custom exception.
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (FormatException)
        {
            // This 'catch' block handles the case where the user enters non-numeric text.
            Console.WriteLine("Error: Invalid input. Please enter a valid number for age.");
        }
        catch (Exception ex)
        {
            // This is a general 'catch' block to handle any other unexpected exceptions.
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
        finally
        {
            // The 'finally' block contains code that will ALWAYS execute,
            // whether an exception was thrown or not. It's often used for cleanup.
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("This is the 'finally' block. Program execution finished.");
        }

        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey();
    }
}