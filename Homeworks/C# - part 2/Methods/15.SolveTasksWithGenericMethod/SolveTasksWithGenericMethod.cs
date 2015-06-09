using System;

class SolveTasksWithGenericMethod
{
    static void Main()
    {
        decimal[] array = new decimal[] { 2m, -4m, 7m, 2m, 9m, 1m, 7m, 7m, 7m, 2m, 3m };
        double[] array2 = new double[] { 2, -4, 7, 2, 9, 1, 7, 7, 7, 2, 3 };

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
                //FindMin(1.1, 2, 3, 4, 5);
                //FindMin(array);
                Console.WriteLine(FindMin(1.1, 2, 3, 4, 5));
                Console.WriteLine(FindMin(array));
                Console.WriteLine(FindMin(array2));
                Console.WriteLine(FindMin(new int[0]));
                break;
            case 2:
                FindMax(1.1, 2, 3, 4, 5);
                FindMax(array);
                FindMax(array2);
                break;
            case 3:
                FindAverage(1.1, 2, 3, 4, 5);
                FindAverage(array);
                FindAverage(array2);
                break;
            case 4:
                FindSum(1.1, 2, 3, 4, 5);
                FindSum(array);
                FindSum(array2);
                break;
            case 5:
                FindProduct(1.1, 2, 3, 4, 5);
                FindProduct(array);
                FindProduct(array2);
                break;
        }
    }


    static dynamic FindMin<T>(params T[] array)
    {
        if (array.Length <= 0)
        {
            return "Not a number!";
        }

        dynamic min = array[0];

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

    static void FindMax<T>(params T[] array)
    {
        dynamic max = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }

        PrintResult(max, "The max value is: ");
    }

    static void FindAverage<T>(params T[] array)
    {
        dynamic average = new int();

        foreach (var item in array)
        {
            average += item;
        }

        average /= (dynamic)array.Length;

        PrintResult(average, "The average value is: ");
    }

    static void FindSum<T>(params T[] array)
    {
        dynamic sum = new int();

        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        PrintResult(sum, "The sum of elements is: ");
    }

    static void FindProduct<T>(params T[] array)
    {
        dynamic product = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            product *= array[i];
        }

        PrintResult(product, "The product of elements is: ");
    }

    static void PrintResult<T>(T number, string text)
    {
        Console.WriteLine();
        Console.WriteLine(text + number);
        Console.WriteLine();
    }

}
