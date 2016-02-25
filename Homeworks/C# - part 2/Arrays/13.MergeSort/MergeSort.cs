using System;

public class MergeSort
{
    static void Main()
    {
        int[] arr = new int[] { 2, 4, 1, 6, 8, 5, 3, 7 };

        MergeSortMethod(arr, 0, arr.Length - 1);
        PrintArray(arr);
    }

    static public void MergeSortMethod(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int middle = (left + right) / 2;

            MergeSortMethod(arr, left, middle);
            MergeSortMethod(arr, (middle + 1), right);
            SplitMethod(arr, left, (middle + 1), right);
        }
    }

    static public void SplitMethod(int[] arr, int left, int middle, int right)
    {
        int[] tempArr = new int[25];
        int tempIndex = left;
        int leftStart = left;
        int leftEnd = (middle - 1);

        while ((left <= leftEnd) && (middle <= right))
        {
            if (arr[left] <= arr[middle])
            {
                tempArr[tempIndex++] = arr[left++];
            }
            else
            {
                tempArr[tempIndex++] = arr[middle++];
            }
        }

        while (left <= leftEnd)
        {
            tempArr[tempIndex++] = arr[left++];
        }

        while (middle <= right)
        {
            tempArr[tempIndex++] = arr[middle++];
        }

        for (int i = leftStart; i <= right; i++)
        {
            arr[i] = tempArr[i];
        }
    }

    public static void PrintArray(int[] arr)
    {
        for (int i = 0, len = arr.Length; i < len; i++)
        {
            Console.Write("{0} ", arr[i]);
        }

        Console.WriteLine();
    }
}
