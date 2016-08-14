using System;
using System.IO;
using System.Text.RegularExpressions;

public class HTMLParser
{
    internal static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        string input = "input.txt";
        string output = string.Empty;

        if (!File.Exists(input))
        {
            string createText = "<html>" + Environment.NewLine +
                                "   <head><title>News</title></head>" + Environment.i +
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
