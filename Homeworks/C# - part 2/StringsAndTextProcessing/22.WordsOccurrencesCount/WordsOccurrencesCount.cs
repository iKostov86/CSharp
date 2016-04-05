using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class WordsOccurrencesCount
{
    //public static readonly Dictionary<string, int> example = new Dictionary<string, int> { { "one", 1}, { "two", 2 }, { "three", 3 } };

    internal static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        string input = "Baba a mi e strasha jena, mnogo mnogo golqma e sha znaesh!";

        // v.1
        //var separatedWords = input
        //    .Split(new char[] { ' ' })
        //    .Select(x => x.TrimEnd(new char[] { ',', '.', '!', '?', ';', ':' }));
        //var dict = CountWords(separatedWords);

        //PrintWordsOccurrences(dict);

        // v.2
        string regex = "(?i)[A-Z]+";
        var separatedWords = Regex.Matches(input, regex).Cast<Match>();
        var dict = CountWords(separatedWords);

        PrintWordsOccurrences(dict);
    }

    public static SortedDictionary<string, int> CountWords<T>(IEnumerable<T> separatedWords)
    {
        var dict = new SortedDictionary<string, int>();

        foreach (var word in separatedWords)
        {
            var key = word.ToString();

            if (dict.Keys.Contains(key))
            {
                dict[key]++;
            }
            else
            {
                dict[key] = 1;
            }
        }

        return dict;
    }

    public static void PrintWordsOccurrences<T>(SortedDictionary<T, int> dict)
    {
        foreach (var item in dict)
        {
            //Console.WriteLine(item.Key + "->".PadLeft(10 - item.Key.Length) + item.Value.ToString().PadLeft(5));
            //Console.WriteLine(item.Value + item.Key.ToString().PadRight(10));
            Console.WriteLine("{0} -> {1}", item.Key, item.Value);
        }
    }
}
