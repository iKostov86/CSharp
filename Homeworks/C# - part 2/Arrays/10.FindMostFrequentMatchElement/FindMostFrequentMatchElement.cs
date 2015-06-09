using System;

class FindMostFrequentMatchElement
{
    static void Main()
    {
        int[] array = new int[] { 1, 4, 4, 5, 4, 11, -11 };
        Array.Sort(array);
        int bestNum = array[0];
        int bestReps = 1;
        int tempReps = 1;
        
        //for (int i = 0; i < array.Length; i++)
        //{
        //    Console.WriteLine(array[i]);
        //}

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i - 1] == array[i])
            {
                tempReps++;
            }
            else
            {
                if (tempReps > bestReps)
                {
                    bestReps = tempReps;
                    bestNum = array[i - 1];
                }
                tempReps = 1;
            }
        }

        Console.WriteLine(bestNum);
        Console.WriteLine(bestReps);

        //int bestNum = int.MinValue;
        //int tempNum = int.MinValue;
        //int bestReps = 1;
        //int tempReps = 1;

        //for (int i = 0; i < array.Length; i++)
        //{
        //    tempNum = array[i];
        //    tempReps = 1;
        //    for (int j = i + 1; j < array.Length; j++)
        //    {
        //        if (tempNum == array[j])
        //        {
        //            tempReps++;
        //            array[j] = int.MinValue;
        //        }
        //    }
        //    if (tempReps > bestReps)
        //    {
        //        bestNum = tempNum;
        //        bestReps = tempReps;
        //    }
        //}
        //Console.WriteLine(bestNum);


    }
}
