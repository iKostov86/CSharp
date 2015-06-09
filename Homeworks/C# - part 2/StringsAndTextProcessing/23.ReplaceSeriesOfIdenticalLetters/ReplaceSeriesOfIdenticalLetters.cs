using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class ReplaceSeriesOfIdenticalLetters
{
    static void Main()
    {
        string input = "aaaabbbcddddddeeffffffff gggggfffhhhhh";
        //HashSet<char> mySet = new HashSet<char>();

        //for (int i = 0; i < input.Length; i++)
        //{
        //    if (char.IsLetter(input[i]))
        //    {
        //        mySet.Add(input[i]);
        //    }
        //}

        //foreach (char letter in mySet)
        //{
        //    Console.Write(letter);
        //}

        string regex = @"(?<letter>[A-Z])\1+";

        var output = Regex.Replace(input, regex, m => m.Groups["letter"].Value, RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace);

        Console.WriteLine(output);

        Console.WriteLine();
    }
}
