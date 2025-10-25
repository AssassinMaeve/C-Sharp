using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

/* Write a C# console application to read a user input as either word or sentence and display each
   word in sorted order with length of each word.*/

namespace Practice_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word or sentence:");
            string input = Console.ReadLine();

            string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(words);

            foreach(int word in words)
            {
                Console.WriteLine("{0} ({1})", word, word.Length);
            }

        }
    }
}
