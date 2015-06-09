using System;
using System.Numerics;

class FactorialsDivision
{
    static void Main()
    {
        Console.WriteLine("Please enter N and K (N>K>1): ");
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        //int numerator = 1;
        //int divider = 1;

        if ((n < k) || (k < 1))
        {
            Console.WriteLine("Error, try again!");
            return;
        }

        //for (int i = 1; i <= n; i++)
        //{
        //    numerator *= i;
        //}

        //for (int i = 1; i <= k; i++)
        //{
        //    divider *= i;
        //}

        //Console.WriteLine("{0}", numerator / divider);

        BigInteger result = 1;

        for (int i = k + 1; i <= n; i++)
        {
            result *= i;
        }

        Console.WriteLine();
        Console.WriteLine(result);
    }
}
