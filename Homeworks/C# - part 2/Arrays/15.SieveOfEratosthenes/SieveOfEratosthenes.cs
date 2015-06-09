using System;

class SieveOfEratosthenes
{
    static void Main()
    {
        int[] arrayPrimes = new int[100];
        for (int i = 0; i < arrayPrimes.Length; i++)
        {
            arrayPrimes[i] = i + 1;
        }
        for (int i = 2; i < arrayPrimes.Length; i++)
        {
            if (i != 0)
            {
                for (int j = (i * 2) - 1; j < arrayPrimes.Length; j += i)
                {
                    arrayPrimes[j] = 0;
                }
            }
        }
        for (int i = 0; i < arrayPrimes.Length; i++)
        {
            if (arrayPrimes[i] != 0)
            {
                Console.WriteLine(arrayPrimes[i]);
            }
        }
    }
}
