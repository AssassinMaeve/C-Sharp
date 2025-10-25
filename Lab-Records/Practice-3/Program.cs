using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 
Write a C# console application for Conversion of a Number to its Corresponding String.(create
string array, and use string methods: trim, length, element at)
 
 */

namespace Practice_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] numberWords = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };

            Console.Write("Enter a number (0-9): ");
            string input = Console.ReadLine();

            input = input.Trim();
            if(input.Length == 1 && char.IsDigit(input[0]))
            {
                int num = int.Parse(input);
                string word = numberWords[num];
            }
        }
    }
}
