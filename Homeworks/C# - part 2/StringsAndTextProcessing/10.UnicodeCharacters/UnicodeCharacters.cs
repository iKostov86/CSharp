using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class UnicodeCharacters
{
    static void Main()
    {
        string input = "Hi!";

        //v.1

        StringBuilder myBuilder = new StringBuilder();

        foreach (char ch in input)
        {
            myBuilder.AppendFormat("{0}{1:x4}", "\\u", (int)ch);
        }

        Console.WriteLine(myBuilder);

        //v.2

        string output = input.Aggregate(string.Empty, (current, t) => current + string.Format(@"\n{0:X4}", (int)t));

        Console.WriteLine(output);

        //\u0048\u0069\u0021

    }
}
