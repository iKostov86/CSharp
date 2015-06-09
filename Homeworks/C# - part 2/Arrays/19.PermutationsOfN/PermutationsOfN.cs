using System;
using System.Linq;
using System.Collections.Generic;

class PermutationsOfN
{
    static public int nCount = 3;
    static public int kCount = 2;
    static public int[] arrayNum = new int[kCount];
    static public bool[] usedNum = new bool[nCount];

    /***   n! / (n - k)!   ***/

    static void Main()
    {
        Permute(0);
    }

    static void Permute(int k)
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
                /* if */
                Permute(k + 1);
                usedNum[n] = false;
            }
        }
    }

    static void Print()
    {
        for (int i = 0; i < kCount; i++)
        {
            Console.Write("{0}", (arrayNum[i] + 1));
        }
        Console.WriteLine();
    }
}
