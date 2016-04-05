using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

public class WordDictionary
{
    internal static void Main()
    {
        // v.1
        Dictionary<string, string> myDictionary = new Dictionary<string, string>()
        {
            {".NET", "platform for applications from Microsoft"},
            {"CLR", "managed execution environment for .NET"},
            {"NAMESPACE", "hierarchical organization of classes"}
        };

        Console.WriteLine("Enter a word for translation: ");
        string userWord = Console.ReadLine().ToUpper();

        Console.WriteLine(myDictionary.ContainsKey(userWord) ?
                            string.Format("--> {0}", myDictionary[userWord])
                                        : string.Format("Word is not found!"));

        // v.2
        //string input = @".NET - platform for applications from Microsoft
        //                 CLR - managed execution environment for .NET
        //                 namespace - hierarchical organization of classes";

        //Console.Write("Enter a word for translation: ");

        //string userWord = Console.ReadLine();
        //string regex = userWord + @"(\s+?)\-(\s+?)(?<explanation>(.*))";

        //MatchCollection matches = Regex.Matches(input, regex, RegexOptions.IgnoreCase);

        //if (matches.Count > 0)
        //{
        //    foreach (Match match in matches)
        //    {
        //        Console.WriteLine(match.Groups["explanation"]);
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("The word is not found!");
        //}
    }
}
