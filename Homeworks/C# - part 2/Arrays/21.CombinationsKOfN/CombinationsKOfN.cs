using System;

public class CombinationsKOfN
{
    static public int nCount = 5;
    static public int kCount = 2;
    static public int[] nums = new int[20];

    internal static void Main()
    {
        Console.WriteLine("C({0}, {1})", nCount, kCount);
        Combinations(1, 0);
    }

    public static void Combinations(int i, int after)
    {
        if (i > kCount)
        {
            return;
        }

        for (int j = after + 1; j <= nCount; j++)
        {
            nums[i - 1] = j;
            if (i == kCount)
            {
                Print(i);
            }

            Combinations(i + 1, j);
        }
    }

    static void Print(int length)
    {
        for (int i = 0; i < length; i++)
        {
            Console.Write(nums[i]);
        }

        Console.WriteLine();
    }
}
