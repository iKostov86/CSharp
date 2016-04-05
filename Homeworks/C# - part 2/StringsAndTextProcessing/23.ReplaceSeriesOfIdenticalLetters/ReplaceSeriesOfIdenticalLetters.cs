using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

public class ReplaceSeriesOfIdenticalLetters
{
    internal static void Main()
    {
        string input = "aaaabbbcddddddeeffffffff               gggggfffhhhhh hhhhhf";

        Console.WriteLine(input);

        // v.1
        //var symbol = input[0];
        //StringBuilder sb = new StringBuilder(input);

        //for (int i = 1; i < sb.Length; i++)
        //{
        //    if (sb[i] == symbol)
        //    {
        //        sb.Remove(i, 1);
        //        i--;
        //    }
        //    else
        //    {
        //        symbol = sb[i];
        //    }
        //}

        //Console.WriteLine(sb.ToString());

        // v.2
        //string regex = @"(?<symbol>.|\s)\1+";
        string regex = @"(.|\s)\1+";
        //var output = Regex.Replace(input, regex, m => m.Groups["symbol"].Value, RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace);
        var output = Regex.Replace(input, regex, m => m.Groups[1].Value);

        Console.WriteLine(output);
    }
}
