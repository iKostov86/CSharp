using System;

public class FindsTheMaximalConsistentSequence
{
    internal static void Main(string[] args)
    {
        int k = 3;
        int[] arr = new int[] { 9, 6, 2, 7, 4, 7, 6, 5, 8, 4 };
        int bestIndex = 0;
        int bestSum = 0;
        int sum = 0;
        int len = arr.Length - k;

        for (int i = 0; i < len; i++)
        {
            for (int j = 0; j < k; j++)
            {
                sum += arr[i + j];
            }

            if (sum > bestSum)
            {
                bestIndex = i;
                bestSum = sum;
            }

            sum = 0;
        }

        PrintSequence(arr, bestIndex, k);
        Console.WriteLine(bestSum);
    }

    public static void PrintSequence(int[] arr, int index, int k)
    {
        for (int i = index; i < index + k; i++)
        {
            Console.Write("{0} ", arr[i]);
        }

        Console.WriteLine();
    }
}
