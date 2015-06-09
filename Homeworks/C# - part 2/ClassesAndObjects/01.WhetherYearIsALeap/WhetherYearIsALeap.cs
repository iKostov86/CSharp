using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class WhetherYearIsALeap
{
    static void Main()
    {
        const int Feb = 2;
        int year = int.Parse(Console.ReadLine());
        int daysOfMonth = DateTime.DaysInMonth(year, Feb);

        Console.WriteLine(daysOfMonth);

        if (DateTime.IsLeapYear(year))
        //if (daysOfMonth > 28)
        {
            Console.WriteLine("The year is a leap.");
        }
        else
        {
            Console.WriteLine("The year isn't a leap.");
        }
    }
}
