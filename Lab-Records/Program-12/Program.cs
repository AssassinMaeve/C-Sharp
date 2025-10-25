using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flames
{
    using System;

    class Program
    {
        static void Main()
        {
            Console.Write("Enter your name: ");
            string name1 = Console.ReadLine().ToLower().Replace(" ", "");

            Console.Write("Enter partner's name: ");
            string name2 = Console.ReadLine().ToLower().Replace(" ", "");

            foreach (char c in name1)
            {
                if (name2.Contains(c))
                {
                    name1 = name1.Replace(c.ToString(), "");
                    name2 = name2.Replace(c.ToString(), "");
                }
            }

            int count = name1.Length + name2.Length;
            string flames = "FLAMES";

            while (flames.Length > 1)
            {
                int index = (count % flames.Length) - 1;
                if (index >= 0)
                    flames = flames.Substring(index + 1) + flames.Substring(0, index);
                else
                    flames = flames.Substring(0, flames.Length - 1);
            }

            Console.WriteLine("Relationship is: " + (flames == "F" ? "Friend" :
                                                      flames == "L" ? "Love" :
                                                      flames == "A" ? "Affection" :
                                                      flames == "M" ? "Marriage" :
                                                      flames == "E" ? "Enemy" : "Sibling"));
        }
    }
}
