using System;
using System.Collections.Generic;

class MergeSort
{
    static void Main()
    {
        int[] array = new int[] { 2, 4, 1, 6, 8, 5, 3, 7 };

        MergeSortMethod(array, 0, array.Length - 1);

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }

    static public void MergeSortMethod(int[] array, int left, int right)
    {

        if (left < right)
        {
            int middle = (left + right) / 2;
            MergeSortMethod(array, left, middle);
            MergeSortMethod(array, (middle + 1), right);
            SplitMethod(array, left, (middle + 1), right);
        }
    }

    static public void SplitMethod(int[] array, int left, int middle, int right)
    {
        int[] tempArray = new int[25];
        int tempIndex = left;
        int leftStart = left;
        int leftEnd = (middle - 1);

        while ((left <= leftEnd) && (middle <= right))
        {
            if (array[left] <= array[middle])
            {
                tempArray[tempIndex++] = array[left++];
            }
            else
            {
                tempArray[tempIndex++] = array[middle++];
            }
        }

        while (left <= leftEnd)
        {
            tempArray[tempIndex++] = array[left++];
        }

        while (middle <= right)
        {
            tempArray[tempIndex++] = array[middle++];
        }

        for (int i = leftStart; i <= right; i++)
        {
            array[i] = tempArray[i];
        }
    }
}
