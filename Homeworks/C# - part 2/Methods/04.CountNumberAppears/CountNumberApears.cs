using System;

public class CountNumberApears
{
    public static void Main()
    {
        int[] arrayNum = new int[] { 2, 5, 7, 4, 9, 0, 4, 7, 5, 5, 5, 5, 0 };
        Console.WriteLine("Please enter your test number: ");
        int testNum = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine(CountAppears(arrayNum, testNum));
    }

    public static int CountAppears(int[] array, int test)
    {
        int count = 0;
        foreach (var item in array)
        {
            if (item == test)
            {
                count++;
            }
        }
        return count;
    }
}