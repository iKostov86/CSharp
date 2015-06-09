using System;

class FindGreaterOfFive
{
    static void Main()
    {
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
            buf = Math.Max(buf, temp);
        }

        Console.WriteLine("\nThe greater number is: {0}", buf);

    }
}
