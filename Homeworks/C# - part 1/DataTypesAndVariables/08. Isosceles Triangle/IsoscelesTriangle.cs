using System;
using System.Linq;
using System.Text;

public class IsoscelesTriangle
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        char symbol = '©';
        char space = ' ';

        Console.WriteLine(new string(space, 3) + symbol + new string(space, 3));
        Console.WriteLine(new string(space, 2) + symbol + space + symbol + new string(space, 2));
        Console.WriteLine(space.ToString() + symbol + new string(space, 3) + symbol + space);
        Console.WriteLine(string.Join(space.ToString(), Enumerable.Repeat(symbol, 4).ToArray()));
    }
}
