using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

public class RemoveFromATextFileAllWordsListedInAnother
{
    internal static void Main()
    {
        string firstFileName = "firstFile.txt";
        string secondFileName = "secondFile.txt";
        char[] characters = new char[] { ' ', '\t' };

        List<string> firstFileWords = new List<string>();
        List<string> secondFileWords = new List<string>();

        StringBuilder myBuilder = new StringBuilder();

        if (!File.Exists(firstFileName))
        {
            string createText = "zerou" + Environment.NewLine
                              + "one" + Environment.NewLine
                              + "two" + Environment.NewLine
                              + "three" + Environment.NewLine
                              + "four" + Environment.NewLine
                              + "five" + Environment.NewLine
                              + "six" + Environment.NewLine
                              + "seven" + Environment.NewLine
                              + "eight" + Environment.NewLine
                              + "nine" + Environment.NewLine;

            File.WriteAllText(firstFileName, createText);
        }

        if (!File.Exists(secondFileName))
        {
            string createText = "one" + Environment.NewLine
                              + "three" + Environment.NewLine
                              + "five" + Environment.NewLine
                              + "seven" + Environment.NewLine
                              + "nine" + Environment.NewLine;

            File.WriteAllText(secondFileName, createText);
        }

        try
        {
            using (TextReader mySecondReader = new StreamReader(secondFileName))
            {
                string readSecondLine = mySecondReader.ReadLine();

                while (readSecondLine != null)
                {
                    secondFileWords.AddRange(readSecondLine.Split(characters, StringSplitOptions.RemoveEmptyEntries));
                    readSecondLine = mySecondReader.ReadLine();
                }

                using (TextReader myFirstReader = new StreamReader(firstFileName))
                {
                    string readFirstLine = myFirstReader.ReadLine();

                    while (readFirstLine != null)
                    {
                        firstFileWords.AddRange(readFirstLine.Split(characters, StringSplitOptions.RemoveEmptyEntries));
                        readFirstLine = myFirstReader.ReadLine();
                    }

                    for (int i = 0; i < firstFileWords.Count; i++)
                    {
                        if (secondFileWords.Contains(firstFileWords[i]))
                        {
                            firstFileWords.RemoveAt(i);
                        }
                    }
                }
            }

            File.WriteAllLines(firstFileName, firstFileWords);
        }
        catch (Exception)
        {
            throw;
        }
    }
}
