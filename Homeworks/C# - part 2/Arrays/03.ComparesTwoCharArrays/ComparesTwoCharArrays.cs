using System;
using System.Collections.Generic;

class ComparesTwoCharArrays
{
    static void Main()
    {
        string firstStr = GetUserStr();
        string secondStr = GetUserStr();

        if (ValidateCharArraysDimensionEquality(firstStr.Length, secondStr.Length))
        {
            char[] firstArr = firstStr.ToCharArray();
            char[] secondArr = secondStr.ToCharArray();
            bool comparisonResult = GetCharArraysComparison(firstArr, secondArr);

            PrintAccordingToComparison(comparisonResult);
        }
    }

    public static string GetUserStr()
    {
        Console.WriteLine("Please enter a string: ");

        return Console.ReadLine();
    }

    public static bool GetCharArraysComparison(char[] firstArr, char[] secondArr)
    {
        int comparisonLen = GetComparisonLen(firstArr.Length, secondArr.Length);

        for (int i = 0; i < comparisonLen; i++)
        {
            if (firstArr[i] != secondArr[i])
            {
                return false;
            }
        }

        return true;
    }

    public static int GetComparisonLen(int firstLen, int secondLen)
    {
        return firstLen <= secondLen ? firstLen : secondLen;
    }

    public static bool ValidateCharArraysDimensionEquality(int firstLen, int secondLen)
    {
        if (firstLen != secondLen)
        {
            Console.WriteLine("The arrays can not be the same.");
            return false;
        }

        return true;
    }

    public static void PrintAccordingToComparison(bool result)
    {
        if (result)
        {
            Console.WriteLine("Both are the same.");
        }
        else
        {
            Console.WriteLine("The char arrays are not equal.");
        }
    }
}
