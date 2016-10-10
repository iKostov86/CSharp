using System;

public class BitExchange
{
    static void Main(string[] args)
    {
        uint n = uint.Parse(Console.ReadLine());
        //int[] arr = new int[] { 3, 4, 5, 24, 25, 26 };
        int[] rightArr = new int[] { 3, 4, 5 };
        int[] leftArr = new int[] { 24, 25, 26 };

        for (int i = 0, len = rightArr.Length; i < len; i++)
        {
            int rightPos = rightArr[i];
            uint rightMask = 1u << rightPos;
            uint rightBit = (n & rightMask) >> rightPos;

            int leftPos = leftArr[i];
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
