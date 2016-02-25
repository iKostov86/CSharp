using System;

public class PermutationsOfN
{
    static public int nCount = 3;
    static public int kCount = 2;
    static public int[] nums = new int[kCount];
    static public bool[] usedNums = new bool[nCount];

    /***   n! / (n - k)!   ***/

    internal static void Main()
    {
        Permute(0);
    }

    public static void Permute(int k)
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
                /* if */
                Permute(k + 1);
                usedNums[n] = false;
            }
        }
    }

    public static void Print()
    {
        for (int i = 0; i < kCount; i++)
        {
            Console.Write("{0}", (nums[i] + 1));
        }

        Console.WriteLine();
    }
}
