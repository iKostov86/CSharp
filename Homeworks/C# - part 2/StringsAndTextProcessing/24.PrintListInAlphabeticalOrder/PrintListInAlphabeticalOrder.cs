using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PrintListInAlphabeticalOrder
{
    internal static void Main()
    {
        string input = "panica ala nica ovalna bala";
        string[] words = input.Split(new [] {' '}, StringSplitOptions.RemoveEmptyEntries);

        Array.Sort(words);
        PrintWords(words);
    }

    public static void PrintWords(string[] words)
    {
        for (int i = 0, len = words.Length; i < len; i++)
        {
            Console.Write("{0} ", words[i]);
        }

        Console.WriteLine();
    }
}
