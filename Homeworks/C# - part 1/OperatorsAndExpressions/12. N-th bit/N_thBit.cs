using System;

public class N_thBit
{
    static void Main(string[] args)
    {
        long p = long.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        long mask = 1L << n;
        long numAndMask = p & mask;
        long bit = numAndMask >> n;

        Console.WriteLine(bit);
    }
}