using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ComparesTwoCharArrays
{
    public const string FIRST = "first";
    public const string SECOND = "second";
    public const string EQUAL = "equal";

    static void Main()
    {
        string firstStr = GetInput();
        string secondStr = GetInput();
        char[] firstArr = firstStr.ToLower().ToCharArray();
        char[] secondArr = secondStr.ToLower().ToCharArray();
        string comparisonResult = GetCharArraysComparison(firstArr, secondArr);

        Console.WriteLine(firstStr);
        Console.WriteLine(secondStr);
        Console.WriteLine();

        PrintAccordingToComparison(comparisonResult, firstStr, secondStr);
    }

    public static string GetRandomInput()
    {
        Random random = new Random();
        StringBuilder sequence = new StringBuilder();
        char[] alphabet = Enumerable.Range('A', 26)
            .Select(x => (char)x)
            .Concat(Enumerable.Range('a', 26)
                .Select(y => (char)y))
            .ToArray();

        for (int i = 0, len = random.Next(1, 11); i < len; i++)
        {
            sequence.Append(alphabet[random.Next(0, alphabet.Length)]);
        }

        return sequence.ToString();
    }

    public static string GetInput()
    {
        Console.WriteLine("Please enter a string: ");
        string input = Console.ReadLine();

        if (string.IsNullOrEmpty(input))
        {
            input = GetRandomInput();
        }

        return input;
    }

    public static string GetCharArraysComparison(char[] firstArr, char[] secondArr)
    {
        int firstLen = firstArr.Length;
        int secondLen = secondArr.Length;
        int comparisonLen = GetComparisonLen(firstLen, secondLen);

        for (int i = 0; i < comparisonLen; i++)
        {
            if (firstArr[i] < secondArr[i])
            {
                return FIRST;
            }
            else if (firstArr[i] > secondArr[i])
            {
                return SECOND;
            }
        }

        return EQUAL;
    }

    public static int GetComparisonLen(int firstLen, int secondLen)
    {
        return firstLen <= secondLen ? firstLen : secondLen;
    }

    public static void PrintAccordingToComparison(string result, string firstStr, string secondStr)
    {
        if (result == EQUAL)
        {
            Console.WriteLine("Both are the same.");
        }
        else if (result == FIRST)
        {
            Console.WriteLine("{0} is before {1} lexicographically.", firstStr, secondStr);
        }
        else
        {
            Console.WriteLine("{0} is after {1} lexicographically", firstStr, secondStr);
        }
    }
}
