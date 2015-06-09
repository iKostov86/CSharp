using System;

class IndexMultipliedBy5
{
    static void Main()
    {
        int multiplayer = int.Parse(Console.ReadLine());
        int[] array = new int[20];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i * multiplayer;
            Console.WriteLine("{0} ", array[i]);
        }
    }
}
