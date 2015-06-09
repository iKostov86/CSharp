using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class ExtractEmail
{
    static void Main()
    {
        string input = "Please contact us by phone (+359 222 222 222) or by email at example@abv.bg or at baj.ivan@yahoo.co.uk. This is not email: test@test. This also: @telerik.com. Neither this: a@a.b.";
        string regex = "\b[a-z0-9._%+-]+@([a-z0-9-]/.)+[a-z]{2,4}\b";

        MatchCollection matches = Regex.Matches(input, regex, RegexOptions.IgnoreCase);

        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }

        //var separateEmails = input.Split(new[] { " ", ". ", ".\r", "," }, StringSplitOptions.RemoveEmptyEntries).Where(x => x.Contains('@')).Where(x => x.Contains("."));

        //foreach (var email in separateEmails)
        //{
        //    if (!email.StartsWith("@") && !email.StartsWith(".") && !email.EndsWith("@") && !email.EndsWith("."))
        //    {
        //        Console.WriteLine(email);
        //    }
        //}
    }
}
