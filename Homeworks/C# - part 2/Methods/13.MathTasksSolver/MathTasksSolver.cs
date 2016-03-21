using System;
using System.Linq;
using System.Globalization;
using System.Threading;

public class MathTasksSolver
{
    internal static void Main()
    
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        TaskChoice();
    }

    public static void TaskChoice()
    {
        Console.WriteLine(
            "Please enter your choice: {0}1 -> to reverse digit {0}2 -> to average calculation {0}3 -> to solving linear equation", Environment.NewLine);
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                decimal num = GetDigit();

                ReverseDigits(num);

                break;
            case 2:
                int sequenceLen = GetSequenceLength();
                int[] sequenceArr = GetSequence(sequenceLen);

                AverageCalculationSequenceOfNumbers(sequenceArr, sequenceLen);

                break;
            case 3:
                int[] coefficients = GetLinearEquationCoefficients();

                SolvingLinearEquation(coefficients);

                break;
            default:
                break;
        }
    }

    public static decimal GetDigit()
    {
        Console.WriteLine("Enter a decimal number: ");

        return decimal.Parse(Console.ReadLine());
    }

    public static int GetSequenceLength()
    {
        Console.WriteLine("Enter a length of sequence: ");

        return int.Parse(Console.ReadLine());
    }

    public static int[] GetSequence(int sequenceLen)
    {
        Console.WriteLine("Enter the sequence: ");

        string sequence = Console.ReadLine();
        int[] sequenceArr = sequence
                                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                                .Select(x => int.Parse(x))
                                .ToArray();

        return sequenceArr;
    }

    public static int[] GetLinearEquationCoefficients()
    {
        int[] coefficients = new int[2];

        Console.WriteLine("Please enter A and B for equation a.x + b = 0");

        Console.Write("A = ");
        coefficients[1] = int.Parse(Console.ReadLine());

        Console.Write("B = ");
        coefficients[0] = int.Parse(Console.ReadLine());

        return coefficients;
    }

    public static void ReverseDigits(decimal num)
    {
        if (num < 0)
        {
            Console.WriteLine("Can't reverse negative number!");
        }
        else
        {
            decimal reversedNum = num
                                    .ToString()
                                    .Reverse()
                                    .Aggregate(0m, (x, y) => x * 10 + y - '0');

            Console.WriteLine("{0} -> {1}", num, reversedNum);
        }
    }

    public static void AverageCalculationSequenceOfNumbers(int[] sequenceArr, int sequenceLen)
    {
        int average = 0;

        if (sequenceLen == 0)
        {
            Console.WriteLine("The sequence is empty!");
        }
        else
        {
            foreach (var item in sequenceArr)
            {
                average += item;
            }

            average /= sequenceLen;

            Console.WriteLine("The average of a given sequence is: {0}", average);
        }

    }

    public static void SolvingLinearEquation(int[] coefficients)
    {
        decimal x = new int();
        int zeroCoefficient = coefficients[0];
        int firstCoefficient = coefficients[1];

        if (firstCoefficient == 0)
        {
            Console.WriteLine("'A' can't be zero!");
        }
        else
        {
            if (zeroCoefficient == 0)
            {
                x = 0m;
            }
            else
            {
                x = -zeroCoefficient / (decimal)firstCoefficient;
            }

            Console.WriteLine("x = {0}", x);
        }

    }
}
