using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class SumOfTwoBigIntegers
{
    static void Main()
    {
        string num1 = Console.ReadLine();
        string num2 = Console.ReadLine();
        int[] arrayNum1 = new int[num1.Length];
        int[] arrayNum2 = new int[num2.Length];

        ToArray(num1, arrayNum1);
        ToArray(num2, arrayNum2);

        int[] arrayTotal = new int[Math.Max(num1.Length, num2.Length) + 1];
        if (arrayNum1.Length > arrayNum2.Length)
        {
            Array.Copy(arrayNum2, arrayTotal, arrayNum2.Length);
            SumMethod(arrayTotal, arrayNum1);
        }
        else
        {
            Array.Copy(arrayNum1, arrayTotal, arrayNum1.Length);
            SumMethod(arrayTotal, arrayNum2);
        }
        Console.WriteLine();
        int j = 1;
        if (arrayTotal[arrayTotal.Length - 1] == 0)
        {
            j++;
        }
        for (int i = arrayTotal.Length - j; i >= 0; i--)
        {
            Console.Write(arrayTotal[i]);
        }
        Console.WriteLine();
    }

    static void SumMethod(int[] arrayTotal, int[] arrayOne)
    {
        int oneOnMind = 0;
        for (int i = 0; i < arrayOne.Length; i++)
        {
            if ((arrayTotal[i] + arrayOne[i] + oneOnMind) > 9)
            {
                arrayTotal[i] = (arrayTotal[i] + arrayOne[i] + oneOnMind) % 10;
                oneOnMind = 1;
            }
            else
            {
                arrayTotal[i] = arrayTotal[i] + arrayOne[i] + oneOnMind;
                oneOnMind = 0;
            }
        }
        if (oneOnMind == 1) arrayTotal[arrayTotal.Length - 1] = 1;
    }

    static void ToArray(string num, int[] arrayNum)
    {
        for (int i = 0, j = num.Length - 1; j >= 0; i++, j--)
        {
            arrayNum[i] = num[j] - '0';
        }
    }
}
