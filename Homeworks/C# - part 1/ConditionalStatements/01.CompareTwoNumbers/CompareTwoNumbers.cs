using System;

class CompareTwoNumbers
{
    static void Main()
    {
        int a = 776;
        int b = 321;
        int temp;

        if (a > b)
        {
            temp = a;
            a = b;
            b = temp;
        }
        Console.WriteLine("a = {0} and b = {1}", a, b);
    }
}
