using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

public class ReplaceSubstringInATextFile
{
    public const string OldStr = "start";
    public const string NewStr = "finish";

    internal static void Main()
    {
        string inputName = "input.txt";
        string outputName = "output.txt";

        if (!File.Exists(inputName))
        {
            string createText = "start" + Environment.NewLine +
                                "start" + Environment.NewLine +
                                "start" + Environment.NewLine +
                                "start" + Environment.NewLine;

            File.WriteAllText(inputName, createText);
        }

        using (TextWriter myWriter = new StreamWriter(outputName))
        {
            using (TextReader myReader = new StreamReader(inputName))
            {
                string readLine = myReader.ReadLine();

                while (readLine != null)
                {
                    readLine = readLine.Replace(OldStr, NewStr);
                    myWriter.WriteLine(readLine);
                    readLine = myReader.ReadLine();
                }
            }
        }

        ////Regex wordRgx = new Regex(oldStr, RegexOptions.IgnoreCase);

        ////using (StreamReader sr = new StreamReader(inputName))
        ////{
        ////    using (StreamWriter sw = new StreamWriter(outputName))
        ////    {
        ////        string line;
        ////        while ((line = sr.ReadLine()) != null)
        ////        {
        ////            sw.WriteLine(wordRgx.Replace(line, newStr));
        ////        }
        ////    }
        ////}
    }
}
