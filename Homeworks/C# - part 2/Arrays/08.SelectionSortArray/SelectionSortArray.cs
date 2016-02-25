using System;

class SelectionSortArray
{
    static void Main()
    {
        int[] arr = new int[] { 5, 7, 9, 46, 77, 79, 1, 3 };

        for (int i = 0, len = arr.Length; i < len; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] > arr[j])
                {
                    int current = arr[i];
                    arr[i] = arr[j];
                    arr[j] = current;
                }
            }
        }

        PrintArray(arr);
    }

    public static void PrintArray(int[] arr)
    {
        foreach (var element in arr)
        {
            Console.WriteLine(element);
        }
    }
}