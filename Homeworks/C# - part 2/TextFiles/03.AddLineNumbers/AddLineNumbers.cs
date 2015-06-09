using System;
using System.IO;

public class AddLineNumbers
{
    internal static void Main()
    {
        string inputPath = "Input.txt";
        string outputPath = "Output.txt";

        if (!File.Exists(inputPath))
        {
            File.WriteAllText(inputPath, "Hello and Welcome!" + Environment.NewLine);
        }

        StreamReader myReader = new StreamReader(inputPath);
        StreamWriter myWriter = new StreamWriter(outputPath);

        try
        {
            string lineContent = string.Empty;
            int lineCount = 1;

            while (lineContent != null)
            {
                lineContent = myReader.ReadLine();
                myWriter.WriteLine(lineCount + ". " + lineContent);
                lineCount++;
            }
        }
        catch
        {
            Console.Error.WriteLine("Error!");
        }
        finally
        {
            myReader.Dispose();
            myWriter.Dispose();
        }
    }
}
