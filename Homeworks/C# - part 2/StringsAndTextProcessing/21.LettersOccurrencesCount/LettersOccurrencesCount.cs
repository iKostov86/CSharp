using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LettersOccurrencesCount
{
    static void Main()
    {
        string input = "Baba mi e strasha jena, mnogo golqma e sha znaesh!";
        Dictionary<char, int> myDict = new Dictionary<char, int>();

        for (int i = 0; i < input.Length; i++)
        {
            if (char.IsLetter(input[i]))
            {
                if (myDict.Keys.Contains(input[i]))
                {
                    myDict[input[i]]++;
                }
                else
                {
                    myDict[input[i]] = 1;
                }
            }
        }

        myDict.OrderBy(x => x.Key);

        foreach (var item in myDict)
        {
            Console.WriteLine("{0} -> {1}", item.Key, item.Value);
        }
    }
}
