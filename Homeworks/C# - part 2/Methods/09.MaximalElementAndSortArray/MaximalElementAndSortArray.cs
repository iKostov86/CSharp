using System;

class MaximalElementAndSortArray
{
    static void Main()
    {
        string input = Console.ReadLine();
        int[] intArray = StringToIntArray(input);
        int maxElement = GetMaxElement(intArray, 0);
        intArray = SortMethod(intArray);
        Console.WriteLine("Max element in that array is: {0}.", maxElement);
        PrintIntArray(intArray);
    }

    public static int[] StringToIntArray(string input)
    {
        string[] subString = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        int[] intArray = new int[subString.Length];

        for (int i = 0; i < subString.Length; i++)
        {
            intArray[i] = int.Parse(subString[i]);
        }
        return intArray;
    }

    public static int GetMaxElement(int[] array, int index)
    {
        int maxElement = array[index];
        for (int i = index + 1; i < array.Length; i++)
        {
            if (array[i] > maxElement)
            {
                maxElement = array[i];
            }
        }
        return maxElement;
    }

    static int[] SortMethod(int[] intArray)
    {
        int temp = 0;
        int maxIndex = 0;
        int maxElement = 0;
        for (int i = 0; i < intArray.Length; i++)
        {
            maxElement = GetMaxElement(intArray, i);
            for (int j = 0; j < intArray.Length; j++)
            {
                if (intArray[j] == maxElement)
                {
                    maxIndex = j;
                }
            }
            temp = intArray[i];
            intArray[i] = intArray[maxIndex];
            intArray[maxIndex] = temp;
        }
        return intArray;
    }

    static void PrintIntArray(int[] intArray)
    {
        Console.WriteLine();
        Console.WriteLine("This is the sorted array: ");
        foreach (var item in intArray)
        {
            Console.Write(item);
            if (item != intArray[intArray.Length - 1])
            {
                Console.Write(", ");
            }
            else
            {
                Console.Write(".");
            }
        }
        Console.WriteLine();
    }
}