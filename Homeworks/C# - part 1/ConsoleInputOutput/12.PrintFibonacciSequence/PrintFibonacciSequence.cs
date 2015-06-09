using System;
using System.Numerics;

    class PrintFibonacciSequence
    {
        static void Main()
        {
            BigInteger n_2 = 1;
            BigInteger n_1 = 1;
            BigInteger temp = 0;

            for (int i = 1; i < 101; i++)
            {
                if (i > 2)
                {
                    temp = n_1 + n_2;
                    Console.WriteLine(temp);
                    n_2 = n_1;
                    n_1 = temp;
                }
                else
                {
                    Console.WriteLine(1);
                }
            }
        }
    }
