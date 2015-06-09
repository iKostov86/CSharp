using System;

class SelectionSortArray
{
    static void Main()
    {
        int[] array = new int[] { 5, 7, 9, 46, 77, 79, 1, 3 };
        int temp = 0;

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] > array[j])
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}

