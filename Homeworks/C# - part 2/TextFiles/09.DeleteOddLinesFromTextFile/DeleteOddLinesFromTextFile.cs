using System;
using System.IO;
using System.Linq;

public class DeleteOddLinesFromTextFile
{
    internal static void Main()
    {
        string inputName = "input.txt";

        if (!File.Exists(inputName))
        {
            string createText = "This is first row." + Environment.NewLine
                              + "This is first row." + Environment.NewLine
                              + "This is second row." + Environment.NewLine
                              + "This is second row." + Environment.NewLine;

            File.WriteAllText(inputName, createText);
        }

        string[] readLines = File.ReadAllLines(inputName);
        readLines = readLines.Where((line, index) => (index + 1) % 2 != 0).ToArray();

        using (TextWriter myWriter = new StreamWriter(inputName))
        {
            for (int i = 0; i < readLines.Length; i++)
            {
                myWriter.WriteLine(readLines[i]);
            }
        }

        Console.WriteLine(string.Join("\n", readLines));
    }
}
