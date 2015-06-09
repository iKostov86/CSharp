using System;
using System.Collections.Generic;

class SubsetS
{
    static void Main()
    {
        int[] arrayNums = new int[] { 1, 2, 4, 6, 8, 9, 0, 3, 5, 7 };
        int givenSum = int.Parse(Console.ReadLine());
        int subsetsCombination = (int)Math.Pow(2, arrayNums.Length);
        for (int i = 1; i < subsetsCombination; i++)
        {
            int sum = 0;
            int subsetBit = i;
            List<int> arraySubset = new List<int>();
            for (int j = 0; j < arrayNums.Length; j++)
            {
                if (subsetBit % 2 == 1)
                {
                    sum += arrayNums[j];
                    arraySubset.Add(arrayNums[j]);
                }
                subsetBit = subsetBit >> 1;
            }
            if (sum == givenSum)
            {
                Console.WriteLine("True");
                for (int k = 0; k < arraySubset.Count; k++)
                {
                    Console.WriteLine(arraySubset[k]);
                }
                return;
            }
        }
        Console.WriteLine("False");

    }
}
