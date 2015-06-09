using System;
using System.Collections.Generic;

class ConvertFromDecimalToHexadecimal
{
    static void Main()
    {
        int numDecimal = 0;
        List<string> numHexa = new List<string>();
        Console.WriteLine("Please enter a decimal number: ");
        bool check = int.TryParse(Console.ReadLine(), out numDecimal);
        Console.WriteLine();

        if (check == false)
        {
            Console.WriteLine("Invalid number!");
            return;
        }
        
        while (numDecimal > 0)
	    {
            switch (numDecimal % 16)
	        {
                case 0:
                    numHexa.Add("0");
                    break;
                case 1:
                    numHexa.Add("1");
                    break;
                case 2:
                    numHexa.Add("2");
                    break;
                case 3:
                    numHexa.Add("3");
                    break;
                case 4:
                    numHexa.Add("4");
                    break;
                case 5:
                    numHexa.Add("5");
                    break;
                case 6:
                    numHexa.Add("6");
                    break;
                case 7:
                    numHexa.Add("7");
                    break;
                case 8:
                    numHexa.Add("8");
                    break;
                case 9:
                    numHexa.Add("9");
                    break;
                case 10:
                    numHexa.Add("A");
                    break;
                case 11:
                    numHexa.Add("B");
                    break;
                case 12:
                    numHexa.Add("C");
                    break;
                case 13:
                    numHexa.Add("D");
                    break;
                case 14:
                    numHexa.Add("E");
                    break;
                case 15:
                    numHexa.Add("F");
                    break;
		        default:
                    break;
	        }

            numDecimal /= 16;
	    }

        //numHexa.Reverse();

        for (int i = numHexa.Count - 1; i > -1; i--)
        {
            Console.Write("{0}", numHexa[i]);
        }

        Console.WriteLine();
    }
}
