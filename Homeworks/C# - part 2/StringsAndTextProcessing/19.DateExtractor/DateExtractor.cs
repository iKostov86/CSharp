using System;
using System.Linq;
using System.Threading;
using System.Globalization;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class DateExtractor
{
    internal static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        string input = "Today is 17.12.2034. I am a student since 1.9.2006. OK.";
        string[] formats = new string[] { "dd.MM.yyyy", "d.M.yyyy"};
        var cultureProvider = new CultureInfo("en-CA");

        // v.1
        var extractedDates = input
            .Split(new char[] { ' ' })
            .Select(x => x.TrimEnd(new char[] { '.', ',', ';', ':', '!', '?' }));

        PrintOnlyDates(extractedDates, formats, cultureProvider);

        // v.2
        string regex = @"\b(0?[1-9]|[1-2][0-9]|3[0-1])\.(0?[1-9]|1[0-2])\.(19[0-9][0-9]|20[0-9][0-9])\b";

        var matches = Regex
            .Matches(input, regex, RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace)
            .Cast<Match>();

        PrintOnlyDates(matches, formats, cultureProvider);
    }

    public static void PrintOnlyDates<T>(IEnumerable<T> dates, string[] formats, CultureInfo cultureProvider)
    {
        foreach (var date in dates)
        {
            DateTime exactDate;

            bool success = DateTime.TryParseExact(date.ToString(), formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out exactDate);

            if (success)
            {
                Console.WriteLine(exactDate.ToString(cultureProvider));
            }
        }
    }
}
