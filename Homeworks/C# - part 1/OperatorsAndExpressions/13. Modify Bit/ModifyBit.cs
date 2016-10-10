using System;

public class ModifyBit
{
    static void Main(string[] args)
    {
        ulong n = ulong.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        var v = Console.ReadLine();
        ulong nAndMask;

        if (v == "0")
        {
            ulong mask = ~(1ul << p);
            nAndMask = n & mask;
        }
        else
        {
            ulong mask = 1ul << p;
            nAndMask = n | mask;
        }

        Console.WriteLine(nAndMask);
    }
}