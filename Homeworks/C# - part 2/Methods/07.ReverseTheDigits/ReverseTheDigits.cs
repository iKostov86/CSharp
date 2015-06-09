using System;
using System.Collections.Generic;

public class ReverseTheDigits
{
    static void Main()
    {
        decimal givenNumber = -219M;
        ReverseNumber(givenNumber);
    }

    public static void ReverseNumber(int number)
    {
        int tempNumber = 0;
        while (number > 0)
        {
            tempNumber = (tempNumber * 10) + (number % 10);
            number /= 10;
        }
        PrintMethod(tempNumber);
    }

    public static void ReverseNumber(decimal decNumber)
    {
        string strNumber = decNumber.ToString();
        ReverseNumber(strNumber);
    }

    public static void ReverseNumber(string strNumber)
    {
        List<char> reversedNumber = new List<char>();
        int sign = 0;
        if (strNumber[0] == '-')
        {
            sign = 1;
            reversedNumber.Add('-');
        }
        for (int i = strNumber.Length - 1; i >= sign; i--)
        {
            reversedNumber.Add(strNumber[i]);
        }

        PrintMethod(reversedNumber);
    }

    public static void PrintMethod(int forPrint)
    {
        Console.WriteLine(forPrint);
    }

    public static void PrintMethod(List<char> forPrint)
    {
        foreach (var item in forPrint)
        {
            Console.Write(item);
        }
        Console.WriteLine();
    }
}
