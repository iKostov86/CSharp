using System;
using System.Text;

class PrintThreeNumbers
{
    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
        int a = 252;
        double b = 200;
        double c = -300;
        Console.Write(String.Format("{0:X}", a).PadRight(10));
        Console.Write("|");
        Console.Write(String.Format("{0, -10:F2}", b));
        Console.Write("|");
        string output = String.Format("{0:F2}", c).PadRight(10);
        Console.WriteLine(output);

        //string outputValue = c.ToString("F2").PadRight(10);
        //Console.WriteLine(outputValue);

    }
}

