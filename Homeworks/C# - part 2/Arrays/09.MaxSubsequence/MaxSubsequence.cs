using System;

class MaxSubsequence
{
    static void Main()
    {
        /*** O(N) ***/

        int[] array = new int[] { 2, 3, -5, -1, 2, -1, 6, 4, -8, 9 };
        int bestSum = 0;
        int tempSum = 0;
        int startIndex = 0;
        int endIndex = 0;

        for (int i = 0; i < array.Length; i++)
        {
            tempSum += array[i];

            if (tempSum > bestSum)
            {
                bestSum = tempSum;
                endIndex = i + 1;
            }
            if (tempSum < 0)
            {
                tempSum = 0;
                startIndex = i + 1;
            }
        }
        Console.WriteLine(bestSum);
        for (int i = startIndex; i < endIndex; i++)
        {
            Console.WriteLine(array[i]);
        }

        /*** O(N2) ***/

        //int[] array = new int[] { 1, 4, 0, 5, 0, 11, -1 };
        //int bestSum = int.MinValue;
        //int tempSum = 0;
        //int startIndex = 0;
        //int endIndex = 0;

        //for (int i = 0; i < array.Length; i++)
        //{
        //    tempSum = 0;
        //    for (int j = i; j < array.Length; j++)
        //    {
        //        tempSum += array[j];
        //        if (tempSum > bestSum)
        //        {
        //            bestSum = tempSum;
        //            startIndex = i;
        //            endIndex = j;
        //        }
        //    }
        //}
        //for (int i = startIndex; i < endIndex + 1; i++)
        //{
        //    Console.WriteLine(array[i]);
        //}
    }
}
