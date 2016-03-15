using System;

public class CountNumberAppears
{
    internal static void Main()
    {
        int[] nums = new int[] { 2, 5, 7, 4, 9, 0, 4, 7, 5, 5, 5, 5, 0 };
        Console.WriteLine("Please enter your test number: ");
        int testNum = int.Parse(Console.ReadLine());
        Console.WriteLine(CountAppears(nums, testNum));
    }

    public static int CountAppears(int[] arr, int test)
    {
        int count = 0;
        foreach (var item in arr)
        {
            if (item == test)
            {
                count++;
            }
        }

        return count;
    }
}