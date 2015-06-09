using System;

class EuclideanAlgorithm
{
    static void Main()
    {
        Console.WriteLine("Please enter A and B: (b != 0)");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int multiplier = new int();
        int addend = 1;

        if (b == 0 )
        {
            Console.WriteLine("The greatest common divisor(gcd) is {0}", a);
            return;
        }

        while (addend > 0)
        {
            multiplier = a / b;
            addend = a % b;
            a = b;
            b = addend;
        }

        Console.WriteLine(a);
    }
}
