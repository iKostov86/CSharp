using System;

class BiggestOfThreeNumbers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int biggestNumber = a;

        if (b > a)
        {
            biggestNumber = b;
        }
        else if (c > a)
        {
            biggestNumber = c;
        }
        Console.WriteLine(biggestNumber);
    }
}
