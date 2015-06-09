using System;

class FirstBiggerThanNeighbors
{
    static void Main()
    {
        int[] array = new int[] { 1, 2, 3, 3, 4, 6, 5 };
        bool result = false;
        foreach (var position in array)
        {
            result = CheckElement(array, position);
            if (result == true)
            {
                Console.WriteLine("The index of the first bigger is: {0}", position);
                Console.WriteLine();
                return;
            }
        }
    }

    static bool CheckElement(int[] array, int position)
    {
        if (position > 1 && position < array.Length)
        {
            if (array[position - 2] < array[position - 1] && array[position - 1] > array[position])
            {
                return true;
            }
        }
        return false;
    }
}
