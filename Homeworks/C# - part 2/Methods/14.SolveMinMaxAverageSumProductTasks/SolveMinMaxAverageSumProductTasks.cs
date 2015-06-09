using System;

class SolveMinMaxAverageSumProductTasks
{
    static void Main()
    {
        int[] array = new int[] { 2, -4, 7, 2, 9, 1, 7, 7, 7, 2 };

        Console.WriteLine("*****************************");
        Console.WriteLine("Enter your choice for task:  \r\n");
        Console.WriteLine("(1) to find Min, ");
        Console.WriteLine("(2) to find Max, ");
        Console.WriteLine("(3) to find Average, ");
        Console.WriteLine("(4) to find Sum, ");
        Console.WriteLine("(5) to find Product.");
        Console.WriteLine("*****************************");
        Console.Write("-> ");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                //FindMin(array);
                Console.WriteLine(FindMin(6, 7, 5, 4, 3, 0, 5, 1, 0, 9));
                Console.WriteLine(FindMin());
                Console.WriteLine(FindMin(3, 5, 6, 7, 8, 9, 23));
                break;
            case 2:
                FindMax(array);
                break;
            case 3:
                FindAverage(array);
                break;
            case 4:
                FindSum(array);
                break;
            case 5:
                FindProduct(array);
                break;
        }
    }

    //static void FindMin(params int[] array)
    static int FindMin(params int[] array)
    {
        if (array.Length == 0)
        {
            return int.MinValue;
        }
        int min = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }

        //PrintResult(min, "The min value is: ");
        return min;
    }

    static void FindMax(params int[] array)
    {
        int max = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }

        PrintResult(max, "The max value is: ");
    }

    static void FindAverage(params int[] array)
    {
        int average = new int();

        foreach (var item in array)
        {
            average += item;
        }

        average /= array.Length;

        PrintResult(average, "The average value is: ");
    }

    static void FindSum(params int[] array)
    {
        int sum = new int();

        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        PrintResult(sum, "The sum of elements is: ");
    }

    static void FindProduct(params int[] array)
    {
        int product = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            product *= array[i];
        }

        PrintResult(product, "The product of elements is: ");
    }

    static void PrintResult(int number, string text)
    {
        Console.WriteLine();
        Console.WriteLine(text + number);
        Console.WriteLine();
    }
}
