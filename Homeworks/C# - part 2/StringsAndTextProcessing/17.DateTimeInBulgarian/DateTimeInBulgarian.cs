using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

class DateTimeInBulgarian
{
    static void Main()
    {
        string inputDate = "14.03.2015 12:15:15";
        DateTime myDate = DateTime.ParseExact(inputDate, "dd.MM.yyyy hh:mm:ss", CultureInfo.InvariantCulture);
        myDate = myDate.AddHours(6.5);

        //v.1

        Console.WriteLine(myDate.ToString("dd.MM.yyyy hh:mm:ss dddd", CultureInfo.CreateSpecificCulture("bg-BG")));
        
        //v.2

        Console.WriteLine("{0:dd.MM.yyyy hh:mm:ss} {1}", myDate, new CultureInfo("bg-BG").DateTimeFormat.GetDayName(myDate.DayOfWeek));
    }
}
