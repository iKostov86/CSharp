using System;

public class ExchangeVariableValues
{
    static void Main(string[] args)
    {
        int a = 5;
        int b = 10;
        int swap = default(int);

        Console.WriteLine("a = {0}, b = {1};", a, b);
        Console.WriteLine("swap");
        swap = a;
        a = b;
        b = swap;

        Console.WriteLine("a = {0}, b = {1};", a, b);
    }
}
