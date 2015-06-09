using System;
using System.Numerics;

class CalculateTheSum
{
    static void Main()
    {
        Console.WriteLine("Please enter N and X (X != 0): ");
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        BigInteger factorial = 1;
        BigInteger power = 1;
        double sum = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            power *= x;
            sum += (double)factorial / (double)power;
        }

        Console.WriteLine(sum);

    }
}
