using System;

class SubsetsZero
{
    static void Main()
    {
        int count = 5;
        int sum = 0;
        int[] number = new int[5];
        bool subset = false;

        try
        {
            number[0] = int.Parse(Console.ReadLine());
            number[1] = int.Parse(Console.ReadLine());
            number[2] = int.Parse(Console.ReadLine());
            number[3] = int.Parse(Console.ReadLine());
            number[4] = int.Parse(Console.ReadLine());
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid number, try again!");
            return;
        }

        for (int startPos = 0; startPos < count; startPos++)
        {
            sum = 0;
            for (int endPos = startPos; endPos < count; endPos++)
            {
                sum += number[endPos];
                if (sum == 0)
                {
                    subset = true;
                    Console.WriteLine("Subset found: ");
                    for (int iterator = startPos; iterator <= endPos; iterator++)
                    {
                        Console.Write("{0} ", number[iterator]);
                    }
                    Console.WriteLine();
                }
            }
        }

        if (subset == false)
        {
            Console.WriteLine("Subset isn't found!");
        }
    }
}
