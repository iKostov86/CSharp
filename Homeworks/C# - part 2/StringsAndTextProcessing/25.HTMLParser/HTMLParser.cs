using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Globalization;

class HTMLParser
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        string input = "input.txt";
        string output = string.Empty;

        if (!File.Exists(input))
        {
            string createText = "<html>" + Environment.NewLine +
                                "   <head><title>News</title></head>" + Environment.NewLine +
                                "   <body><p><a  href=\"http://academy.telerik.com\">Telerik" + Environment.NewLine +
                                "       Academy</a>aims to provide free real-world practical" + Environment.NewLine +
                                "       training for young people who want to turn into" + Environment.NewLine +
                                "       skillful .NET software engineers.</p></body>" + Environment.NewLine +
                                "</html>";
            File.WriteAllText(input, createText);
        }

        output = File.ReadAllText(input);
        string regex = @"<html>|</html>|<head><title>|</title></head>|<body><p><a(.)+?href=""(.*?)"">|</a>|</p></body>|(    )+?|(       )+?";
        string regexTwo = @"<(.)+?>|(   )+?|(       )+?";

        var result = Regex.Replace(output, regex, m => " ");
        var resultTwo = Regex.Replace(output, regexTwo, m => " ").Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        Console.WriteLine(output);
        Console.WriteLine();
        Console.WriteLine(result);

        foreach (var item in resultTwo)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        File.Delete(input);
    }
}
