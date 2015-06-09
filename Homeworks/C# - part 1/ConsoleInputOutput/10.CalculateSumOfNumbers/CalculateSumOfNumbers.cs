using System;

class CalculateSumOfNumbers
{
    static void Main()
    {
        int n = Int32.Parse(Console.ReadLine());
        int buf = 0;
        int temp = 0;

        for (int i = 0; i < n; i++)
        {
            temp = Int32.Parse(Console.ReadLine());
            buf += temp;
        }

        Console.WriteLine(buf);
    }
}
