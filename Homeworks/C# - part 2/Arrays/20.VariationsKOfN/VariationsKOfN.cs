using System;

class VariationsKOfN
{
    static public int nCount = 4;
    static public int kCount = 4;
    static public int[] arrayNum = new int[kCount];
    static public bool[] usedNum = new bool[nCount];

    static void Main()
    {
        Variations(0);
    }

    static void Variations(int k)
    {
        if (k >= kCount)
        {
            Print();
            return;
        }
        for (int n = 0; n < nCount; n++)
        {
            if (!usedNum[n])
            {
                usedNum[n] = true;
                arrayNum[k] = n;
                Variations(k + 1);
                usedNum[n] = false;
            }
        }
    }

    static void Print()
    {
        for (int i = 0; i < kCount; i++)
        {
            Console.Write(arrayNum[i] + 1);
        }
        Console.WriteLine();
    }
}