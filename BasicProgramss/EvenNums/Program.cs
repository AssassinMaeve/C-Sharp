using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenNums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num == 0)
            {
                Console.WriteLine("0 is neither even nor odd");
            }
            else if (num < 0)
            {
                Console.WriteLine("Negative numbers are not considered for even or odd");
            }
            else if (num % 2 == 0)
            {
                Console.WriteLine($"{num} is an even number");
            }
            else
            {
                Console.WriteLine($"{num} is an odd number");
                {
                }

            }
            Console.ReadLine(); // Keeps the console window open until a key is pressed
        }
    }
}
