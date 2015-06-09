using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class UppercaseTaggedRegions
{
    static void Main()
    {
        string input = "We are living in a <upcase>yellow"
                     + " submarine</upcase>. We don't have"
                     + " <upcase>anything</upcase> else.";
        //v.1

        //var output = input.Split(new[] { "<upcase>", "</upcase>" }, StringSplitOptions.RemoveEmptyEntries)
        //                    .Select((str, i) => { if ((i % 2) != 0) { return str.ToUpper(); } return str; });

        //foreach (var item in output)
        //{
        //    Console.Write(item);
        //}
        //Console.WriteLine();

        //v.2

        string regex = @"<upcase>(?<groupName>(.|\s)*?)</upcase>";
        Console.WriteLine(Regex.Replace(input, regex, word => word.Groups["groupName"].Value.ToUpper()));

        //v.3

        //input = Regex.Replace(input, @"<upcase>(.*?)</upcase>", delegate(Match match)
        //{
        //    string current = match.ToString().ToUpper();
        //    return Regex.Replace(current, @"<[^>]*>", String.Empty);
        //});

        //Console.WriteLine(input);

        //v.5

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

        //input = input.Replace("</upcase>", "");

        //Console.WriteLine(input);
    }
}
