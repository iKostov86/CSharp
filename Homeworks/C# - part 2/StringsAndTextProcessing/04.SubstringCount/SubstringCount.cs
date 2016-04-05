using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

public class SubstringCount
{
    internal static void Main()
    {
        string input = @"We are living in an yellow submarine.
                        We don't have anything else. 
                        Inside the submarine is very tight. 
                        So we are drinking all the day. 
                        We will move out of it in 5 days.";
        string word = "in";

        // v.1
        //int count1 = input.ToLower().Split(new[] { word }, StringSplitOptions.RemoveEmptyEntries).Length - 1;

        //Console.WriteLine(count1);

        // v.2
        //int index = 0;
        //int count2 = 0;

        //do
        //{
        //    index = input.ToLower().IndexOf(word, index) + 1;
        //    count2++;

        //} while (index != 0);

        //Console.WriteLine(count2 - 1);

        // v.3
        //int count3 = 0;
        //int inputLen = input.Length;
        //int wordLen = word.Length;

        //for (int i = 0, len = inputLen - wordLen; i < len; i++)
        //{
        //    if (input.Substring(i, wordLen).ToLower() == word)
        //    {
        //        count3++;
        //    }
        //}

        //Console.WriteLine(count3);

        //v.4
        MatchCollection matches = Regex.Matches(input, "(?i)in", RegexOptions.IgnoreCase); // (?i) -> case-insensitive (by default), (?-i) -> case-sensitive
        int count4 = matches.Count;

        Console.WriteLine(count4);

        //v.5
        int count5 = input.Select((ch, i) => input.ToLower().Substring(i)).Count(sub => sub.StartsWith(word));

        Console.WriteLine(count5);
    }
}
