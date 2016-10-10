using System;

public class MoonGravity
{
    static void Main(string[] args)
    {
        float weight = float.Parse(Console.ReadLine());

        float moonWeight = 0.17f * weight;

        Console.WriteLine(string.Format("{0:F3}", moonWeight));
    }
}