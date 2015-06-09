using System;
using System.Collections.Generic;

class RemovingSort
{
    static void Main()
    {
        //int[] arrayNumbers = new int[] {6, 1, 4, 3, 0, 3, 6, 4, 5 };
        int[] arrayNumbers = new int[] { 4, 3 ,4, 1, 2};
        //int[] arrayNumbers = new int[] { 10, 9, 6, 2, 7, 4, 7, 6, 5, 8, 4};

        int[] arraySorted = new int[arrayNumbers.Length];
        int bestIndex = 0;

        for (int i = 0; i < arrayNumbers.Length; i++)
        {
            int[] arrayTemp = new int[arrayNumbers.Length];
            int newIndex = 0;
            arrayTemp[newIndex] = arrayNumbers[i];

            for (int j = i; j < arrayNumbers.Length - 1; j++)
            {
                if (arrayNumbers[j + 1] > arrayTemp[newIndex])
                {
                    newIndex++;
                    arrayTemp[newIndex] = arrayNumbers[j + 1];
                }
                else if ((newIndex > 0) && (arrayNumbers[j + 1] == arrayTemp[newIndex]))
                {
                    newIndex++;
                    arrayTemp[newIndex] = arrayNumbers[j + 1];
                }
                else if((newIndex > 0) && (arrayNumbers[j + 1] > arrayTemp[newIndex - 1]))
                {
                    arrayTemp[newIndex] = arrayNumbers[j + 1];
                }
            }
            if (newIndex > bestIndex)
            {
                bestIndex = newIndex;
                for (int k = 0; k < arrayTemp.Length; k++)
                {
                    arraySorted[k] = arrayTemp[k];
                }
            }
            else if((newIndex == bestIndex) && (arrayTemp[0] < arraySorted[0]))
            {
                for (int k = 0; k < arrayTemp.Length; k++)
                {
                    arraySorted[k] = arrayTemp[k];
                }
            }
        }
        for (int i = 0; i <= bestIndex; i++)
        {
            Console.WriteLine(arraySorted[i]);
        }
    }
}
