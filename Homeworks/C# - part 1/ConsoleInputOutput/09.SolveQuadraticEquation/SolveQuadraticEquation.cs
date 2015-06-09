using System;

class SolveQuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Please enter a, b and c of quadratic equation: ");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());
        double D = b * b - 4 * a * c;
        double root1, root2;

        if (D > 0)
        {
            root1 = (-b + (Math.Sqrt(D))) / 2 * a;
            root2 = (-b - (Math.Sqrt(D))) / 2 * a;
            Console.WriteLine("The roots are: {0} and {1}.", root1, root2);
        }
        else
        {
            if (D < 0)
            {
                Console.WriteLine("No real roots.");
            }
            else                            //identifier = 0
            {
                root1 = -b / 2 * a;
                Console.WriteLine("The root is {0}.", root1);
            }
        }
    }
}
