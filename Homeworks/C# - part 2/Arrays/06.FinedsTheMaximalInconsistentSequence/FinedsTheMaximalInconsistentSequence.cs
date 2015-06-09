//using System;

//class FinedsTheMaximalInconsistentSequence
//{
//    static void Main()
//    {

//        DateTime start = DateTime.Now;
//        int[] array = new int[] { 9, 6, 2, 7, 4, 7, 6, 5, 8, 4 };
//        int[] bestSequence = new int[array.Length];
//        int bestLength = 1;

//        for (int startPos = 0; startPos < array.Length; startPos++)
//        {
//            int[] tempSequence = new int[array.Length];
//            tempSequence[0] = array[startPos];
//            int tempLength = 1;
//            int tempIndex = 1;

//            for (int tempPos = startPos + 1; tempPos < array.Length; tempPos++)
//            {
//                if (array[tempPos] > tempSequence[tempIndex - 1])
//                {
//                    tempSequence[tempIndex] = array[tempPos];
//                    tempIndex++;
//                    tempLength++;
//                }
//                else if (tempIndex > 1 && array[tempPos] < tempSequence[tempIndex - 1] && array[tempPos] > tempSequence[tempIndex - 2])
//                {
//                    tempSequence[tempIndex - 1] = array[tempPos];
//                }
//            }

//            if (tempLength > bestLength)
//            {
//                bestLength = tempLength;
//                bestSequence = tempSequence;
//            }
//        }

//        for (int i = 0; i < bestLength; i++)
//        {
//            Console.WriteLine("{0} ", bestSequence[i]);
//        }

//        Console.WriteLine(DateTime.Now - start);
//    }
//}




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LongestNonDecreasingSubsequenceOP
{
    class LNSeq
    {
        const int MAX = 15;
        static int[,] LNS = new int[MAX, MAX];
        static int LNS_Length(int[] x)
        {
            int i, j, count;
            for (i = 0; i < x.Length; i++)
            {
                for (j = 1; j < x.Length; j++)

                    LNS[i, j] = MAX + 1;
                LNS[i, 0] = -1;
            }
            count = 1;
            for (i = 1; i < x.Length; i++)
            {
                for (j = 1; j < x.Length; j++)
                {
                    if (LNS[i - 1, j - 1] <= x[i] && x[i] <= LNS[i - 1, j] && LNS[i - 1, j - 1] <= LNS[i - 1, j])
                    {
                        LNS[i, j] = x[i];
                        if (count < j)
                            count = j;
                    }
                    else
                    {
                        LNS[i, j] = LNS[i - 1, j];
                    }
                }
            }
            return count;
        }

        static void PrintSubsequence(int[] x, int i, int j)
        {
            if (0 == i) return;
            if (LNS[i, j] == LNS[i - 1, j])
            {
                PrintSubsequence(x, i - 1, j);
            }
            else
            {
                PrintSubsequence(x, i, j - 1);
                Console.Write(x[i] + " ");
            }
        }


        static void Main(string[] args)
        {

            DateTime start = DateTime.Now;
            int[] x = { 10, 7, 8, 9, 2, 3};// we dont't use the first element(100)
            Console.Write("The length of the longest non-decreasing subsequence is: {0}", LNS_Length(x));
            Console.WriteLine();
            Console.Write("The subsequence is: ");
            PrintSubsequence(x, x.Length - 1, LNS_Length(x));

            Console.WriteLine(DateTime.Now - start);

        }
    }
}




//using System;

//class FinedsTheMaximalInconsistentSequence
//{
//    static void Main()
//    {
//        int[] arrayNum = { 9, 6, 2, 7, 4, 7, 6, 5, 8, 4 };
//        int length = arrayNum.Length;
//        int[,] dynamic = new int[length, length];

//        int position = 0;

//        for (int i = 0; i < length; i++)
//        {
            
//        }
//    }
//}