using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class ReverseWordsInSentence
{
    static void Main()
    {
        //v.1

        //string input = "C# is not C++, not PHP and not Delphi!";
        //string[] allSeparate = input.Split(new[] { ' ', '!' }, StringSplitOptions.RemoveEmptyEntries);

        //var endMark = input[input.Length - 1];
        //var commaPosition = Array.FindIndex(allSeparate, x => x.Contains(','));

        //allSeparate = allSeparate.Select((s, x) => s.Replace(",", "")).ToArray();

        //for (int i = allSeparate.Length - 1; i >= 0; i--)
        //{
        //    Console.Write(allSeparate[i]);

        //    if (i == allSeparate.Length - commaPosition - 1)
        //    {
        //        Console.Write(", ");
        //    }
        //    else if (i != 0) 
        //    {
        //        Console.Write(" ");
        //    }
        //    else
        //    {
        //        Console.WriteLine(endMark); 
        //    }
        //}

        //v.2

        //string sentence = "C# is not C++, not PHP and not Delphi!";
        //// get sentence ending char
        //char lastChar = sentence[sentence.Length - 1];
        //sentence = sentence.Substring(0, sentence.Length - 1);
        //string[] words = sentence.Split(' ');
        //// get all comma positions and remove from words
        //List<int> commas = new List<int>();
        //for (int i = 0; i < words.Length; i++)
        //{
        //    if (words[i].Contains(","))
        //    {
        //        commas.Add(i);
        //        words[i] = words[i].Substring(0, words[i].Length - 1);
        //    }
        //}
        //// reverse words
        //Array.Reverse(words);
        //// insert commas at original positions into reversed array
        //if (commas.Count > 0)
        //{
        //    for (int i = 0; i < commas.Count; i++)
        //    {
        //        words[commas[i]] += ',';
        //    }
        //}
        //// join reversed words back into sentence
        //string reversedSentence = String.Join(" ", words) + lastChar;
        //Console.WriteLine(reversedSentence);

        //v.3

        string input = "C# is not C++, not PHP and not Delphi!";
        string output = "Delphi not and PHP, not C++ not is C#!";

        char[] separators = new char[] { ' ', ',', ':', ';', '.', '!', '?' };

        var myBuilder = new StringBuilder();
        var separateWords = new Stack<string>();
        var separateSigns = new Queue<string>();

        var words = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        var signs = input.Where(x => separators.Contains(x));

        foreach (var word in words)
        {
            separateWords.Push(word);
        }

        foreach (var sign in signs)
        {
            separateSigns.Enqueue(sign.ToString());
        }

        while (separateWords.Count > 0 || separateSigns.Count > 0)
        {
            if (separateWords.Count > 0)
            {
                myBuilder.Append(separateWords.Pop());
            }
            if (separateSigns.Count > 0)
            {
                if (separateSigns.Peek() == ",")
                {
                    myBuilder.Append(separateSigns.Dequeue());
                }

                myBuilder.Append(separateSigns.Dequeue());
            }
        }

        Console.WriteLine(myBuilder);

        //v.4

        //string input = "C# is not C++, not PHP and not Delphi!";
        //string output = "Delphi not and PHP, not C++ not is C#!";
        
        //char[] separators = new char[] { ' ', ',', ':', ';', '.', '!', '?' };
        ////char[] separators = "QWERTYUIOPASDFGHJKLZXCVBNM#+".ToCharArray();
        //string regex = @"\s+|,\s*|;\s*|:\s*|-\s*|\.\s*|!\s*|\?\s*";

        ////var words = Regex.Split(input, regex);
        //var words = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        //var signs = Regex.Matches(input, regex);

        //int count = words.Count();

        //foreach (var sign in signs)
        //{
        //    if (count > 0)
        //    {
        //        Console.Write(words[count - 1]);
        //        count--;
        //    }
        //    Console.Write(sign);
        //}

        //while (count > 0)
        //{
        //    Console.Write(words[count - 1]);
        //    count--;
        //}

        //Console.WriteLine();
    }
}
