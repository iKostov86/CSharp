using System;

class StringArraySortByLength
{

    /*** using quick sort implementation ***/

    //public static void Main()
    //{
    //    string[] array = new string[] { "", "H", "Hello, my friend", "Hi", "Hello", "Hello!", "E tva e nai dylgoto izrechenie sha znaish!" };

    //    if (0 < array.Length)
    //    {
    //        QuickSortMethod(array, 0, array.Length - 1);
    //    }
    //    for (int i = 0; i < array.Length; i++)
    //    {
    //        Console.WriteLine(array[i]);
    //    }
    //    Console.WriteLine();
    //}

    //public static void QuickSortMethod(string[] array, int left, int right)
    //{
    //    int start = left;
    //    int end = right;
    //    int direction = 0;
    //    int middle = 0;
    //    string swapTemp = "";

    //    while (left < right)
    //    {
    //        if (array[left].Length < array[right].Length)
    //        {
    //            if (direction == 0)
    //            {
    //                right--;
    //            }
    //            else
    //            {
    //                left++;
    //            }
    //        }
    //        else
    //        {
    //            if (array[left].Length != array[right].Length)
    //            {
    //                swapTemp = array[left];
    //                array[left] = array[right];
    //                array[right] = swapTemp;
    //            }
    //            if (direction == 0)
    //            {
    //                direction = 1;
    //                left++;
    //            }
    //            else
    //            {
    //                direction = 0;
    //                right--;
    //            }
    //        }

    //    }

    //    middle = right;

    //    if ((start < middle - 1) || (middle + 1 < end))
    //    {
    //        QuickSortMethod(array, start, middle - 1);
    //        QuickSortMethod(array, middle + 1, end);
    //    }

    //}

    /*** using Lambda expressions ***/

    public static void Main()
    {
        Console.WriteLine("Please enter lenght of the array N: ");
        int n = int.Parse(Console.ReadLine());
        string[] array = new string[n];
        for (int index = 0; index < array.Length; index++)
        {
            Console.Write("Enter element[{0}] = ", index);
            array[index] = Console.ReadLine();
        }
        Array.Sort(array, (x, y) => x.Length.CompareTo(y.Length));
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }
}
