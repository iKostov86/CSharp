using System;
using System.Collections.Generic;
using System.Numerics;

class CalculateNFacturial
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

    static void Main()
    {
        int n = 0;
        do
        {
            Console.WriteLine("Enter a N from 0 to 100: ");
            n = int.Parse(Console.ReadLine());

        } while ((n < 0) || (n > 100));

        Print(Multiply(n));
    }

    static List<int> Multiply(int n)
    {
        List<int> array = new List<int>();
        if (n == 0)
        {
            return array;
        }
        array.Add(1);
        int result = 0;
        int carry = 0;

        for (int i = 2; i <= n; i++)
        {
            for (int j = 0; j < array.Count; j++)
            {
                result = ((array[j] * i) + carry) % 10;
                carry = ((array[j] * i) + carry) / 10;
                array[j] = result;
            }
            while ((carry != 0))
            {
                array.Add(carry % 10);
                carry = carry / 10;
            }
        }
        return array;
    }

    static void Print(List<int> array)
    {
        for (int i = array.Count - 1; i > -1; i--)
        {
            Console.Write(array[i]);
        }
        Console.WriteLine();
    }
}

