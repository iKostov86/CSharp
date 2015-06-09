using System;
using System.Threading;
class PrintSumOfFiveCheckedNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
        //string input;
        //bool result = false;
        //int buf = 0;
        //int temp = 0;

        //for (int i = 0; i < 5; i++)
        //{
        //    do
        //    {
        //        Console.WriteLine("Please insert correct integer: ");
        //        input = Console.ReadLine();
        //        result = int.TryParse(input, out temp);
        //    } while ((result == false));

        //    buf += temp;
        //}

        //Console.WriteLine("The sum is: {0}", buf);

        string input;
        int buf = 0;
        int temp;

        for (int i = 0; i < 5; i++)
        {
            do
            {
                Console.WriteLine("Please enter a correct integer: ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out temp));

            buf += temp;
        }

        Console.WriteLine("\nThe sum is: {0}", buf);
    }
}