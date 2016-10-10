using System;

public class BitSwap
{
    static void Main(string[] args)
    {
        uint n = uint.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int q = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        for (int i = 0; i < k; i++)
        {
            int rightPos = p + i;
            uint rightMask = 1u << rightPos;
            uint rightBit = (n & rightMask) >> rightPos;

            int leftPos = q + i;
            uint leftMask = 1u << leftPos;
            uint leftBit = (n & leftMask) >> leftPos;

            uint swapBit = leftBit;

            if (rightBit == 0)
            {
                leftMask = ~leftMask;
                n &= leftMask;
            }
            else
            {
                n |= leftMask;
            }

            if (swapBit == 0)
            {
                rightMask = ~rightMask;
                n &= rightMask;
            }
            else
            {
                n |= rightMask;
            }
        }

        Console.WriteLine(n);
    }
}