using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class ReplaceTagsInHTMLString
{
    static void Main()
    {
        string input = @"<p>Please visit <a href=""http://academy.telerik.com"">our site</a> to choose a training course. Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>";

        //v.1

        //var output = input.Replace("<a href", "[URL").Replace("</a>", "[/URL]").Replace(@""">", @"""]");
        //Console.WriteLine(output);

        //v.2

        var output = input.Split(new[] { "<a href=\"", "\">", "</a>" }, StringSplitOptions.RemoveEmptyEntries);

        StringBuilder myBuilder = new StringBuilder();
        int count = 1;

        foreach (var item in output)
        {
            myBuilder.Append(item);
            if (!item.EndsWith("</p>"))
            {
                if ((count % 3) == 1)
                {
                    myBuilder.Append("[URL=");
                }
                else if ((count % 3) == 2)
                {
                    myBuilder.Append("]");
                }
                else
                {
                    myBuilder.Append("[/URL]");
                }
                count++;
            }

        }
        Console.WriteLine(myBuilder);

        //v.3

        Console.WriteLine(Regex.Replace(input, @"<a href=""(.*?)"">(.*?)</a>", @"[URL=$1]$2[/URL]"));

        //v.4

        string regex = @"<\s*a\s[^>]*\bhref\b\s*=\s*('(?<hyperlink>[^']*)'|""(?<hyperlink>[^""]*)""|(?<hyperlink>\S*))[^>]*>(?<hyperlinktext>(.|\s)*?)<\s*/a\s*>";
        Console.WriteLine(Regex.Replace(input, regex, m => "[URL=" + m.Groups["hyperlink"].Value + "]" + m.Groups["hyperlinktext"].Value + "[/URL]"));
    }
}
