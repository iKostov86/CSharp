using System;

public class ArrayBinSearch
{
    internal static void Main()
    {
        int[] arr = new int[] { 4, 7, 7, 2, 5, 9, 0, 4, 5, 3 };
        int k = 0;
        int kIndex = -1;
        bool result = true;

        do
        {
            Console.WriteLine("Please enter a positive 32 bit integer: ");
            result = int.TryParse(Console.ReadLine(), out k);
        } while (k < 0 || result == false);


        Console.WriteLine("This is the unsorted array: ");
        PrintArray(arr);

        Array.Sort(arr);
        Console.WriteLine("This is the sorted array: ");
        PrintArray(arr);

        kIndex = Array.BinarySearch(arr, k);
        Console.WriteLine("The k index: {0}", kIndex);
        if (kIndex < 0)
        {
            kIndex = (~kIndex);
            Console.WriteLine("The k index: {0}", kIndex);
            if (kIndex > arr.Length)
            {
                Console.WriteLine("There are no elements that are <= {0}.", k);
                return;
            }
            else
            {
                kIndex--;
            }
        }

        Console.WriteLine();
        Console.WriteLine("The largest number in the array which is <= {0} is: {1}.", k, arr[kIndex]);
        Console.WriteLine();
    }

    public static void PrintArray(int[] arr)
    {
        foreach (int item in arr)
        {
            Console.Write("{0} ", item);
        }

        Console.WriteLine();
    }
}
