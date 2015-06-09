using System;

class FibonacciSequence
{
    static void Main()
    {
        Console.WriteLine("Please enter number of n: ");
        string members = Console.ReadLine();
        uint n = new uint();
        bool attempt = uint.TryParse(members, out n);
        int x0 = -1;
        int x1 = 1;
        int x2 = 0;
        if (attempt == false)
        {
            Console.WriteLine("Invalid number, try again!");
            return;
        }

        Console.WriteLine();

        for (int i = 0; i <= n; i++)
        {
            x2 = x1 + x0;
            Console.Write("{0}, ", x2);
            x0 = x1;
            x1 = x2;
        }

        Console.WriteLine();

    }
}
