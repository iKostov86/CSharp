using System;
using System.Linq;
using System.Text.RegularExpressions;

public class UppercaseTaggedRegions
{
    internal static void Main()
    {
        string input = "We are living in a <upcase>yellow"
                     + " submarine</upcase>. We don't have"
                     + " <upcase>anything</upcase> else.";
        // v.1
        //var output1 = input
        //                .Split(new[] { "<upcase>", "</upcase>" }, StringSplitOptions.RemoveEmptyEntries)
        //                .Select((str, i) => (i % 2) != 0 ? str.ToUpper() : str)
        //                .ToArray();

        //PrintArr(output);

        // v.2
        //string regex = @"<upcase>(?<groupName>(.|\s)*?)</upcase>";

        //Console.WriteLine(Regex.Replace(input, regex, word => word.Groups["groupName"].Value.ToUpper()));

        // v.3
        //var output3 = Regex.Replace(input, @"<upcase>(.*?)</upcase>", delegate (Match match)
        //{
        //    string current = match.ToString().ToUpper();
        //    Console.WriteLine(current);

        //    return Regex.Replace(current, @"<[^>]*>", String.Empty);
        //});

        //Console.WriteLine(output3);

        // v.5
        //int startIndex = input.IndexOf("<upcase>");
        //int endIndex = input.IndexOf("</upcase>");

        //do
        //{
        //    int index = startIndex + "<upcase>".Length;
        //    int count = endIndex - index;

        //    string substring = input.Substring(index, count);
        //    input = input.Replace(substring, substring.ToUpper()).Remove(startIndex, "<upcase>".Length);

        //    startIndex = input.IndexOf("<upcase>", startIndex + 1);
        //    endIndex = input.IndexOf("</upcase>", endIndex + 1);

        //} while (startIndex != -1);

        //input = input.Replace("</upcase>", string.Empty);

        //Console.WriteLine(input);
    }

    public static void PrintArr(string[] arr)
    {
        for (int i = 0, len = arr.Length; i < len; i++)
        {
            Console.Write(arr[i]);
        }

        Console.WriteLine();
    }

    public static void PrintMatches(MatchCollection matches)
    {
        foreach (Match match in matches)
        {
            Console.Write(match.Value);
        }

        Console.WriteLine();
    }
}
