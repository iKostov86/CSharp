using System;
using System.Collections.Generic;

class SubsetS
{
    static void Main()
    {
        int givenK = int.Parse(Console.ReadLine());
        int givenSum = int.Parse(Console.ReadLine());
        int[] nums = new int[] { 1, 2, 4, 6, 8, 9, 0, 3, 5, 7 };
        int len = nums.Length;
        int subsetsCombination = (int)Math.Pow(2, len);

        for (int i = 1; i < subsetsCombination; i++)
        {
            List<int> subset = new List<int>();
            int sum = 0;
            int subsetBit = i;
            int subsetCount = subset.Count;
            int j = 0;

            while (j < len && subsetCount < givenK)
            {
                if (subsetBit % 2 == 1)
                {
                    sum += nums[j];
                    subset.Add(nums[j]);
                }
                subsetBit = subsetBit >> 1;
                j++;
            }
            if (sum == givenSum && subsetCount == givenK)
            {
                PrintSubset(subset);
                return;
            }
        }

        Console.WriteLine("There don't exist subset of the elements of the array that has sum {0}.", givenSum);
    }

    public static void PrintSubset(List<int> subset)
    {
        for (int i = 0, count = subset.Count; i < count; i++)
        {
            Console.Write("{0} ", subset[i]);
        }

        Console.WriteLine();
    }
}
