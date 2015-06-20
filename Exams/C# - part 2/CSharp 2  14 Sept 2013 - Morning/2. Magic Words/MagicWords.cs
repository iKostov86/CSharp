using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class MagicWords
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int maxLen = new int();
        List<string> words = new List<string>();
        
        for (int i = 0; i < n; i++)
        {
            words.Add(Console.ReadLine());

            if (words[i].Length > maxLen)
            {
                maxLen = words[i].Length;
            }
        }

        for (int i = 0; i < n; i++)
        {
            int newPosition = words[i].Length % (n + 1);

            words.Insert(newPosition, words[i]);

            if (newPosition < i)
            {
                words.RemoveAt(i + 1);
            }
            else
            {
                words.RemoveAt(i);
            }
        }

        Print(words, maxLen);
    }

    public static void Print(List<string> words, int maxLen)
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < maxLen; i++)
        {
            for (int j = 0; j < words.Count; j++)
            {
                if (words[j].Length > i)
                {
                    sb.Append(words[j][i]);
                }
            }
        }

        Console.WriteLine(sb);
    }
}
