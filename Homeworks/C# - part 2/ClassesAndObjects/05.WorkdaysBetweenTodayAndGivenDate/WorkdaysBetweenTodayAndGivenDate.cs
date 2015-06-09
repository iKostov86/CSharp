using System;
using System.Collections.Generic;

class WorkdaysBetweenTodayAndGivenDate
{

    static void Main()
    {
        string[] holidays = new string[]
        {
            "Saturday",
            "Sunday",
            "3/3/2015 12:00:00 AM",
        };

        int workdays = new int();
        DateTime today = DateTime.Today;
        DateTime givenDate = new DateTime(2015, 04, 01);

        while (givenDate != today)
        {
            int chek = 0;

            foreach (var item in holidays)
            {
                string itemToString = item.ToString();

                if (today.ToString() == itemToString || today.DayOfWeek.ToString() == itemToString)
                {
                    chek = 1;
                    break;
                }
            }

            if (chek == 0)
            {
                workdays++;
            }

            today = today.AddDays(1);
        }

        Console.WriteLine(workdays);

    }
}
