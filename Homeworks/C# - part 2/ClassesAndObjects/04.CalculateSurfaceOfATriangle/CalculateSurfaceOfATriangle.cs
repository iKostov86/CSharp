using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CalculateSurfaceOfATriangle
{
    static void Main()
    {
        double a = 3;
        double b = 4;
        double c = 5;
        double h = 4;
        double angle = 90;
        angle *= Math.PI / 180;
        SurfaceOfATriangleByGivenSideAndAltitude(a, h);
        SurfaceOfATriangleByGivenAllSides(a, b, c);
        SurfaceOfATriangleByGivenTwoSidesAndAngle(a, b, angle);
    }

    static void SurfaceOfATriangleByGivenSideAndAltitude(double a, double h)
    {
        double area = (a * h) / 2;
        Console.WriteLine(area);
    }

    static void SurfaceOfATriangleByGivenAllSides(double a, double b, double c)
    {
        double halfP = (a + b + c) / 2;
        double area = Math.Sqrt(halfP * (halfP - a) * (halfP - b) * (halfP - c));
        Console.WriteLine(area);
    }

    static void SurfaceOfATriangleByGivenTwoSidesAndAngle(double a, double b, double angle)
    {
        double area = (a * b * Math.Sin(angle)) / 2;
        Console.WriteLine(area);
    }
}