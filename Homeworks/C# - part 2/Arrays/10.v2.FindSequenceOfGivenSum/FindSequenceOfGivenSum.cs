using System;

class FindSequenceOfGivenSum
{
    static void Main()
    {
        int[] arr = new int[] { 4, 3, 1, 4, 2, 5, 8};
        int givenSum = int.Parse(Console.ReadLine());
        int i = 0;
        int len = arr.Length;
        int sum = 0;
        int count = 0;

        while (i < len)
        {
            sum += arr[i];
            count++;

            if (sum == givenSum)
            {
                PrintSequence(arr, i - count + 1, i + 1);
                return;
            }
            else if (sum > givenSum)
            {
                i = i - count + 2;
                sum = 0;
                count = 0;
            }
            else
            {
                i++;
            }
        }

        //for (int i = 0, len = arr.Length; i < len; i++)
        //{
        //    sum += arr[i];
        //    count++;

        //    if (sum == givenSum)
        //    {
        //        PrintSequence(arr, i - count + 1, i + 1);
        //        return;
        //    }
        //    else if (sum > givenSum)
        //    {
        //        i = i - count + 1;
        //        sum = 0;
        //        count = 0;
        //    }
        //}

        //for (int i = 0, len = arr.Length; i < len; i++)
        //{
        //    int sum = 0;
        //    int index = i;
        //    int count = 0;

        //    for (int j = i; j < len; j++)
        //    {
        //        sum += arr[j];
        //        count++;
        //        if (sum == givenSum)
        //        {
        //            PrintSequence(arr, index, index + count);
        //            return;
        //        }
        //        else if(sum > givenSum)
        //        {
        //            break;
        //        }

        //    }
        //}

        Console.WriteLine("The given sum isn't found");
    }

    public static void PrintSequence(int[] arr, int start, int end)
    {
        for (int i = start; i < end; i++)
        {
            Console.Write(arr[i]);
        }

        Console.WriteLine();
    }
}
