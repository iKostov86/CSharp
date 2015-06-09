using System;

class BiggerThanNeighbors
{
    static void Main()
    {
        int[] array = new int[] { 1, 2, 4, 3, 5 };
        int position = -1;
        while (position < 1 || position > array.Length)
        {
            Console.WriteLine("Enter a position from 1 to {0}: ", array.Length);
            position = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("\r\nThe element at given position in array is bigger than its two neighbors: \r\n" + CheckElement(array, position));
        Console.WriteLine();
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
