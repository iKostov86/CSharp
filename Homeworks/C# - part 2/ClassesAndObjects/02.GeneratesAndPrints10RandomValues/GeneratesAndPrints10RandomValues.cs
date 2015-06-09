using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class GeneratesAndPrints10RandomValues
{
    static void Main()
    {
        Random rnd = new Random();
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(rnd.Next(100, 201));
        }
    }
}
