using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class ParsesAnURL
{
    static void Main()
    {
        string input = "http://www.devbg.org/forum/index.php";
        string protocol = string.Empty;
        string server = string.Empty;
        string resourse = string.Empty;

        //v.1

        StringBuilder myBuilder1 = new StringBuilder();
        myBuilder1.Append('"');

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == ':' && protocol == "")
            {
                protocol = myBuilder1.Append('"').ToString();
                myBuilder1.Clear().Append('"');
            }
            else if (input[i] == '/')
            {
                if (input[i + 1] != '/' && input[i - 1] != '/')
                {
                    if (server == "")
                    {
                        server = myBuilder1.Append('"').ToString();
                        myBuilder1.Clear().Append('"');
                    }

                    myBuilder1.Append(input[i]);
                }
            }
            else if (i == input.Length - 1)
            {
                myBuilder1.Append(input[i]);
                resourse = myBuilder1.Append('"').ToString();
                myBuilder1.Clear().Append('"');
            }
            else
            {
                myBuilder1.Append(input[i]);
            }
        }

        Console.WriteLine(protocol);
        Console.WriteLine(server);
        Console.WriteLine(resourse);
        Console.WriteLine();


        //v.2

        string[] output = input.Split(new[] { ':', '/', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        StringBuilder myBuilder2 = new StringBuilder();
        myBuilder2.Append('"');

        for (int i = 2; i < output.Length; i++)
        {
            myBuilder2.Append('/');
            myBuilder2.Append(output[i]);
        }

        myBuilder2.Append('"');

        Console.WriteLine(@"""{0}""", output[0]);
        Console.WriteLine(@"""{0}""", output[1]);
        Console.WriteLine(myBuilder2);
        Console.WriteLine();

        //v.3

        Uri myUri = new Uri("http://www.devbg.org/forum/index.php");

        Console.WriteLine(@"""{0}""", myUri.Scheme);
        Console.WriteLine(@"""{0}""", myUri.Host);
        Console.WriteLine(@"""{0}""", myUri.AbsolutePath);
        Console.WriteLine();

        //v.4 string 

        string regex = @"(?<protocol>(.)+?)://(?<server>[^/]+?)(?<resourse>/(.)+)";

        Match match = Regex.Match(input, regex, RegexOptions.IgnoreCase);

        Console.WriteLine(@"""{0}""", match.Groups["protocol"].Value);
        Console.WriteLine(@"""{0}""", match.Groups["server"].Value); 
        Console.WriteLine(@"""{0}""", match.Groups["resourse"].Value);
        Console.WriteLine();

        //v.5

        var fragments = Regex.Match(input, "(.*)://(.*?)(/.*)").Groups;

        Console.WriteLine(@"""{0}""", fragments[1]);
        Console.WriteLine(@"""{0}""", fragments[2]);
        Console.WriteLine(@"""{0}""", fragments[3]);
        Console.WriteLine();
    }
}
