using System;
using System.Globalization;

public class NumberOfDaysBetweenDates
{
    internal static void Main()
    {
        string separateLine = new string('-', 31);
        string firstStr = "01.01.2007";
        string secondStr = "27.12.2006";
        
        DateTime firstDate = DateTime.ParseExact(firstStr, "d.M.yyyy", DateTimeFormatInfo.InvariantInfo);
        DateTime secondDate;
        DateTime.TryParseExact(secondStr, "d.M.yyyy", DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out secondDate);

        var result = Math.Abs(firstDate.Subtract(secondDate).TotalDays);

        Console.WriteLine(separateLine);
        Console.WriteLine(result);
        Console.WriteLine(separateLine);
    }
}
