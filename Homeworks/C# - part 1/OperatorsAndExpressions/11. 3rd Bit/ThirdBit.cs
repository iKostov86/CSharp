using System;

public class ThirdBit
{
    static void Main(string[] args)
    {
        uint num = uint.Parse(Console.ReadLine());
        int p = 3;
        uint mask = 1u << p;
        uint numAndMask = num & mask;
        uint bit = numAndMask >> p;

        Console.WriteLine(bit);
    }
}
