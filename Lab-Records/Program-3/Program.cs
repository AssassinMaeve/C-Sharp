using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q2
{
    using System;
    using System.Linq; // for ElementAt

    class NumberToWords
    {
        static string[] ones = { "Zero", "One", "Two", "Three", "Four", "Five",
                             "Six", "Seven", "Eight", "Nine", "Ten", "Eleven",
                             "Twelve", "Thirteen", "Fourteen", "Fifteen",
                             "Sixteen", "Seventeen", "Eighteen", "Nineteen" };

        static string[] tens = { "", "", "Twenty", "Thirty", "Forty", "Fifty",
                             "Sixty", "Seventy", "Eighty", "Ninety" };

        static string ConvertToWords(long number)
        {
            if (number < 20)
                return ones[number];
            else if (number < 100)
                return tens[number / 10] + ((number % 10 > 0) ? " " + ones[number % 10] : "");
            else if (number < 1000)
                return ones[number / 100] + " Hundred" + ((number % 100 > 0) ? " and " + ConvertToWords(number % 100) : "");
            else if (number < 1000000)
                return ConvertToWords(number / 1000) + " Thousand" + ((number % 1000 > 0) ? " " + ConvertToWords(number % 1000) : "");
            else if (number < 1000000000)
                return ConvertToWords(number / 1000000) + " Million" + ((number % 1000000 > 0) ? " " + ConvertToWords(number % 1000000) : "");
            else if (number < 1000000000000)
                return ConvertToWords(number / 1000000000) + " Billion" + ((number % 1000000000 > 0) ? " " + ConvertToWords(number % 1000000000) : "");
            else
                return "Number out of range!";
        }

        static void Main()
        {
            Console.Write("Enter a number (0 – 999,999,999,999): ");
            string input = Console.ReadLine();

            // Use string methods
            input = input.Trim(); // remove extra spaces
            Console.WriteLine("\nAfter Trim: " + input);
            Console.WriteLine("Number of digits (Length): " + input.Length);
            Console.WriteLine("First digit (using ElementAt): " + input.ElementAt(0));

            // Convert to long
            long num = long.Parse(input);

            // Convert to words and print
            Console.WriteLine("\nIn words: " + ConvertToWords(num));
        }
    }

}
