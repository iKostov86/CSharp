using System;

class CombinationsKOfN
{
    static public int nCount = 5;
    static public int kCount = 2;
    static public int[] arrayNum = new int[20];

    static void Main()
    {
        Console.WriteLine("C({0}, {1})", nCount, kCount);
        Combinations(1, 0);
    }

    static void Combinations(int i, int after)
    {
        if (i > kCount)
        {
            return;
        }
        for (int j = after + 1; j <= nCount; j++)
        {
            arrayNum[i - 1] = j;
            if (i == kCount)
            {
                Print(i);
            }
            Combinations(i + 1, j);
        }
    }

    static void Print(int length)
    {
        for (int i = 0; i < length; i++)
        {
            Console.Write(arrayNum[i]);
        }
        Console.WriteLine();
    }
}
