using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class SubstringCount
{
    static void Main()
    {
        string input = @"We are living in an yellow submarine.
                        We don't have anything else. 
                        Inside the submarine is very tight. 
                        So we are drinking all the day. 
                        We will move out of it in 5 days.";

        //v.1

        //int count = input.ToLower().Split(new[] { "in" }, StringSplitOptions.RemoveEmptyEntries).Length - 1;

        //Console.WriteLine(count);

        //v.2

        //int index = 0;
        //int count2 = 0;

        //do
        //{
        //    index = input.ToLower().IndexOf("in", index) + 1;
        //    count2++;

        //} while (index != 0);

        //Console.WriteLine(count2 - 1);

        //v.3

        //string substring = "in";
        //int count3 = 0;

        //for (int i = 0; i < input.Length - substring.Length; i++)
        //{
        //    if (input.Substring(i, substring.Length).ToLower() == substring)
        //    {
        //        count3++;
        //    }
        //}

        //Console.WriteLine(count3);

        //v.4

        int count4 = Regex.Matches(input, "(?i)in", RegexOptions.IgnoreCase).Count;
        Console.WriteLine(count4);

        //v.5

        int count5 = input.Select((c, i) => input.ToLower().Substring(i)).Count(sub => sub.StartsWith("in"));
        Console.WriteLine(count5);
    }
}
