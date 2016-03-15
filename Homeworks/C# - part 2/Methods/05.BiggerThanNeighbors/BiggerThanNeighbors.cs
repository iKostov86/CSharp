using System;

public class BiggerThanNeighbors
{
    internal static void Main()
    {
        int[] arr = new int[] { 1, 2, 4, 3, 5 };
        int position = -1;

        while (position < 1 || position > arr.Length)
        {
            Console.WriteLine("Enter a position from 1 to {0}: ", arr.Length);
            position = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("The element at given position in arr is bigger than its two neighbors: ");
        Console.WriteLine(CheckElement(arr, position));
    }

    public static bool CheckElement(int[] arr, int position)
    {
        if (position > 1 && position < arr.Length) 
        {
            if (arr[position - 2] < arr[position - 1] && arr[position - 1] > arr[position])
            {
                return true;
            }
        }

        return false;
    }
}
