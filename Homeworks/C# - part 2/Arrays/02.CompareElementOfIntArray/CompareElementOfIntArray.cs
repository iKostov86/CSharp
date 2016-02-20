using System;

class CompareElementOfIntArray
{
    static void Main()
    {
        int firstLen = GetArrayDimension();
        int secondLen = GetArrayDimension();

        if (ValidateArraysDimensionEquality(firstLen, secondLen))
        {
            int[] firstArr = getArray(firstLen);
            int[] secondArr = getArray(secondLen);
            bool result = GetArraysComparison(firstArr, secondArr);

            PrintAccordingToComparison(result);
        }
    }

    public static int GetArrayDimension()
    {
        Console.WriteLine("Enter an array length: ");
        int len = int.Parse(Console.ReadLine());

        return len;
    }

    public static int[] getArray(int len)
    {
        int[] arr = new int[len];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        return arr;
    }

    public static bool GetArraysComparison(int[] firstArr, int[] secondArr)
    {
        for (int i = 0; i < firstArr.Length; i++)
        {
            if (firstArr[i] != secondArr[i])
            {
                return false;
            }
        }

        return true;
    }

    public static bool ValidateArraysDimensionEquality(int firstLen, int secondLen)
    {
        if (firstLen != secondLen)
        {
            Console.WriteLine("The arrays can not be the same.");
            return false;
        }

        return true;
    }

    public static void PrintAccordingToComparison(bool result)
    {
        if (result)
        {
            Console.WriteLine("The arrays are same.");
        }
        else
        {
            Console.WriteLine("The arrays are not equal.");
        }
    }
}

