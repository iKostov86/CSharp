using System;
using System.Collections.Generic;

class FindsTheMaximalSequence
{
    static void Main()
    {
        //Console.WriteLine("Enter a string with digits from 0 to 9: ");
        //string input = Console.ReadLine();
        //char[] charArr = input.ToCharArray();

        string str = "1234593694224567";
        char[] charArr = str.ToCharArray();
        int start = 0;
        int currentStart = 0;
        int count = 0;
        int currentCount = 0;

        for (int i = 1; i < charArr.Length; i++)
        {
            if (charArr[i] > charArr[i - 1])
            {
                currentCount++;
                if (i == charArr.Length - 1 && currentCount > count)
                {
                    start = currentStart;
                    count = currentCount;
                }
            }
            else
            {
                if (currentCount > count)
                {
                    start = currentStart;
                    count = currentCount;
                }
                currentStart = i;
                currentCount = 0;
            }
        }

        PrintArraySequence(charArr, start, count);
    }

    public static void PrintArraySequence(char[] charArr, int start, int count)
    {
        for (int i = start; i <= start + count; i++)
        {
            Console.Write(charArr[i]);
        }

        Console.WriteLine();
    }
}


