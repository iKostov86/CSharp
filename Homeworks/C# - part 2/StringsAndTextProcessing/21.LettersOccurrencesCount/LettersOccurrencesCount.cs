using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class LettersOccurrencesCount
{
    internal static void Main()
    {
        string input = "Baba mi e strasha jena, mnogo golqma e sha znaesh!";
        var dict = CountLetters(input);

        dict.OrderBy(x => x.Key);
        PrintLettersOccurrences(dict);
    }

    public static Dictionary<char, int> CountLetters(string input)
    {
        Dictionary<char, int> dict = new Dictionary<char, int>();

        for (int i = 0, len = input.Length; i < len; i++)
        {
            if (char.IsLetter(input[i]))
            {
                if (dict.Keys.Contains(input[i]))
                {
                    dict[input[i]]++;
                }
                else
                {
                    dict[input[i]] = 1;
                }
            }
        }

        return dict;
    }

    public static void PrintLettersOccurrences(Dictionary<char, int> dict)
    {
        foreach (var item in dict)
        {
            Console.WriteLine("{0} -> {1}", item.Key, item.Value);
        }
    }
}
