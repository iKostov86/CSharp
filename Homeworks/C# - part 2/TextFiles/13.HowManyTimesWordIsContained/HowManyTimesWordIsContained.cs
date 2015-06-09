using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

public class HowManyTimesWordIsContained
{
    internal static void Main()
    {
        string wordsPath = "words.txt";
        string textPath = "text.txt";
        string resultPath = "result.txt";

        Dictionary<string, int> mytDict = new Dictionary<string, int>();

        if (!File.Exists(wordsPath))
        {
            string createText = "zerou" + Environment.NewLine
                              + "one" + Environment.NewLine
                              + "two" + Environment.NewLine
                              + "three" + Environment.NewLine
                              + "four" + Environment.NewLine
                              + "five" + Environment.NewLine;

            File.WriteAllText(wordsPath, createText);
        }

        if (!File.Exists(textPath))
        {
            string createText = "one" + Environment.NewLine
                              + "two two" + Environment.NewLine
                              + "three three three" + Environment.NewLine
                              + "four four four four" + Environment.NewLine
                              + "five five five five five" + Environment.NewLine;

            File.WriteAllText(textPath, createText);
        }

        string[] words = File.ReadAllLines(wordsPath);
        ////string[] text = File.ReadAllText(textPath).Split(new string[] {" ", Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries);
        string[] text = File.ReadAllText(textPath).Split(default(string[]), StringSplitOptions.RemoveEmptyEntries);

        foreach (var word in words)
        {
            mytDict[word] = text.Count(x => x == word);
        }

        var sortedDict = mytDict.OrderByDescending(x => x.Value);

        foreach (var item in sortedDict)
        {
            File.AppendAllText(resultPath, item.Key + " - " + item.Value + Environment.NewLine);
        }
    }
}
