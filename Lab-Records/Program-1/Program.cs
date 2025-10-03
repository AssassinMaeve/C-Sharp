//  Write a C# console application to ask the user for a symbol and answer if it is a (lowercase) vowel, a digit, or any other symbol.(using switch or if and use {0})

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a symbol: ");
        char symbol = Console.ReadKey().KeyChar; // reads single character
        Console.WriteLine(); // move to next line

        switch (symbol)
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                Console.WriteLine("The symbol {0} is a lowercase vowel.", symbol);
                break;

            case '0':
            case '1':
            case '2':
            case '3':
            case '4':
            case '5':
            case '6':
            case '7':
            case '8':
            case '9':
                Console.WriteLine("The symbol {0} is a digit.", symbol);
                break;

            default:
                Console.WriteLine("The symbol {0} is any other symbol.", symbol);
                break;
        }
    }
}
