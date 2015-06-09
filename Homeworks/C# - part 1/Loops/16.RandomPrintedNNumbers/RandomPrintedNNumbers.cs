using System;

class RandomPrintedNNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter N number: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        Random rand = new Random();
        int indexOne = 0;
        int indexTwo = 0;
        int temp;
        Console.WriteLine();

        for (int i = 0; i < n; i++)
        {
            array[i] = i + 1;
            //Console.WriteLine(array[i]);
        }

        for (int i = 0; i < n; i++)
        {
            indexOne = rand.Next(n);
            indexTwo = rand.Next(n);
            temp = array[indexOne];
            array[indexOne] = array[indexTwo];
            array[indexTwo] = temp;
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}", array[i]);
        }
    }
}
