using System;
using System.Linq;

public class MaximalElementAndSortArray
{
    internal static void Main()
    {
        string input = Console.ReadLine();
        int[] nums = ConvertStrToIntArray(input);
        int maxElement = GetMaxElement(nums, 0);

        Console.WriteLine("Max element in that array is: {0}.", maxElement);
        nums = Sort(nums, true);

        Console.WriteLine("This is the sorted array: ");
        PrintArray(nums);
    }

    public static int[] ConvertStrToIntArray(string input)
    {
        string[] substr = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        int[] nums = new int[substr.Length];

        for (int i = 0, len = substr.Length; i < len; i++)
        {
            nums[i] = int.Parse(substr[i]);
        }

        return nums;
    }

    public static int GetMaxElement(int[] arr, int index)
    {
        int maxElement = arr[index];

        for (int i = index + 1, len = arr.Length; i < len; i++)
        {
            if (arr[i] > maxElement)
            {
                maxElement = arr[i];
            }
        }

        return maxElement;
    }

    public static int[] Sort(int[] nums, bool isAscending)
    {
        int num = 0;
        int maxIndex = 0;
        int maxElement = 0;

        for (int i = 0, len = nums.Length; i < len; i++)
        {
            maxElement = GetMaxElement(nums, i);

            for (int j = i; j < len; j++)
            {
                if (nums[j] == maxElement)
                {
                    maxIndex = j;
                }
            }

            num = nums[i];
            nums[i] = nums[maxIndex];
            nums[maxIndex] = num;
        }

        return isAscending ? nums : nums.Reverse().ToArray();
    }

    public static void PrintArray(int[] nums)
    {
        int len = nums.Length;

        for (int i = len - 1; i >= 0; i--)
        {
            Console.Write(nums[i]);
            if (i != 0)
            {
                Console.Write(", ");
            }
            else
            {
                Console.Write(".");
            }
        }

        Console.WriteLine();
    }
}