using System;

class FiveDivision
{
    static void Main()
    {
        //if (integer1 > integer2)
        //{
        //    int temp = integer1;
        //    integer1 = integer2;
        //    integer2 = temp;
        //}

        Console.WriteLine("Please enter a big number: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter a small number: ");
        int num2 = int.Parse(Console.ReadLine());
        int result = 0;
        for (int i = num2; i <= num1; i++)
        {
            if(i % 5 == 0)
            {
                result++;
            }
        }
        Console.WriteLine();
        Console.WriteLine("The number divisible by 5 are: {0}\n\r", result);
    }
}
