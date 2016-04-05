using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

public class ExtractEmail
{
    internal static void Main()
    {
        string input = "Please contact us by phone (+359 222 222 222) or by email at example@abv.bg or at baj.ivan@yahoo.co.uk. This is not email: test@test. This also: @telerik.com. Neither this: a@a.b.";

        // v.1
        string regex = @"\b[a-zA-Z0-9.-_]+@[a-zA-Z0-9.]+\.[a-z]{2,4}";

        MatchCollection matches = Regex.Matches(input, regex, RegexOptions.IgnoreCase);
        PrintEmails(matches.Cast<Match>());

        // v.2
        var separateEmails = input
            .Split(new[] { " ", ". ", ".\r", "," }, StringSplitOptions.RemoveEmptyEntries)
            .Where(x => x.Contains('@') && x.Contains('.') && !x.StartsWith("@") && !x.StartsWith(".") && !x.EndsWith("@") && !x.EndsWith("."));

        PrintEmails(separateEmails);
    }

    public static void PrintEmails<T>(IEnumerable<T> emails)
    {
        foreach (var email in emails)
        {
            Console.WriteLine(email);
        }
    }
}
