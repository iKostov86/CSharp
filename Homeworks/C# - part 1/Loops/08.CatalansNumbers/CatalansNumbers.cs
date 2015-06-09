using System;
using System.Numerics;

class CatalansNumbers
{
    static void Main()
    {
            int n = int.Parse(Console.ReadLine());

            BigInteger result = 0;
            BigInteger factorialDividend = 1;
            BigInteger factorialDivisor = 1;

            if (n == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                for (int i = 2 * n; i > n + 1; i--)
                {
                    factorialDividend *= i;
                }
                for (int i = n; i > 0; i--)
                {
                    factorialDivisor *= i;
                }

                result = factorialDividend / factorialDivisor;
                Console.WriteLine(result);
            }
    }
}
