using System;
using System.Collections.Generic;

class RemovingSort
{
    static void Main()
    {
        // int[] nums = new int[] { 10, 9, 6, 2, 7, 4, 7, 6, 5, 8, 4};
        int[] nums = new int[] { 6, 1, 4, 3, 0, 3, 6, 4, 5 };
        //int[] nums = new int[] { 4, 3 ,4, 1, 2};
        int len = nums.Length;

        int[] sortedNums = new int[len];
        int bestIndex = 0;

        for (int i = 0; i < len; i++)
        {
            int[] arr = new int[len];
            int newIndex = 0;
            arr[newIndex] = nums[i];

            for (int j = i; j < len - 1; j++)
            {
                if (nums[j + 1] > arr[newIndex])
                {
                    newIndex++;
                    arr[newIndex] = nums[j + 1];
                }
                else if ((newIndex > 0) && (nums[j + 1] == arr[newIndex]))
                {
                    newIndex++;
                    arr[newIndex] = nums[j + 1];
                }
                else if((newIndex > 0) && (nums[j + 1] > arr[newIndex - 1]))
                {
                    arr[newIndex] = nums[j + 1];
                }
            }
            if (newIndex > bestIndex)
            {
                bestIndex = newIndex;
                for (int k = 0; k < arr.Length; k++)
                {
                    sortedNums[k] = arr[k];
                }
            }
            else if((newIndex == bestIndex) && (arr[0] < sortedNums[0]))
            {
                for (int k = 0; k < arr.Length; k++)
                {
                    sortedNums[k] = arr[k];
                }
            }
        }

        PrintNumbers(sortedNums, bestIndex);
    }

    public static void PrintNumbers(int[] arr, int index)
    {
        for (int i = 0; i <= index; i++)
        {
            Console.Write("{0} ", arr[i]);
        }

        Console.WriteLine();
    }
}
