using System;
using System.IO;
using System.Linq;

public class ReadAndPrintTextFilesOnTheConsoleItsOddLines
{
    internal static void Main()
    {
        ////string fileName = "Test.txt";
        ////TextReader myReader = new StreamReader(fileName);

        ////using (myReader)
        ////{
        ////    bool lineIsOdd = true;
        ////    string line = string.Empty;

        ////    do
        ////    {
        ////        line = myReader.ReadLine();

        ////        if (lineIsOdd)
        ////        {
        ////            Console.WriteLine(line);
        ////            lineIsOdd = false;
        ////        }
        ////        else
        ////        {
        ////            lineIsOdd = true;
        ////        }

        ////    } while (line != null);
        ////}

        string[] allLines = System.IO.File.ReadAllLines(@"../../Test.txt");
        string[] oddLines = allLines.Where((line, index) => (index + 1) % 2 != 0).ToArray<string>();
        Console.WriteLine(string.Join("\n", oddLines));
    }
}
