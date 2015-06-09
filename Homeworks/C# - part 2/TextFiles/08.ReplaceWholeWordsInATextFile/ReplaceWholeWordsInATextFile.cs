using System;
using System.IO;
using System.Text.RegularExpressions;

public class ReplaceWholeWordsInATextFile
{
    public const string OldStr = "start";
    public const string NewStr = "finish";

    internal static void Main()
    {
        string inputName = "input.txt";
        string outputName = "output.txt";

        if (!File.Exists(inputName))
        {
            string createText = "start" + " " + "start" + Environment.NewLine +
                                "startstart" + " " + "start" + Environment.NewLine +
                                "start" + Environment.NewLine +
                                "startstart" + Environment.NewLine;

            File.WriteAllText(inputName, createText);
        }

        using (StreamReader myReader = new StreamReader(inputName))
        {
            using (StreamWriter myWriter = new StreamWriter(outputName))
            {
                for (string readLine = myReader.ReadLine(); readLine != null; readLine = myReader.ReadLine())
                {
                    for (int i = readLine.IndexOf(OldStr); i != -1; i = readLine.IndexOf(OldStr, i + NewStr.Length))
                    {
                        if (((i - 1 < 0 || !char.IsLetter(readLine[i - 1])) && (i + OldStr.Length >= readLine.Length)) || !char.IsLetter(readLine[i + OldStr.Length]))
                        {
                            readLine = readLine.Insert(i, NewStr).Remove(i + NewStr.Length, OldStr.Length);
                        }
                    }

                    myWriter.WriteLine(readLine);
                }
            }
        }

        Console.WriteLine("Replacing done!");
    }
}
