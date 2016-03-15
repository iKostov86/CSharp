using System;

public class GetMax
{
    internal static void Main()
    {
        Console.WriteLine("Enter three numbers to get bigger of them: ");
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());
        int thirdNum = int.Parse(Console.ReadLine());

        secondNum = GetMaxBetweenTwoNumbers(secondNum, thirdNum);
        firstNum = GetMaxBetweenTwoNumbers(firstNum, secondNum);

        Console.WriteLine("The bigger number is: ");
        Console.WriteLine(firstNum);
    }

    public static int GetMaxBetweenTwoNumbers(int numA, int numB)
    {
        return numA > numB ? numA : numB;
    }
}
