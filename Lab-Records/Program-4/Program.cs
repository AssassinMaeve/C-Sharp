/*
 
Write a C# console application to perform the following
- Takes an Input String, appends a digit after every character with total count of that
 character (case is ignored) in the string.
- Removes all characters from the second string which is there in the first string

 */

using System;

class Program
{
    static void Main()
    {
        // Task 1: Append count after each character
        Console.Write("Enter the first string: ");
        string str1 = Console.ReadLine();

        string lowerStr1 = str1.ToLower(); // for case-insensitive counting
        string result1 = "";

        for (int i = 0; i < str1.Length; i++)
        {
            char ch = str1[i];
            int count = 0;

            // Count occurrences (case-insensitive)
            for (int j = 0; j < str1.Length; j++)
            {
                if (char.ToLower(str1[j]) == char.ToLower(ch))
                {
                    count++;
                }
            }

            result1 += ch.ToString() + count.ToString();
        }

        Console.WriteLine("\nString after appending counts:");
        Console.WriteLine(result1);

        // Task 2: Remove characters from second string
        Console.Write("\nEnter the second string: ");
        string str2 = Console.ReadLine();
        string result2 = "";

        for (int i = 0; i < str2.Length; i++)
        {
            char ch = str2[i];
            bool found = false;

            // Check if this character exists in first string (case-insensitive)
            for (int j = 0; j < str1.Length; j++)
            {
                if (char.ToLower(ch) == char.ToLower(str1[j]))
                {
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                result2 += ch;
            }
        }

        Console.WriteLine("\nSecond string after removing characters from first string:");
        Console.WriteLine(result2);
    }
}
