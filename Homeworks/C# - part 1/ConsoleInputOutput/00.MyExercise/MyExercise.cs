using System;
using System.Text;
using System.Numerics;

class MyExercise
{
    static void Main(string[] args)
    {
        //************************************************************************************

        //float a = .456f;
        //Console.WriteLine("{0:0.00}", a);
        //int i = int.Parse(Console.ReadLine());
        //Console.WriteLine("\t{0:x}", i);

        //************************************************************************************
        // variants to string format

        //string input;
        //int i = new int();
        //i = 234;

        //input = String.Format("{0:X}", i).PadRight(10);
        //Console.WriteLine(input);                               //or
        //input = String.Format("{0, -10:X}", i);
        //Console.WriteLine(input);                               //or
        //input = i.ToString("X").PadRight(10);
        //Console.WriteLine(input);                               //and
        //input = Convert.ToString(i, 16);
        //Console.WriteLine(input);

        //************************************************************************************
        //convert string (binary number) to integer decimal with BigInteger

        string numberAsStr = "10000000";
        BigInteger bigInt = 0;
        int a = numberAsStr.Length;


        for (int i = 0; i < a; i++)
        {
            string s = char.ToString(numberAsStr[i]);
            bigInt += int.Parse(s) * (1 << (a - i - 1));
        }

        Console.WriteLine(bigInt);

    }
}
