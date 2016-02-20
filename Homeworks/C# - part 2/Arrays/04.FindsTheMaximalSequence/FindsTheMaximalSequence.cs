using System;

class FindsTheMaximalSequence
{
    static void Main()
    {
        //int[] arr = new int[] { 2, 2, 7, 2, 2, 2, 7, 9, 9, 9, 9, 9 };
        //int[] arr = new int[] { 0, 8, 6, 6, 3 };
        int[] arr = GetRandomIntArray();
        int bestIndex = 0;
        int bestReps = 1;
        int currentReps = 1;

        Console.WriteLine("The array is: ");
        PrintSequence(arr, 0, arr.Length);

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] == arr[i - 1])
            {
                if (i == arr.Length - 1 && currentReps > bestReps)
                {
                    bestIndex = i - currentReps;
                    bestReps = currentReps + 1;
                }
                else
                {
                    currentReps++;
                }
            }
            else
            {
                if (currentReps > bestReps)
                {
                    bestIndex = i - currentReps;
                    bestReps = currentReps;
                }
                currentReps = 1;
            }
        }

        Console.WriteLine("The maximal sequence is: ");
        PrintSequence(arr, bestIndex, bestReps);
    }

    public static void PrintSequence(int[] arr, int index, int reps)
    {
        for (int i = index; i < index + reps; i++)
        {
            Console.Write("{0} ", arr[i]);
        }

        Console.WriteLine();
    }

    public static int[] GetRandomIntArray()
    {
        Console.WriteLine("Enter an array dimension: ");
        int len = int.Parse(Console.ReadLine());
        int[] arr = new int[len];

        Random rnd = new Random();

        for (int i = 0; i < len; i++)
        {
            arr[i] = rnd.Next(0, 11);
        }

        return arr;
    }
}
