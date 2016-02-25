using System;

class MaxSubsequence
{
    static void Main()
    {
        /*** O(N) ***/

        //int[] arr = new int[] { 2, 3, -5, -1, 2, -1, 6, 4, -8, 8 };
        int[] arr = new int[] { 2, 3, 4, -12, 2, 4, -3 };
        int sum = 0;
        int bestSum = 0;
        int start = 0;
        int end = 0;
        int count = 0;

        for (int i = 0, len = arr.Length; i < len; i++)
        {
            sum += arr[i];
            count++;

            if (sum > bestSum)
            {
                bestSum = sum;
                end = i + 1;
                start = end - count;
            }
            if (sum < 0)
            {
                sum = 0;
                count = 0;
            }
        }

        PrintSequence(arr, start, end);

        /*** O(N2) ***/

        ////int[] arr = new int[] { 1, 4, 0, 5, 0, 11, -1 };
        ////int[] arr = new int[] { 2, -1, 6, 4, -13, 32, 3, -1, -1, -5, 8 };
        ////int[] arr = new int[] { 2, 3, -5, -1, 2, -1, 6, 4, -8, 9 };
        //int[] arr = new int[] { 2, 3, 4, -12, 2, 43, -3 };
        //int bestSum = 0;
        //int start = 0;
        //int end = 0;

        //for (int i = 0, len = arr.Length; i < len; i++)
        //{
        //    int sum = 0;
        //    for (int j = i; j < len; j++)
        //    {
        //        sum += arr[j];
        //        if (sum > bestSum)
        //        {
        //            bestSum = sum;
        //            start = i;
        //            end = j + 1;
        //        }
        //    }
        //}

        //PrintSequence(arr, start, end);
    }

    public static void PrintSequence(int[] arr, int start, int end)
    {
        for (int i = start; i < end; i++)
        {
            Console.Write("{0} ", arr[i]);
        }

        Console.WriteLine();
    }
}
