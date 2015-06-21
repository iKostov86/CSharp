using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FeaturingWithGrisko
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] arr = new string[fact(input.Length)];

        for (int i = 0; i < input.Length; i++)
        {
            arr[i] += input[i];

            for (int j = i + 1; j < input.Length; j++)
            {
                arr[i] += input[j];
            }
        }
    }

    public static int fact(int x)
    {
        int fact = 1;
        int i = 1;
        while (i <= x)
        {
            fact = fact * i;
            i++;
        }
        return fact;
    }

    public static bool IsCorrect(string word)
    {
        for (int i = 1; i < word.Length; i++)
        {
            if (word[i] == word[i - 1])
            {
                return false;
            }
        }

        return true;
    }
}
