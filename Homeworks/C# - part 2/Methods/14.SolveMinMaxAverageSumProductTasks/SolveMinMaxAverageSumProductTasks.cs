using System;

public class SolveMinMaxAverageSumProductTasks
{
    internal static void Main()
    {
        Console.WriteLine("2, -4, 7, 2, 9, 1, 7, 7, 7, 2");
        int[] arr = new int[] { 2, -4, 7, 2, 9, 1, 7, 7, 7, 2 };

        Console.WriteLine("*****************************");
        Console.WriteLine(
            "Enter your choice for task: {0}(1) -> to find Min {0}(2) -> to find Max {0}(3) -> to find Average {0}(4) -> to find Sum {0}(5) -> to find Product", Environment.NewLine);
        Console.WriteLine("*****************************");
        Console.Write("-> ");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                int min = FindMin(arr);

                PrintResult(min, "The min value is: ");

                break;
            case 2:
                int max = FindMax(arr);

                PrintResult(max, "The max value is: ");

                break;
            case 3:
                int average = FindAverage(arr);

                PrintResult(average, "The average value is: ");

                break;
            case 4:
                int sum = FindSum(arr);

                PrintResult(sum, "The sum of elements is: ");

                break;
            case 5:
                int product = FindProduct(arr);

                PrintResult(product, "The product of elements is: ");

                break;
        }
    }

    public static int FindMin(params int[] arr)
    {
        int len = arr.Length;
        int min = arr[0];

        if (len > 0)
        {
            for (int i = 1; i < len; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            return min;
        }

        return int.MinValue;
    }

    public static int FindMax(params int[] arr)
    {
        int len = arr.Length;
        int max = arr[0];

        for (int i = 1; i < len; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }

        return max;
    }

    public static int FindAverage(params int[] arr)
    {
        int len = arr.Length;
        int average = new int();

        foreach (var item in arr)
        {
            average += item;
        }

        average /= len ;

        return average;
    }

    public static int FindSum(params int[] arr)
    {
        int len = arr.Length;
        int sum = new int();

        for (int i = 0; i < len; i++)
        {
            sum += arr[i];
        }

        return sum;
    }

    public static int FindProduct(params int[] arr)
    {
        int len = arr.Length;
        int product = arr[0];

        for (int i = 1; i < len; i++)
        {
            product *= arr[i];
        }

        return product;
    }

    public static void PrintResult(int number, string text)
    {
        Console.WriteLine("{1}{0}{1}", text + number, Environment.NewLine);
    }
}
