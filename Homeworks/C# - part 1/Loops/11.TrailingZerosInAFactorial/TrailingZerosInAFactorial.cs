using System;

class TrailingZerosInAFactorial
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int zeros = 0;

        for (int i = 5; i <= n; i *= 5)
        {
            zeros += n / i;
        }

        Console.WriteLine(zeros);
    }
}
