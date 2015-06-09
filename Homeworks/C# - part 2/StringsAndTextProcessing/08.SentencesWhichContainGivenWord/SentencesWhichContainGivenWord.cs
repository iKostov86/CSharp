using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class SentencesWhichContainGivenWord
{
    static void Main()
    {
        string input = "We are living in a yellow submarine. "
                       +  "We don't have anything else. "
                       + "Inside the submarine is very tight. "
                       + "So we are drinking all the day. "
                       + "We will move out of it in 5 days. ";

        //v.1

        //string[] output = input.Split(new[] { '.', ' ' });

        //bool contain = false;

        //StringBuilder myBuilder = new StringBuilder();
        //StringBuilder tempBuilder = new StringBuilder();

        //for (int i = 0; i < output.Length; i++)
        //{
        //    if (output[i] == "")
        //    {
        //        if (contain)
        //        {
        //            tempBuilder.Append("." + Environment.NewLine);
        //            myBuilder.Append(tempBuilder);
        //        }

        //        tempBuilder.Clear();
        //        contain = false;
        //    }
        //    else
        //    {
        //        tempBuilder.Append(output[i]);

        //        if (output[i] == "in")
        //        {
        //            contain = true;
        //        }
        //        if (output[i + 1] != "")
        //        {
        //            tempBuilder.Append(" ");
        //        }
        //    }
        //}

        //Console.WriteLine(myBuilder);

        //v.2

        //string[] output = input.Trim().Split(new[] { ". ", "." }, StringSplitOptions.RemoveEmptyEntries);

        //StringBuilder myBuilder = new StringBuilder();

        //for (int i = 0; i < output.Length; i++)
        //{
        //    string[] words = output[i].Trim().Split(new[] { ' ', ',', ':', ';', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);

        //    if (words.Contains("in"))
        //    {
        //        myBuilder.Append(output[i]);
        //        myBuilder.Append("." + Environment.NewLine);
        //    }
        //}

        //Console.WriteLine(myBuilder);

        //v.3

        string regex = @"\s*(?<groupName>[^\.]*?\bin\b(.|\s)*?\.)";

        MatchCollection matches = Regex.Matches(input, regex, RegexOptions.IgnoreCase);

        foreach (Match match in matches)
        {
            Console.WriteLine(match.Groups["groupName"]);
        }
    }
}
