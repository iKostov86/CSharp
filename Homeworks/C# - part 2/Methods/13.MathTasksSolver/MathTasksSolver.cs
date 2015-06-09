using System;
using System.Globalization;
using System.Threading;

class MathTasksSolver
{
    static void Main()
    
    {
        TaskChoice();
    }

    static void TaskChoice()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine(
            "Please enter your choice: \r\n(1 to reverse digit, 2 to average calculation, 3 to solving linear equation) \r\n");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Enter a decimal number: ");
                decimal number = decimal.Parse(Console.ReadLine());
                ReverseDigits(number);
                break;
            case 2:
                Console.WriteLine("Enter a length of sequence: ");
                int sequenceLength = int.Parse(Console.ReadLine());
                int[] sequenceArray = new int[sequenceLength];
                Console.WriteLine("Enter integers of sequence: ");
                for (int i = 0; i < sequenceLength; i++)
                {
                    sequenceArray[i] = int.Parse(Console.ReadLine());
                }
                AverageCalculationOfNumbersSequence(sequenceArray, sequenceLength);
                break;
            case 3:
                int coefficientA = new int();
                int coefficientB = new int();

                Console.WriteLine("Please eneter A and B for equation A.x + b = 0.");
                Console.Write("A = ");
                coefficientA = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("B = ");
                coefficientB = int.Parse(Console.ReadLine());
                Console.WriteLine();
                SolvingLinearEquation(coefficientA, coefficientB);
                break;
            default:
                break;
        }
    }
    static void ReverseDigits(decimal number)
    {
        if (number < 0)
        {
            Console.WriteLine("Negative number!");
            return;
        }
        else
        {
            ReverseTheDigits.ReverseNumber(number);
            //to do: reverse
        }
    }

    static void AverageCalculationOfNumbersSequence(int[] sequenceArray, int sequenceLength)
    {
        int average = 0;
        if (sequenceLength == 0)
        {
            Console.WriteLine("Empty sequence!");
            return;
        }
        else
        {
            foreach (var item in sequenceArray)
            {
                average += item;
            }
            average /= sequenceLength;
        }
        Console.WriteLine("The average of a given sequence is: {0}", average);
    }

    static void SolvingLinearEquation(int coefficientA, int coefficientB)
    {
        int x = new int();
        if (coefficientA == 0)
        {
            Console.WriteLine("'A' is zero!");
            return;
        }
        else
        {
            if (coefficientB == 0)
            {
                x = 0;
            }
            else
            {
                x = -coefficientB / coefficientA;
            }
        }
        Console.WriteLine("x = {0}", x);
    }
}
