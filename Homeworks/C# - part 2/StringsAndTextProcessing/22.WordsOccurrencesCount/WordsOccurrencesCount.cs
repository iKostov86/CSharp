using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class WordsOccurrencesCount
{
    static void Main()
    {
        string input = "Baba mi e strasha jena, mnogo golqma e sha znaesh!";
        var separateWords = input.Split(new char[] { ' ' }).Select(x => x.TrimEnd(new char[] { ',', '.', '!', '?', ';', ':' }).ToLower());

        Dictionary<string, int> myDict = new Dictionary<string, int>();

        foreach (var word in separateWords)
        {
            if (myDict.Keys.Contains(word))
            {
                myDict[word]++;
            }
            else
            {
                myDict[word] = 1;
            }
        }

        myDict.OrderBy(x => x.Key);

        foreach (var item in myDict)
        {
            //Console.WriteLine(item.Key + "->".PadLeft(10 - item.Key.Length) + item.Value.ToString().PadLeft(5));
            Console.WriteLine(item.Value + item.Key.ToString().PadLeft(10));
           // Console.WriteLine("{0} -> {1}", item.Key, item.Value);
        }
        Console.WriteLine();
    }
}
