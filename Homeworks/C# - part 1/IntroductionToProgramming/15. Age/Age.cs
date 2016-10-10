using System;
using System.Globalization;
using System.Threading;

public class Age
{
    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string[] birthdays = { "07.02.1986", "05.16.1994", "10.01.1994" };
        string format = "MM.dd.yyyy";

        //DateTime dateOfBirth = DateTime.ParseExact(birthdayAsStr, format, CultureInfo.InvariantCulture);
        //DateTime present = DateTime.ParseExact("04.01.2016", format, CultureInfo.InvariantCulture);

        DateTime dateOfBirth = DateTime.ParseExact(Console.ReadLine(), format, CultureInfo.InvariantCulture);
        DateTime present = DateTime.Now;

        TimeSpan difference = present.Subtract(dateOfBirth);
        Console.WriteLine(difference.TotalDays / 365.25);
        //int age = DateTime.MinValue.AddDays(difference.Days).Year - 1;
        int age = (new DateTime(1, 1, 1) + difference).Year - 1;


        Console.WriteLine(age);
        Console.WriteLine(age + 10);
    }
}