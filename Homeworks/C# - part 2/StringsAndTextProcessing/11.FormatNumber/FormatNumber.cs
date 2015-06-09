using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FormatNumber
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        //v.1

        Console.WriteLine("{0, 15:D4}", number);
        Console.WriteLine("{0, 15:X4}", number);
        Console.WriteLine("{0, 15:P4}", number / 100.0);
        Console.WriteLine("{0, 15:E4}", number);

        //v.2

        Console.WriteLine("{0}", number.ToString("D4").PadLeft(15, '.'));
        Console.WriteLine("{0}", number.ToString("X4").PadLeft(15, '.'));
        Console.WriteLine("{0}", (number / 100.0).ToString("P4").PadLeft(15, '.'));
        Console.WriteLine("{0}", number.ToString("E4").PadLeft(15, '.'));
    }
}