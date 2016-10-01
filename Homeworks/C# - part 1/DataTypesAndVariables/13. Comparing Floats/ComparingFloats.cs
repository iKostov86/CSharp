using System;

public class ComparingFloats
{
    static void Main(string[] args)
    {
        double eps = 0.000001;
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        double difference = Math.Abs(a - b);
        bool result = true;

        if (difference > eps)
        {
            result = false;
        }

        Console.WriteLine(result.ToString().ToLower());
    }
}
