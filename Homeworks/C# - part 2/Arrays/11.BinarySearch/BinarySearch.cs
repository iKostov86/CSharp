using System;

public class BinarySearch
{
    internal static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int[] arr = new int[] { 2, 3, 7, 44, 0, 5, 17 };

        Array.Sort(arr);
        int index = Array.BinarySearch(arr, number);

        PrintIndex(number, index);
    }

    public static int? SearchIndex(int[] arr, int num)
    {
        int? index = null;
        int len = arr.Length;
        int i = len / 2;

        while (index == null)
        {
            int current = arr[i];

            if (current > num)
            {
                i = i / 2;
            }
            else if (current < num)
            {
                i = (3 * i) / 2;
            }
            else
            {
                index = i;
            }
        }

        return index;
    }

    public static void PrintIndex(int num, int index)
    {
        Console.WriteLine("Index of {0} is {1}.", num, index);
    }
}
