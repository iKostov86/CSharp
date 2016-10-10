using System;

public class PrimeCheck
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        bool isPrime = CheckIfIsPrime(num);

        Console.WriteLine(isPrime.ToString().ToLower());
    }

    public static bool CheckIfIsPrime(int num)
    {
        if (num == 2)
        {
            return true;
        }
        else if (num < 2 || num % 2 == 0)
        {
            return false;
        }

        var len = Math.Floor(Math.Sqrt(num));

        for (int i = 3; i <= len; i += 2)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}