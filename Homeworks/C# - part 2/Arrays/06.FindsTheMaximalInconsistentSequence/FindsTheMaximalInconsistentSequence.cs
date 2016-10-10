using System;

public class FindsTheMaximalInconsistentSequence
{
    internal static void Main(string[] args)
    {
        Console.WriteLine("Enter a K: ");
        int k = int.Parse(Console.ReadLine());
        int[] arr = new int[] { 9, 6, 2, 7, 4, 7, 6, 5, 8, 4 };
        int index = arr.Length - k;

        Array.Sort(arr);
        PrintArray(arr, 0);
        PrintArray(arr, index);

        Console.WriteLine(GetMaximalSum(arr, index));
    }

    public static int GetMaximalSum(int[] arr, int index)
    {
        int sum = 0;

        for (int i = index; i < arr.Length; i++)
        {
            sum += arr[i];
        }

        return sum;
    }

    public static void PrintArray(int[] arr, int index)
    {
        for (int i = index; i < arr.Length; i++)
        {
            Console.Write("{0} ", arr[i]);
        }

        Console.WriteLine();
    }
}

