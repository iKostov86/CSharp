using System;

public class LastDigit
{
    internal enum Digits
    {
        zero,
        one,
        two,
        three,
        four,
        five,
        six,
        seven,
        eight,
        nine
    };

    internal static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        PrintLastDigit(number);
    }

    public static void PrintLastDigit(int number)
    {
        int digit = number % 10;

        foreach (var item in Enum.GetValues(typeof(Digits)))
        {
            if (digit == (int)item)
            {
                Console.WriteLine(item);
            }
        }
    }
}
