using System;

public class SieveOfEratosthenes
{
    internal static void Main()
    {
        int dimension = 100;
        int?[] primes = GetNumbers(dimension);

        for (int i = 2, len = primes.Length; i < len; i++)
        {
            if (i != 0)
            {
                for (int j = (i * 2) - 1; j < len; j += i)
                {
                    primes[j] = null;
                }
            }
        }

        PrintPrimes(primes);
    }

    public static int?[] GetNumbers(int length)
    {
        int?[] nums = new int?[length];

        for (int i = 0, len = nums.Length; i < len; i++)
        {
            nums[i] = i + 1;
        }

        return nums;
    }

    public static void PrintPrimes(int?[] primes)
    {

        for (int i = 1, len = primes.Length; i < len; i++)
        {
            if (primes[i] != null)
            {
                Console.Write("{0} ", primes[i]);
            }
        }

        Console.WriteLine();
    }
}
