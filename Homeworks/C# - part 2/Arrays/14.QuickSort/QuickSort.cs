using System;

public class QuickSort
{
    internal static void Main()
    {
        int[] arr = GetArray(12);

        PrintArray(arr);

        if (0 < arr.Length)
        {
            SortArray(arr, 0, arr.Length - 1);
        }

        PrintArray(arr);
    }

    public static void SortArray(int[] arr, int left, int right)
    {
        int start = left;
        int end = right;
        int direction = 0;
        int middle = 0;
        int swap = 0;

        while (left < right)
        {
            if (arr[left] < arr[right])
            {
                if (direction == 0)
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }
            else
            {
                if (arr[left] != arr[right])
                {
                    swap = arr[left];
                    arr[left] = arr[right];
                    arr[right] = swap;
                }
                if (direction == 0)
                {
                    direction = 1;
                    left++;
                }
                else
                {
                    direction = 0;
                    right--;
                }
            }

        }

        middle = right;

        if ((start < middle - 1) || (middle + 1 < end))
        {
            SortArray(arr, start, middle - 1);
            SortArray(arr, middle + 1, end);
        }
    }

    public static int[] GetArray(int length)
    {
        int[] arr = new int[length];

        Random rand = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rand.Next(-10, 100);
        }

        return arr;
    }

    public static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("{0} ", arr[i]);
        }

        Console.WriteLine();
    }
}