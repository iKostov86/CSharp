using System;
using System.Collections.Generic;

class CompareElementOfIntArray
{
    static void TheyArent()
    {
        Console.WriteLine("The arrays aren't the same.");
    }
    static void Main()
    {
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        int[] arr1 = new int[n1];
        int[] arr2 = new int[n2];

        if (n1 != n2)
        {
            TheyArent();
            return;
        }
        for (int i = 0; i < arr1.Length; i++)
        {
            arr1[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < arr2.Length; i++)
        {
            arr2[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < arr1.Length; i++)
        {
            if (arr1[i] != arr2[i])
            {
                TheyArent();
                return;
            }
        }
        Console.WriteLine("Yes, they are the same.");
    }
}

