using System;

class MagicWords
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int maxLen = new int();
        string[] words = new string[n];
        
        for (int i = 0; i < n; i++)
        {
            words[i] = Console.ReadLine();

            if (words[i].Length > maxLen)
            {
                maxLen = words[i].Length;
            }
        }

        for (int i = 0; i < n; i++)
        {
            int position = words[i].Length % (n + 1);
            string temp = words[i];

            if (position <= 0)
            {
                position = 0;
            }
            else
            {
                position--;
            }

            words[i] = words[position];
            words[position] = temp;
        }

        Print (words, maxLen);
    }

    public static void Print (string[] words, int maxLen)
    {
        for (int i = 0; i < maxLen; i++)
        {
            for (int j = words.Length - 1; j >= 0 ; j--)
            {
                if (words[j].Length >= i)
                {
                    Console.WriteLine(words[j][i]);
                }
            }
        }
    }
}
