using System;

class QuickSort
{
    static int[] array = new int[12];

    static void Main()
    {
        Random rand = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(-10, 100);
            Console.WriteLine(array[i]);
        }
        Console.WriteLine();

        if (0 < array.Length)
        {
            QuickSortMethod(0, array.Length - 1);
        }
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
        Console.WriteLine();
    }

    static public void QuickSortMethod(int left, int right)
    {
        int start = left;
        int end = right;
        int direction = 0;
        int middle = 0;
        int swapTemp = 0;

        while (left < right)
        {
            if (array[left] < array[right])
            {
                if (direction == 0)
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }
            else
            {
                if (array[left] != array[right])
                {
                    swapTemp = array[left];
                    array[left] = array[right];
                    array[right] = swapTemp;
                }
                if (direction == 0)
                {
                    direction = 1;
                    left++;
                }
                else
                {
                    direction = 0;
                    right--;
                }
            }

        }

        middle = right;

        if ((start < middle - 1) || (middle + 1 < end))
        {
            QuickSortMethod(start, middle - 1);
            QuickSortMethod(middle + 1, end);
        }
    }
}