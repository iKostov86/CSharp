using System;

public class SolveTasksWithGenericMethod
{
    internal static void Main()
    {
        decimal[] firstArr = new decimal[] { 2m, -4m, 7m, 2m, 9m, 1m, 7m, 7m, 7m, 2m, 3m };
        double[] secondArr = new double[] { 2, -4, 7, 2, 9, 1, 7, 7, 7, 2, 3 };

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
        dynamic result = null;
        string text = string.Empty;

        switch (choice)
        {
            case 1:
                result = FindMin(firstArr);
                text = "The min value is: ";
                break;
            case 2:
                result = FindMax(firstArr);
                text = "The max value is: ";
                break;
            case 3:
                result = FindAverage(firstArr);
                text = "The average value is: ";
                break;
            case 4:
                result = FindSum(firstArr);
                text = "The sum of elements is: ";
                break;
            case 5:
                result = FindProduct(firstArr);
                text =  "The product of elements is: ";
                break;
            default:
                break;
        }

        PrintResult(result, text);
    }

    public static T FindMin<T>(params T[] arr)
    {
        int len = arr.Length;

        if (len <= 0)
        {
            throw new ArgumentException("No arguments are presented.");
        }

        dynamic min = arr[0];

        for (int i = 1; i < len; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }

        return min;
    }

    public static T FindMax<T>(params T[] arr)
    {
        int len = arr.Length;
        dynamic max = arr[0];

        if (len <= 0)
        {
            throw new ArgumentException("No arguments are presented.");
        }

        for (int i = 1; i < len; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }

        return max;
    }

    public static T FindAverage<T>(params T[] arr)
    {
        int len = arr.Length;
        dynamic average = new int();

        if (len <= 0)
        {
            throw new ArgumentException("No arguments are presented.");
        }

        foreach (var item in arr)
        {
            average += item;
        }

        average /= (dynamic)len;

        return average;
    }

    public static T FindSum<T>(params T[] arr)
    {
        int len = arr.Length;
        dynamic sum = new int();

        if (len <= 0)
        {
            throw new ArgumentException("No arguments are presented.");
        }

        for (int i = 0; i < len; i++)
        {
            sum += arr[i];
        }

        return sum;
    }

    public static T FindProduct<T>(params T[] arr)
    {
        int len = arr.Length;
        dynamic product = arr[0];

        if (len <= 0)
        {
            throw new ArgumentException("No arguments are presented.");
        }

        for (int i = 1; i < len; i++)
        {
            product *= arr[i];
        }

        return product;
    }

    public static void PrintResult<T>(T num, string text)
    {
        Console.WriteLine("{1}{0}{1}", text + num, Environment.NewLine);
    }

}
