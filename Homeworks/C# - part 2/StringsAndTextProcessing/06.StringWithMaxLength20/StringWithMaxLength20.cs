using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

public class StringWithMaxLength20
{
    internal static void Main()
    {
        string input = Console.ReadLine();
        int maxLen = 20;

        //do
        //{
        //    Console.WriteLine("Please enter a string, max length is 20 characters: ");
        //    input = Console.ReadLine();

        //} while (input.Length > 20);

        if (input.Length < maxLen)
        {
            input = input.PadRight(maxLen, '*');
        }
        else
        {
            input = input.Substring(0, maxLen);
        }

        Console.WriteLine(input);
    }
}
