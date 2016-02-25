using System;
using System.Collections.Generic;

class SubsetS
{
    static void Main()
    {
        int[] nums = new int[] { 1, 2, 4, 6, 8, 9, 0, 3, 5, 7 };
        int len = nums.Length;
        int givenSum = int.Parse(Console.ReadLine());
        int subsetsCombination = (int)Math.Pow(2, len);

        for (int i = 1; i < subsetsCombination; i++)
        {
            int sum = 0;
            int subsetBit = i;
            List<int> subset = new List<int>();

            for (int j = 0; j < len; j++)
            {
                if (subsetBit % 2 == 1)
                {
                    sum += nums[j];
                    subset.Add(nums[j]);
                }

                subsetBit = subsetBit >> 1;
            }

            if (sum == givenSum)
            {
                PrintSubset(subset);
                return;
            }
        }

        Console.WriteLine("There don't exist subset of the elements of the array that has sum {0}.", givenSum);
    }

    public static void PrintSubset(List<int> subset)
    {
        for (int i = 0, len = subset.Count; i < len; i++)
        {
            Console.Write("{0} ", subset[i]);
        }

        Console.WriteLine();
    }
}
