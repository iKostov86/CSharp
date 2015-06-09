using System;

class QuadraticEquation
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double d = Math.Sqrt(b * b - 4 * a * c);
        double x1 = (-b + d) / 2 * a;
        double x2 = (-b - d) / 2 * a;
        double x0 = (-b) / 2 * a;

        if (d > 0)
        {
            Console.WriteLine("The quadratic equation has two real solutions: x1 = {0}, x2 = {1}.", x1, x2);
        }
        else if (d == 0)
        {
            Console.WriteLine("The quadratic equation has one real solution: x1 = {0}.", x0);
        }
        else
        {
            Console.WriteLine("The quadratic equation hasn't real solutions.");
        }
    }
}
