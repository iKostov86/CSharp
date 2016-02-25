using System;

class FindMostFrequentMatchElement
{
    static void Main()
    {
        //int[] arr = new int[] { 1, 4, 4, 5, 4, 11, -11 };
        //Array.Sort(arr);

        //int reps = 1;
        //int bestReps = 1;
        //int bestNum = arr[0];

        //for (int i = 1, len = arr.Length; i < len; i++)
        //{
        //    if (arr[i] == arr[i - 1])
        //    {
        //        reps++;
        //    }
        //    else
        //    {
        //        if (reps > bestReps)
        //        {
        //            bestReps = reps;
        //            bestNum = arr[i - 1];
        //        }

        //        reps = 1;
        //    }
        //}

        //Console.WriteLine("The most common number is: {0}, it occurs {1} time.", bestNum, bestReps);

        int?[] arr = new int?[] { 1, 4, 4, 5, 4, 11, -11 };
        int reps = 1;
        int bestReps = 1;
        int? num = arr[0];
        int? bestNum = num;

        for (int i = 0, len = arr.Length; i < len; i++)
        {
            reps = 1;
            num = arr[i];

            if (num != null)
            {
                for (int j = i + 1; j < len; j++)
                {
                    if (num == arr[j])
                    {
                        reps++;
                        arr[j] = null;
                    }
                }

                if (reps > bestReps)
                {
                    bestReps = reps;
                    bestNum = num;
                }
            }
        }

        Console.WriteLine("The most common number is: {0}, it occurs {1} time.", bestNum, bestReps);
    }
}
