using System;

public class VariationsKOfN
{
    static public int nCount = 4;
    static public int kCount = 4;
    static public int[] nums = new int[kCount];
    static public bool[] usedNums = new bool[nCount];

    internal static void Main()
    {
        Variations(0);
    }

    public static void Variations(int k)
    {
        if (k >= kCount)
        {
            Print();
            return;
        }

        for (int n = 0; n < nCount; n++)
        {
            if (!usedNums[n])
            {
                usedNums[n] = true;
                nums[k] = n;
                Variations(k + 1);
                usedNums[n] = false;
            }
        }
    }

    static void Print()
    {
        for (int i = 0; i < kCount; i++)
        {
            Console.Write(nums[i] + 1);
        }

        Console.WriteLine();
    }
}