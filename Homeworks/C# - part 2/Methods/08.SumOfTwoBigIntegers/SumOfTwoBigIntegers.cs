using System;

public class SumOfTwoBigIntegers
{
    internal static void Main()
    {
        string firstNumAsStr = Console.ReadLine();
        string secondNumAsStr = Console.ReadLine();
        int[] firstNumAsArr = new int[firstNumAsStr.Length];
        int[] secondNumAsArr = new int[secondNumAsStr.Length];

        ConvertStrToIntArray(firstNumAsStr, firstNumAsArr);
        ConvertStrToIntArray(secondNumAsStr, secondNumAsArr);

        int resultLen = Math.Max(firstNumAsStr.Length, secondNumAsStr.Length) + 1;
        int[] resultArr = new int[resultLen];

        Array.Copy(firstNumAsArr, resultArr, firstNumAsArr.Length);
        Sum(resultArr, secondNumAsArr);

        if (resultArr[resultLen - 1] == 0)
        {
            resultLen -= 1;
        }

        Print(resultArr, resultLen);
    }

    public static void Sum(int[] resultArr, int[] arr)
    {
        int sum = 0;
        int oneOnMind = 0;
        int len = arr.Length;

        for (int i = 0; i < len; i++)
        {
            sum = resultArr[i] + arr[i] + oneOnMind;

            if (sum > 9)
            {
                resultArr[i] = sum % 10;
                oneOnMind = 1;
            }
            else
            {
                resultArr[i] = sum;
                oneOnMind = 0;
            }
        }

        if (oneOnMind == 1)
        {
            resultArr[len] += 1;
        }
    }

    public static void ConvertStrToIntArray(string numAsStr, int[] numAsArr)
    {
        for (int i = 0, len = numAsStr.Length; i < len; i++)
        {
            numAsArr[i] = numAsStr[len - i - 1] - '0';
        }
    }

    public static void Print(int[] resultArr, int resultLen)
    {
        for (int i = resultLen - 1; i >= 0; i--)
        {
            Console.Write(resultArr[i]);
        }

        Console.WriteLine();
    }
}
