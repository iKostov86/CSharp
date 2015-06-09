using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReverseString
{
    static void Main()
    {
        //v.1

        //char[] input = Console.ReadLine().ToArray();
        //char[] output = input.Reverse().ToArray();

        //foreach (var item in output)
        //{
        //    Console.Write(item);
        //}
        //Console.WriteLine();

        //v.2

        //string input = Console.ReadLine();
        //StringBuilder myBuilder = new StringBuilder();

        //for (int i = input.Length - 1; i >= 0 ; i--)
        //{
        //    myBuilder.Append(input[i]);
        //}

        //Console.WriteLine(myBuilder);

        //v.3

        //char[] input = Console.ReadLine().ToArray();

        //int length = input.Length - 1;

        //for (int i = 0; i < length; i++, length--)
        //{

        //    input[i] ^= input[length];

        //    input[length] ^= input[i];

        //    input[i] ^= input[length];
        //}

        //v.4

        //string input = Console.ReadLine();
        //string output = new string(input.Reverse().ToArray());
        ////var output = input.Reverse().ToArray();

        //Console.WriteLine(output);

        //v.5

        string input = Console.ReadLine();
        string output = input.Aggregate("", (x, y) => y + x);

        Console.WriteLine(output);
    }
}
