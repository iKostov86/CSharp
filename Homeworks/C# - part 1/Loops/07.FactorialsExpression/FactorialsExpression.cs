using System;
using System.Numerics;

class FactorialsExpression
{
    static void Main()
    {
        Console.WriteLine("Please enter N and K (N>K>1): ");
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        BigInteger result = 1;

        if ((n < k) || (k < 1))
        {
            Console.WriteLine("Error, try again!");
            return;
        }

        for (int i = k; i > 0 ; i--)
        {
            result *= i;
        }

        for (int i = n; i > (n - k); i--)
        {
            result *= i;
        }

        Console.WriteLine(result);
    }
}
