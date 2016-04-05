using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class ForbiddenWords
{
    static void Main()
    {
        string text = "Microsoft announced its next generation PHP " + Environment.NewLine
                    + "compiler today. It is based on .NET Framework 4.0 " + Environment.NewLine
                    + "and is implemented as a dynamic language in CLR.";

        string forbiddenWordsAsStr = "PHP, CLR, Microsoft";
        string[] forbiddenWords = forbiddenWordsAsStr.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        // v.1
        //foreach (var word in forbiddenWords)
        //{
        //    text = text.Replace(forbiddenWordsAsStr, new string('*', forbiddenWords.Length));
        //}

        //Console.WriteLine(text);

        // v.2
        //string regex = @"(?<ForbiddenWords>\b(PHP|CLR|Microsoft)\b)";

        var forbiddenWordsAsRegex = string.Join("|", forbiddenWords);
        string regex = @"(?<ForbiddenWords>\b(" + forbiddenWordsAsRegex + @")\b)";

        text = Regex.Replace(text, regex, match => new string('*', match.Groups["ForbiddenWords"].Length));

        Console.WriteLine(text);
    }
}
