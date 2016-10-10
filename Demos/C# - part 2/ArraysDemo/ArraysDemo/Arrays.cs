using System;

public class Arrays
{
    internal static void Main(string[] args)
    {
        var numbers = Console.ReadLine().Split(' ');

        Console.WriteLine(string.Join(", ", numbers));

        int[] somethings = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        bool isSymetric = true;

        for (int i = 0; i < somethings.Length / 2; i++)
        {
            if (somethings[i] != somethings[somethings.Length - i - 1])
            {
                isSymetric = false;
                break;
            }
        }

        Console.WriteLine("Is symmetric: {0}", isSymetric);
    }
}
