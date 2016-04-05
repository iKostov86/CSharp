using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

public class DateTimeInBulgarian
{
    internal static void Main()
    {
        string inputDate = "14.03.2015 12:15:15";
        DateTime date = DateTime.ParseExact(inputDate, "dd.MM.yyyy hh:mm:ss", CultureInfo.InvariantCulture);

        date = date.AddHours(6.5);

        // v.1
        Console.WriteLine(date.ToString("dd.MM.yyyy hh:mm:ss dddd", CultureInfo.CreateSpecificCulture("bg-BG")));

        // v.2
        //Console.WriteLine("{0:dd.MM.yyyy hh:mm:ss} {1}",
        //    date, new CultureInfo("bg-BG").DateTimeFormat.GetDayName(date.DayOfWeek));
    }
}
