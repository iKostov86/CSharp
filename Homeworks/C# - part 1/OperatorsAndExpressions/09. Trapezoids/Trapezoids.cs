using System;

public class Trapezoids
{
    static void Main(string[] args)
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());

        double s = (a + b) / 2 * h;

        Console.WriteLine("{0:F7}", s);
    }
}
