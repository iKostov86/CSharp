using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrintListInAlphabeticalOrder
{
    static void Main()
    {
        string input = "panica ala nica ovalna bala";
        string[] output = input.Split(new [] {' '}, StringSplitOptions.RemoveEmptyEntries);

        Array.Sort(output);

        foreach (var item in output)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine();
        Console.WriteLine();
    }
}
