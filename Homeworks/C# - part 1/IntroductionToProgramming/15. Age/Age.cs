using System;
using System.Globalization;

public class Age
{
    static void Main(string[] args)
    {
        string birthdayAsStr = "05.16.1994";
        string birthdayAsStr2 = "07.02.1986";
        string format = "MM.dd.yyyy";

        //DateTime dateOfBirth = DateTime.ParseExact(birthdayAsStr, format, CultureInfo.InvariantCulture);
        //DateTime present = DateTime.ParseExact("02.04.2016", format, CultureInfo.InvariantCulture);

        DateTime dateOfBirth = DateTime.ParseExact(Console.ReadLine(), format, CultureInfo.InvariantCulture);
        DateTime present = DateTime.Now;

        TimeSpan difference = present.Subtract(dateOfBirth);
        //int age = DateTime.MinValue.AddDays(difference.Days).Year - 1;
        int age = (new DateTime(1, 1, 1) + difference).Year - 1;

        Console.WriteLine(age - 1);

        present = present.AddYears(10);
        difference = present - dateOfBirth;
        //age = DateTime.MinValue.AddDays(difference.Days).Year - 1;
        age = (new DateTime(1, 1, 1) + difference).Year - 1;

        Console.WriteLine(age - 1);
    }
}