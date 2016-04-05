using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class ReverseWordsInSentence
{
    internal static void Main()
    {
        // v.1
        //string sentence = "C# is not C++, not PHP and not Delphi!";

        //// get sentence ending char
        //char lastChar = sentence[sentence.Length - 1];

        //sentence = sentence.Substring(0, sentence.Length - 1);
        //string[] words = sentence.Split(' ');

        //// get all comma positions and remove from words
        //List<int> commas = new List<int>();

        //for (int i = 0, len = words.Length; i < len; i++)
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
        //    for (int i = 0, count = commas.Count; i < count; i++)
        //    {
        //        words[commas[i]] += ',';
        //    }
        //}

        //// join reversed words back into a sentence
        //string reversedSentence = string.Join(" ", words) + lastChar;

        //Console.WriteLine(reversedSentence);

        // v.2
        //string input = "C# is not C++, not PHP and not Delphi!";
        //string output = "Delphi not and PHP, not C++ not is C#!";

        //char[] separators = new char[] { ' ', '.', ',', ';', ':', '!', '?' };

        //var sb = new StringBuilder();
        //var separateWords = new Stack<string>();
        //var separateSigns = new Queue<string>();

        //var words = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        //var signs = input.Where(x => separators.Contains(x));

        //foreach (var word in words)
        //{
        //    separateWords.Push(word);
        //}

        //foreach (var sign in signs)
        //{
        //    separateSigns.Enqueue(sign.ToString());
        //}

        //while (separateWords.Count > 0 || separateSigns.Count > 0)
        //{
        //    if (separateWords.Count > 0)
        //    {
        //        sb.Append(separateWords.Pop());
        //    }
        //    if (separateSigns.Count > 0)
        //    {
        //        if (separateSigns.Peek() == ",")
        //        {
        //            sb.Append(separateSigns.Dequeue());
        //        }

        //        sb.Append(separateSigns.Dequeue());
        //    }
        //}

        //Console.WriteLine(sb);

        // v.3
        //string input = "C# is not C++, not PHP and not Delphi!";
        //string output = "Delphi not and PHP, not C++ not is C#!";
        //string result = string.Empty;

        //char[] separators = new char[] { ' ', '.', ',', ';', ':', '!', '?' };
        //string regex = @"\s+|,\s*|;\s*|:\s*|-\s*|\.\s*|!\s*|\?\s*";

        ////var words = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        //var words = Regex.Split(input, regex).Where(w => w != string.Empty).ToArray();
        //var signs = Regex.Matches(input, regex);

        //int count = words.Length;

        //foreach (var sign in signs)
        //{
        //    if (count > 0)
        //    {
        //        result += words[count - 1];
        //        count--;
        //    }

        //    result += sign;
        //}

        //while (count > 0)
        //{
        //    result += words[count - 1];
        //    count--;
        //}

        //Console.WriteLine(result);
    }
}
