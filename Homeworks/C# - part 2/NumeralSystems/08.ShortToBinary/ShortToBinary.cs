using System;
using System.Text;

class ShortToBinary
{
    static void Main()
    {
        short shortNum = short.Parse(Console.ReadLine());
        int[] shortArray = new int[16];

        if (shortNum < 0)
        {
            shortArray[0] = 1;
            shortNum = (short)((short.MaxValue + 1) + shortNum);
        }
        ConvertShortToBinary(shortNum, shortArray);
    }

    static void ConvertShortToBinary(short shortNum, int[] shortArray)
    {
        int currentIndex = shortArray.Length - 1;
        while (shortNum != 0)
        {
            if ((shortNum % 2) != 0)
            {
                shortArray[currentIndex] = 1;
            }
            shortNum >>= 1;
            currentIndex--;
        }

        PrintBianaryRepresentationOfShort(shortArray);
    }

    static void PrintBianaryRepresentationOfShort(int[] shortArray)
    {
        Console.WriteLine();
        int count = 4;
        for (int i = 0; i < shortArray.Length; i++)
        {
            if (count == 0)
            {
                Console.Write(" ");
                count = 4;
            }
            Console.Write(shortArray[i]);
            count--;
        }
        Console.WriteLine();
    }
}

