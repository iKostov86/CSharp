using System;

class ShipDamage
{
    static int shipX1 = int.Parse(Console.ReadLine()),
               shipY1 = int.Parse(Console.ReadLine()),
               shipX2 = int.Parse(Console.ReadLine()),
               shipY2 = int.Parse(Console.ReadLine()),
               horizY = int.Parse(Console.ReadLine()),
               shotX1 = int.Parse(Console.ReadLine()),
               shotY1 = int.Parse(Console.ReadLine()),
               shotX2 = int.Parse(Console.ReadLine()),
               shotY2 = int.Parse(Console.ReadLine()),
               shotX3 = int.Parse(Console.ReadLine()),
               shotY3 = int.Parse(Console.ReadLine());

    static int sum = 0;

    static void Method(int shotX, int shotY, int bottom, int top, int left, int right)
    {
        //Inside ship

        if ((shotY > bottom && shotY < top) && (shotX > left && shotX < right))
        {
            sum += 100;
        }

        //Edge of ship

        if ((shotY == bottom || shotY == top) && (shotX == left || shotX == right))
        {
            sum += 25;
        }

        //In middle of bottom, top, left or right

        if ((shotY == bottom || shotY == top) && (shotX > left && shotX < right) ||
            ((shotY > bottom && shotY < top) && (shotX == left || shotX == right)))
        {
            sum += 50;
        }

    }

    static void Main()
    {
        shotY1 = 2 * horizY - shotY1;
        shotY2 = 2 * horizY - shotY2;
        shotY3 = 2 * horizY - shotY3;


        int top = Math.Max(shipY1, shipY2),
               left = Math.Min(shipX1, shipX2),
               right = Math.Max(shipX1, shipX2),
               bottom = Math.Min(shipY1, shipY2);


        Method(shotX1, shotY1, bottom, top, left, right);
        Method(shotX2, shotY2, bottom, top, left, right);
        Method(shotX3, shotY3, bottom, top, left, right);

        Console.WriteLine(sum + "%");
    }
}
