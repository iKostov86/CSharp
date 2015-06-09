using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class StringWithMaxLength20
{
    static void Main()
    {
        string input = null;

        do
        {
            Console.WriteLine("Please enter a string, max length is 20 characters: ");
            input = Console.ReadLine();

        } while (input.Length > 20);

        //v.1

        StringBuilder myBuilder = new StringBuilder(input);

        while (myBuilder.Length < 20)
        {
            myBuilder.Append("*");
        }

        Console.WriteLine(myBuilder);

        //v.2

        //Console.WriteLine(input.PadRight(20, '*'));
    }
}
