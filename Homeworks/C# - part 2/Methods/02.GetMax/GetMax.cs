using System;

class GetMax
{
    static void Main()
    {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());
        num2 = GetMaxMethod(num2, num3);
        num1 = GetMaxMethod(num1, num2);
        Console.WriteLine();
        Console.WriteLine(num1);
    }

    static int GetMaxMethod(int numA, int numB)
    {
        if (numA > numB)
        {
            return numA;
        }

        return numB;

        //return numA > numB ? numA : numB;
    }
}
