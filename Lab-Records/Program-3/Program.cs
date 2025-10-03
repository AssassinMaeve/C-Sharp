/* 
 
Write a C# console application for Conversion of a Number to its Corresponding String.(create
string array, and use string methods: trim, length, element at)
 
 */

using System;

class Program
{
    static void Main()
    {
        // String array for numbers 0–9
        string[] numberWords = { "Zero", "One", "Two", "Three", "Four",
                                 "Five", "Six", "Seven", "Eight", "Nine" };

        Console.Write("Enter a number (0-9): ");
        string input = Console.ReadLine();

        // Trim to remove extra spaces
        input = input.Trim();

        if (input.Length == 1 && char.IsDigit(input[0]))
        {
            int num = int.Parse(input);
            string word = numberWords[num];

            Console.WriteLine("Number: {0}", num);
            Console.WriteLine("In words: {0}", word);
            Console.WriteLine("Word Length: {0}", word.Length);
            Console.WriteLine("First Letter: {0}", word[0]);
        }
        else
        {
            Console.WriteLine("Invalid input! Please enter a single digit (0-9).");
        }
    }
}
