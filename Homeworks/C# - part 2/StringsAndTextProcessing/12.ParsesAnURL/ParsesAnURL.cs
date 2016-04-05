using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

public class ParsesAnURL
{
    internal static void Main()
    {
        //string input = "http://www.devbg.org/forum/index.php";
        string input = "http://telerikacademy.com/Courses/Courses/Details/212";
        string protocol = string.Empty;
        string server = string.Empty;
        string resource = string.Empty;

        // v.1
        //StringBuilder sb = new StringBuilder();
        //sb.Append('"');

        //for (int i = 0, len = input.Length; i < len; i++)
        //{
        //    if (input[i] == ':' && protocol == string.Empty)
        //    {
        //        protocol = sb.Append('"').ToString();
        //        sb.Clear().Append('"');
        //    }
        //    else if (input[i] == '/')
        //    {
        //        if (input[i + 1] != '/' && input[i - 1] != '/')
        //        {
        //            if (server == "")
        //            {
        //                server = sb.Append('"').ToString();
        //                sb.Clear().Append('"');
        //            }

        //            sb.Append(input[i]);
        //        }
        //    }
        //    else if (i == input.Length - 1)
        //    {
        //        sb.Append(input[i]);
        //        resource = sb.Append('"').ToString();
        //        sb.Clear().Append('"');
        //    }
        //    else
        //    {
        //        sb.Append(input[i]);
        //    }
        //}

        //Console.WriteLine(protocol);
        //Console.WriteLine(server);
        //Console.WriteLine(resource);

        // v.2
        //int protocolEndIndex = input.IndexOf(':');
        //int serverStartIndex = input.IndexOf("//", protocolEndIndex) + 2;
        //int resourceStartIndex = input.IndexOf('/', serverStartIndex);

        //protocol = input.Substring(0, protocolEndIndex);
        //server = input.Substring(serverStartIndex, resourceStartIndex - serverStartIndex);
        //resource = input.Substring(resourceStartIndex, input.Length - resourceStartIndex);

        //Console.WriteLine(@"""{0}""", protocol);
        //Console.WriteLine(@"""{0}""", server);
        //Console.WriteLine(@"""{0}""", resource);

        // v.3
        //Uri uri = new Uri(input);

        //Console.WriteLine(@"""{0}""", uri.Scheme);
        //Console.WriteLine(@"""{0}""", uri.Host);
        //Console.WriteLine(@"""{0}""", uri.AbsolutePath);

        // v.4 string 
        //string regex = @"(?<protocol>(\S)+?)://(?<server>[^/]+?)(?<resource>/(\S)+)";

        //Match match = Regex.Match(input, regex, RegexOptions.IgnoreCase);

        //Console.WriteLine(@"""{0}""", match.Groups["protocol"].Value);
        //Console.WriteLine(@"""{0}""", match.Groups["server"].Value);
        //Console.WriteLine(@"""{0}""", match.Groups["resource"].Value);

        // v.5
        var fragments = Regex.Match(input, "(\\S*?)://(\\S*?)(/\\S*)").Groups;

        Console.WriteLine(@"""{0}""", fragments[1]);
        Console.WriteLine(@"""{0}""", fragments[2]);
        Console.WriteLine(@"""{0}""", fragments[3]);
    }
}
