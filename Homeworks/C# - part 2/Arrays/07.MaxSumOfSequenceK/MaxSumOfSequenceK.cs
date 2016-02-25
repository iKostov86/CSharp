using System;

class MaxSumOfSequenceK
{
    static void Main()
    {
        //int n = int.Parse(Console.ReadLine());
        //int k = int.Parse(Console.ReadLine());
        //int[] arr = new int[n];
        int k = 4;
        int[] arr = new int[] { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
        int sum = 0;
        int bestSum = 0;
        int index = 0;

        //FillArray(arr);

        for (int i = 0; i < k; i++)
        {
            sum += arr[i];
        }

        bestSum = sum;
        for (int i = k; i < arr.Length; i++)
        {
            sum = sum - arr[i - k] + arr[i];

            if (sum > bestSum)
            {
                bestSum = sum;
                index = i - k + 1;
            }
        }

        // input                                result
        // 2, 3, -6, -1, 2, -1, 6, 4, -8, 8     2, -1, 6, 4
        PrintSequence(arr, index, k);
    }

    public static void FillArray(int[] arr)
    {
        for (int i = 0, len = arr.Length; i < len; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
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