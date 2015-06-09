using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

class DateExtractor
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        string input = "Today is 17.12.2034. I am a student since 1.9.2006. OK.";
        string[] formats = new string[] { "dd.MM.yyyy", "d.M.yyyy"};

        //var extractDates = input.Split(new char[] { ' ' }).Select(x => x.TrimEnd(new char[] { ',', '.', '!', '?', ';', ':' }));

        //foreach (var date in extractDates)
        //{
        //    try
        //    {
        //        DateTime myDate = DateTime.ParseExact(date, formats, CultureInfo.InvariantCulture, DateTimeStyles.None);
        //        Console.WriteLine(myDate.ToString(CultureInfo.GetCultureInfo("en-CA")));
        //    }
        //    catch (Exception)
        //    {
                
        //    }
        //}
        //Console.WriteLine();

        string regex = @"((0?[1-9]|[12][0-9]|3[01])\.(0?[1-9]|1[0-2])\.(19[0-9][0-9]|20[0-9][0-9]))";

        MatchCollection matches = Regex.Matches(input, regex, RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace);

        foreach (Match match in matches)
        {
            try
            {
                DateTime myDate = DateTime.ParseExact(match.Value, formats, CultureInfo.InvariantCulture, DateTimeStyles.None);

                Console.WriteLine(myDate.ToString(CultureInfo.GetCultureInfo("en-US")));
                Console.WriteLine(myDate.ToString(CultureInfo.GetCultureInfo("en-CA")));
                Console.WriteLine(myDate.ToString(CultureInfo.GetCultureInfo("fr-FR")));
                Console.WriteLine(myDate.ToString(CultureInfo.GetCultureInfo("bg-BG")));
            }
            catch (Exception)
            {
                
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
