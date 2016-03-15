using System;
using System.Collections.Generic;

public class ReverseTheDigits
{
    internal static void Main()
    {
        decimal givenNumber = -21559M;
        //int givenNumber = 219;
        ReverseDigits(givenNumber);
    }

    public static void ReverseDigits(int num)
    {
        int result = 0;

        while (num > 0)
        {
            result = (result * 10) + (num % 10);
            num /= 10;
        }

        Print(result);
    }

    public static void ReverseDigits(decimal num)
    {
        string numAsStr = num.ToString();
        ReverseDigits(numAsStr);
    }

    public static void ReverseDigits(string numAsStr)
    {
        int sign = 0;
        char negativeSign = '-';
        char[] reversedNum = new char[numAsStr.Length];

        if (numAsStr[0] == negativeSign)
        {
            sign = 1;
            reversedNum[0] = negativeSign;
        }

        for (int i = sign, len = numAsStr.Length; i < len; i++)
        {
            reversedNum[len - i] = (numAsStr[i]);
        }

        Print(reversedNum);
    }

    public static void Print(int forPrint)
    {
        Console.WriteLine(forPrint);
    }

    public static void Print(char[] forPrint)
    {
        foreach (var item in forPrint)
        {
            Console.Write(item);
        }

        Console.WriteLine();
    }
}
