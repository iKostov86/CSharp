using System;

public class IndexMultipliedBy5
{
    internal static void Main()
    {
        int multiplier = GetMultiplier();
        int[] multipliedArray = GetMultipliedArray(new int[20], multiplier);

        PrintArray(multipliedArray);
    }

    public static int GetMultiplier()
    {
        Console.WriteLine("Please enter a multiplier: ");

        return int.Parse(Console.ReadLine());
    }

    public static int[] GetMultipliedArray(int[] arr, int multiplier)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = i * multiplier;
        }

        return arr;
    }

    public static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}
