using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class AmericanPie
{
    static void Main()
    {
        int a = 1;
        int b = 5;
        int c = 2;
        int d = 8;

        int f = (a * d) + (c * b);
        int g = b * d;
        decimal pies = (decimal)f / g;

        if (pies > 1 )
        {
            Console.WriteLine((int)pies);
        }
        else
        {
            Console.WriteLine("{0:F20}", pies);
        }

        Console.WriteLine("{0} / {1}", f, g);
    }
}
