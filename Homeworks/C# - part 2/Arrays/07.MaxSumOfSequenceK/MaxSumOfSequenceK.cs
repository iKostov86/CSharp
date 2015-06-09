using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class MaxSumOfSequenceK
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        int bestSum = 0;
        int bestIndex = 0;

        for (int i = 0; i < n; i++)
        {
			array[i] = int.Parse(Console.ReadLine()); 
        }
        for (int i = 0; i < n - k + 1; i++)
        {
            int tempSum = 0;
            int tempIndex = i;
            for (int j = i; j < i + k; j++)
            {
                tempSum += array[j];
            }
            if (tempSum > bestSum)
            {
                bestSum = tempSum;
                bestIndex = tempIndex;
            }
        }
        for (int i = bestIndex; i < bestIndex + k; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}
