using System;
using System.Linq;
using System.Text;

public class ReverseString
{
    internal static void Main()
    {
        // v.1
        //Console.WriteLine("Please enter a string:");

        //char[] input1 = Console.ReadLine().ToArray();
        //char[] output1 = input1.Reverse().ToArray();

        //PrintArr(output1);

        // v.2
        //Console.WriteLine("Please enter a string:");

        //StringBuilder sb = new StringBuilder();
        //string input2 = Console.ReadLine();

        //for (int i = input2.Length - 1; i >= 0; i--)
        //{
        //    sb.Append(input2[i]);
        //}

        //Console.WriteLine(sb);

        // v.3
        char[] input3 = Console.ReadLine().ToArray();

        int len = input3.Length - 1;

        for (int i = 0; i < len; i++, len--)
        {

            input3[i] ^= input3[len];

            input3[len] ^= input3[i];

            input3[i] ^= input3[len];
        }

        // v.4
        //Console.WriteLine("Please enter a string:");

        //string input4 = Console.ReadLine();
        //string output4 = new string(input4.Reverse().ToArray());

        //Console.WriteLine(output4);

        // v.5
        //Console.WriteLine("Please enter a string:");

        //string input5 = Console.ReadLine();
        //string output5 = input5.Aggregate("", (x, y) => y + x);

        //Console.WriteLine(output5);
    }

    public static void PrintArr(char[] arr)
    {
        for (int i = 0, len = arr.Length; i < len; i++)
        {
            Console.Write(arr[i]);
        }

        Console.WriteLine();
    }
}
