using System;

public class FloatOrDouble
{
    static void Main(string[] args)
    {
        // 34.567839023, 12.345, 8923.1234857, 3456.091
        double a = 34.567839023;
        float b = 12.345f;
        double c = 8923.1234857;
        float d = 3456.091f;

        Console.WriteLine(34.567839023 == a);
        Console.WriteLine(12.345f == b);
        Console.WriteLine(8923.1234857 == c);
        Console.WriteLine(3456.091f == d);
    }
}