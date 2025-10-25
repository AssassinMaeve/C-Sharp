using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colindrom
{
    using System;

    class Program
    {
        static void Main()
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();

            bool isColindrome = true;

            for (int i = 0; i + 5 < str.Length; i += 6)
            {
                // Compare first 3 letters with reverse of next 3 letters
                for (int j = 0; j < 3; j++)
                {
                    if (str[i + j] != str[i + 5 - j])
                    {
                        isColindrome = false;
                        break;
                    }
                }
                if (!isColindrome) break;
            }

            if (isColindrome)
                Console.WriteLine("Entered string is a Colindrome.");
            else
                Console.WriteLine("Entered string is NOT a Colindrome.");

            Console.ReadLine();
        }
    }
}