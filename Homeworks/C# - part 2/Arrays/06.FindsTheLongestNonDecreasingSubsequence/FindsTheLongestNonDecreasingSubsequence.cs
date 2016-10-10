using System;

public class FindsTheLongestNonDecreasingSubsequence
{
    const int MAX = 15;
    static int[,] lns = new int[MAX, MAX];

    internal static void Main(string[] args)
    {
        //DateTime start = DateTime.Now;

        int[] x = { 10, 7, 8, 9, 2, 3 };    // we don't use the first element (100)
        int lnsLen = GetLnsLength(x);
        Console.Write("The length of the longest non-decreasing subsequence is: {0}", lnsLen);
        Console.WriteLine();
        Console.Write("The subsequence is: ");
        PrintSubsequence(x, x.Length - 1, lnsLen);

        //Console.WriteLine(DateTime.Now - start);
    }

    public static int GetLnsLength(int[] x)
    {
        int i, j, count;
        int len = x.Length;

        for (i = 0; i < len; i++)
        {
            for (j = 1; j < len; j++)

                lns[i, j] = MAX + 1;
            lns[i, 0] = -1;
        }

        count = 1;
        for (i = 1; i < len; i++)
        {
            for (j = 1; j < len; j++)
            {
                if (lns[i - 1, j - 1] <= x[i] && x[i] <= lns[i - 1, j] && lns[i - 1, j - 1] <= lns[i - 1, j])
                {
                    lns[i, j] = x[i];
                    if (count < j)
                        count = j;
                }
                else
                {
                    lns[i, j] = lns[i - 1, j];
                }
            }
        }
        return count;
    }

    static void PrintSubsequence(int[] x, int i, int j)
    {
        if (0 == i) return;
        if (lns[i, j] == lns[i - 1, j])
        {
            PrintSubsequence(x, i - 1, j);
        }
        else
        {
            PrintSubsequence(x, i, j - 1);
            Console.Write(x[i] + " ");
        }
    }
}