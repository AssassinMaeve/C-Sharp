/* Write a C# console application to read a user input as either word or sentence and display each
   word in sorted order with length of each word.*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a word or sentence: ");
        string input = Console.ReadLine();

        // Split words by spaces (works in older versions too)
        string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        // Sort words alphabetically
        Array.Sort(words);

        Console.WriteLine("\nWords in sorted order with their lengths:");
        foreach (string word in words)
        {
            Console.WriteLine("{0} ({1})", word, word.Length);
        }
    }
}
