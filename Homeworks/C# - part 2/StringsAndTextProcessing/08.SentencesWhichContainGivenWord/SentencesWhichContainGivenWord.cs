using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class SentencesWhichContainGivenWord
{
    internal static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        string input = "We are living in a yellow submarine. "
                       + "We don't have anything else. "
                       + "Inside the submarine is very tight. "
                       + "So we are drinking all the day. "
                       + "We will move out of it in 5 days. ";
        string word = "in";

        // v.1
        string[] sentences = input.Split(new[] { ". ", "! ", "? ", ".", "!", "?" }, StringSplitOptions.RemoveEmptyEntries);

        StringBuilder sb = new StringBuilder();

        for (int i = 0, len = sentences.Length; i < len; i++)
        {
            string[] words = sentences[i].Split(new[] { ' ', ',', ';', ':', '-', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);

            if (words.Contains(word))
            {
                sb.Append(sentences[i]);
                sb.AppendLine(".");
            }
        }

        Console.Write(sb);

        // v.2
        //string regex = @"\s*(?<groupName>[^\.]*?\bin\b(.|\s)*?\.)";
        string regex = @"\s*(?<sentence>[^\.]*?\bin\b[^\.]*?\.)";

        MatchCollection matches = Regex.Matches(input, regex, RegexOptions.IgnoreCase);

        foreach (Match match in matches)
        {
            Console.WriteLine(match.Groups["sentence"]);
        }
    }
}
