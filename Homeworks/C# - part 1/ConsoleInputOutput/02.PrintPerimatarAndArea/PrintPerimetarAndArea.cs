using System;

class PrintPerimetarAndArea
{
    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
        Console.WriteLine("Enter a radius of circle: ");
        double r = double.Parse(Console.ReadLine());
        double area = Math.PI * r * r;
        double circumference = Math.PI * 2 * r;
        Console.WriteLine("{0:F5}", area);
        Console.WriteLine("{0:F5}", circumference);
    }
}