using System;
using System.Collections.Generic;
//using System.Numerics;

public class CalculateNFacturial
{
    //static void Main()
    //{
    //    int n = 0;
    //    do
    //    {
    //        Console.WriteLine("Enter a N: ");
    //        n = int.Parse(Console.ReadLine());

    //    } while ((n < 0) || (n > 100));

    //    int[] intArray = new int[n];
    //    for (int i = 0; i < n; i++)
    //    {
    //        intArray[i] = i + 1;
    //    }
    //    Console.WriteLine(MultipliesIntArray(intArray));
    //}

    //static BigInteger MultipliesIntArray(int[] intArray)
    //{
    //    BigInteger result = 1;
    //    foreach (var item in intArray)
    //    {
    //        result *= item;
    //    }
    //    return result;
    //}

    internal static void Main()
    {
        int n = 0;

        do
        {
            Console.WriteLine("Enter a N from 0 to 100: ");
            n = int.Parse(Console.ReadLine());

        } while ((n < 0) || (n > 100));

        Print(Multiply(n));
    }

    public static List<int> Multiply(int n)
    {
        List<int> arr = new List<int>();

        if (n == 0)
        {
            return arr;
        }

        arr.Add(1);
        int result = 0;
        int carry = 0;

        for (int i = 2; i <= n; i++)
        {
            for (int j = 0; j < arr.Count; j++)
            {
                result = ((arr[j] * i) + carry) % 10;
                carry = ((arr[j] * i) + carry) / 10;
                arr[j] = result;
            }
            while ((carry != 0))
            {
                arr.Add(carry % 10);
                carry = carry / 10;
            }
        }
        return arr;
    }

    static void Print(List<int> arr)
    {
        for (int i = arr.Count - 1; i > -1; i--)
        {
            Console.Write(arr[i]);
        }

        Console.WriteLine();
    }
}

