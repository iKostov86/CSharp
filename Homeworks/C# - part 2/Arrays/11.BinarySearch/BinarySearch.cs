using System;

class BinarySearch
{
    static void Main()
    {
        int[] unsortedArray = new int[] { 2, 3, 7, 44, 0, 5, 17 };
        int number = int.Parse(Console.ReadLine());
        Array.Sort(unsortedArray);
        int index = Array.BinarySearch(unsortedArray, number);
        Console.WriteLine("Index of {0} is {1}.", number, index);
    }
}
