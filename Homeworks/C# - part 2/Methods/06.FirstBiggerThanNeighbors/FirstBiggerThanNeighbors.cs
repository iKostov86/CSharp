using System;

public class FirstBiggerThanNeighbors
{
    internal static void Main()
    {
        int[] arr = new int[] { 1, 2, 3, 3, 4, 6, 15, 19 };

        for (int pos = 1, len = arr.Length - 1; pos < len; pos++)
        {
            if (CheckElement(arr, pos))
            {
                Console.WriteLine("The larger number is: {0}", arr[pos]);
                Console.WriteLine("The index of the first number in array that is bigger then its neighbors is: {0}{1}", pos, Environment.NewLine);
                return;
            }
        }
    }

    public static bool CheckElement(int[] arr, int pos)
    {
        if (arr[pos - 1] < arr[pos] && arr[pos] > arr[pos + 1])
        {
            return true;
        }

        return false;
    }
}
