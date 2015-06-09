using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

class NumberOfDaysBetweenDates
{
    static void Main()
    {
        Console.WriteLine(new string('-', 31));
        string firstStr = "27.02.2006";
        string secondStr = "03.03.2006";
        DateTime firstDate = DateTime.ParseExact(firstStr, "d.M.yyyy", CultureInfo.InvariantCulture);
        DateTime secondDate;
        DateTime.TryParseExact(secondStr, "d.M.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out secondDate);

        var result = Math.Abs(firstDate.Subtract(secondDate).TotalDays);

        Console.WriteLine(result);
        Console.WriteLine(new string('-', 31));
        Console.WriteLine();
    }
}
