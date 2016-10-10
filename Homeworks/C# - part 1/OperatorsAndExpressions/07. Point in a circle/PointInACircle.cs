using System;

public class PointInACircle
{
    static void Main(string[] args)
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double circleR = 2;
        double distance = Math.Sqrt(x * x + y * y);
        string result = "yes";

        if (distance > circleR * circleR)
        {
            result = "no";
        }

        Console.WriteLine("{0} {1:F2}", result, distance);
    }
}
