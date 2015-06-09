using System;
using System.Collections.Generic;

class ComparesTwoCharArrays
{
    static void Main()
    {
        string stringOne = Console.ReadLine();
        char[] arrayOne = stringOne.ToCharArray();
        string stringTwo = Console.ReadLine();
        char[] arrayTwo = stringTwo.ToCharArray();
        int compareLength = 0;

        if (arrayOne.Length > arrayTwo.Length)
        {
            compareLength = arrayOne.Length;
        }
        else
        {
            compareLength = arrayTwo.Length;
        }
        for (int i = 0; i < compareLength; i++)
        {
            if (arrayOne[i] > arrayTwo[i])
            {
                Console.WriteLine(@"""arrayOne"" is ahead.");
                Console.WriteLine();
                return;
            }
        }
        Console.WriteLine("Both are the same.");
    }
}
