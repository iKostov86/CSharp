using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FormatNumber
{
    static void Main()
    {
        int alignment = 15;
        int number = int.Parse(Console.ReadLine());

        // v.1
        Console.WriteLine("{0, 15:D}", number);
        Console.WriteLine("{0, 15:X}", number);
        Console.WriteLine("{0, 15:P}", number / 100.0);
        Console.WriteLine("{0, 15:E}", number);

        // v.2
        Console.WriteLine("{0}", number.ToString("D").PadLeft(15, '.'));
        Console.WriteLine("{0}", number.ToString("X").PadLeft(15, '.'));
        Console.WriteLine("{0}", (number / 100.0).ToString("P").PadLeft(15, '.'));
        Console.WriteLine("{0}", number.ToString("E").PadLeft(15, '.'));

        // v.3
        string decimalAsStr = number.ToString("D");
        Console.WriteLine(new string('.', alignment - decimalAsStr.Length) + decimalAsStr);

        string hexadecimalAsStr = number.ToString("X");
        Console.WriteLine(new string('.', alignment - hexadecimalAsStr.Length) + hexadecimalAsStr);

        string percentAsStr = (number / 100.0).ToString("P");
        Console.WriteLine(new string('.', alignment - percentAsStr.Length) + percentAsStr);

        string scientificAsStr = number.ToString("E");
        Console.WriteLine(new string('.', alignment - scientificAsStr.Length) + scientificAsStr);
    }
}