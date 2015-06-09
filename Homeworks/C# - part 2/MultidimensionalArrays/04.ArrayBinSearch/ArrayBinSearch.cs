using System;

class ArrayBinSearch
{
    static void Main()
    {
        int[] array = new int[] { 4, 7, 7, 2, 5, 9, 0, 4, 5, 3 };
        int k = 0;
        bool result = true;
        do
        {
            Console.WriteLine("Please enter a positive 32 bit integer: ");
            result = Int32.TryParse(Console.ReadLine(), out k);
        } while (k < 0 || result == false);
        int kIndex = -1;
        Console.WriteLine("This is the unsorted array: ");
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        Array.Sort(array);
        Console.WriteLine("This is the sorted array: ");
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        kIndex = Array.BinarySearch(array, k);
        if (kIndex < 0)
        {
            kIndex = (~kIndex);
            if (kIndex > array.Length - 1)
            {
                Console.WriteLine("There are no elements larger than {0} in the array!", k);
                return;
            }
            else
            {
                kIndex--;
            }
        }
        Console.WriteLine();
        Console.WriteLine("The largest number in the array which <= {0} is: {1}", k, array[kIndex]);
        Console.WriteLine();
    }
}
