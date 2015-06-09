using System;
using System.Numerics;

class Tribonacci
{
    static void Main()
    {
        BigInteger x1 = BigInteger.Parse(Console.ReadLine()),
            x2 = BigInteger.Parse(Console.ReadLine()),
            x3 = BigInteger.Parse(Console.ReadLine()),
            n = BigInteger.Parse(Console.ReadLine());
        BigInteger xN = 0;
        if (n > 3)
        {
            for (BigInteger i = 0; i <= n - 4; i++)
            {
                xN = x3 + x2 + x1;
                x1 = x2;
                x2 = x3;
                x3 = xN;
            }
            Console.WriteLine(xN);
        }
        else if (n == 3)
        {
            Console.WriteLine(x3);
        }
        else if (n == 2)
        {
            Console.WriteLine(x2);
        }
        else if (n == 1)
        {
            Console.WriteLine(x1);
        }
    }
}

