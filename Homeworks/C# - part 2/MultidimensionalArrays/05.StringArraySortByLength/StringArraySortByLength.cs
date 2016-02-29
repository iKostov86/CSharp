using System;

public class StringArraySortByLength
{
    /*** using quick sort implementation ***/

    //internal static void Main()
    //{
    //    string[] arr = new string[] { "", "H", "Hello, my friend", "Hi", "Hello", "Hello!", "E tva e nai dylgoto izrechenie sha znaish!" };

    //    if (0 < arr.Length)
    //    {
    //        QuickSort(arr, 0, arr.Length - 1);
    //    }

    //    PrintArray(arr);
    //}

    //public static void QuickSort(string[] arr, int left, int right)
    //{
    //    int start = left;
    //    int end = right;
    //    int direction = 0;
    //    int middle = 0;
    //    string swap = string.Empty;

    //    while (left < right)
    //    {
    //        if (arr[left].Length < arr[right].Length)
    //        {
    //            if (direction == 0)
    //            {
    //                right--;
    //            }
    //            else
    //            {
    //                left++;
    //            }
    //        }
    //        else
    //        {
    //            if (arr[left].Length != arr[right].Length)
    //            {
    //                swap = arr[left];
    //                arr[left] = arr[right];
    //                arr[right] = swap;
    //            }
    //            if (direction == 0)
    //            {
    //                direction = 1;
    //                left++;
    //            }
    //            else
    //            {
    //                direction = 0;
    //                right--;
    //            }
    //        }
    //    }

    //    middle = right;

    //    if ((start < middle - 1) || (middle + 1 < end))
    //    {
    //        QuickSort(arr, start, middle - 1);
    //        QuickSort(arr, middle + 1, end);
    //    }
    //}

    /*** using Lambda expressions ***/

    internal static void Main()
    {
        Console.WriteLine("Please enter a size of the array: ");
        int n = int.Parse(Console.ReadLine());
        string[] arr = new string[n];

        FillArray(arr);
        PrintArray(arr);
        Array.Sort(arr, (x, y) => x.Length.CompareTo(y.Length));
        PrintArray(arr);
    }

    public static void FillArray(string[] arr)
    {
        for (int i = 0, len = arr.Length; i < len; i++)
        {
            Console.Write("Enter element[{0}] = ", i);
            arr[i] = Console.ReadLine();
        }
    }

    public static void PrintArray(string[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write("{0} ", item);
        }

        Console.WriteLine();
    }
}
