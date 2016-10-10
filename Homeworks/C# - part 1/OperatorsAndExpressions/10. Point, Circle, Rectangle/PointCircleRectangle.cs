using System;

public class PointCircleRectangle
{
    static void Main(string[] args)
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        bool inCircle = true;
        bool inRectangle = true;
        string result = string.Empty;

        var circleX = 1;
        var circleY = 1;
        var circleR = 1.5;
        var rectTop = 1;
        var rectLeft = -1;
        var rectWidth = 6;
        var rectHeight = 2;
        var distance = Math.Pow((x - circleX), 2) + Math.Pow((y - circleY), 2);

        if (distance > circleR * circleR)
        {
            inCircle = false;
        }

        if (x < rectLeft || x > (rectLeft + rectWidth) ||
            y < (rectTop - rectHeight) || y > rectTop)
        {
            inRectangle = false;
        }

        result = (inCircle ? "inside" : "outside") + " circle " +
            (inRectangle ? "inside" : "outside") + " rectangle";

        Console.WriteLine(result);
    }
}