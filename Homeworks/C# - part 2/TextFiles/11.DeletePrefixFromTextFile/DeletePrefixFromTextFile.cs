using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

public class DeletePrefixFromTextFile
{
    internal static void Main()
    {
        const string GivenStr = "start";

        string inputName = "input.txt";
        ////string outputName = "output.txt";

        StringBuilder myReadBuilder = new StringBuilder();
        StringBuilder myWriteBuilder = new StringBuilder();

        if (!File.Exists(inputName))
        {
            string createText = "startMovie" + " " + "startAudio" + Environment.NewLine +
                                "softStart" + " " + "ebasiMamata" + Environment.NewLine +
                                "start" + Environment.NewLine +
                                "startstart" + Environment.NewLine;

            File.WriteAllText(inputName, createText);
        }

        using (StreamReader myReader = new StreamReader(inputName))
        {
            for (string readLine = myReader.ReadLine(); readLine != null; readLine = myReader.ReadLine())
            {
                for (int i = 0; i < readLine.Length; i++)
                {
                    myReadBuilder.Append(readLine[i]);

                    if ((!char.IsLetter(readLine[i]) && !char.IsDigit(readLine[i])) || i == readLine.Length - 1)
                    {
                        if (!myReadBuilder.ToString().StartsWith(GivenStr))
                        {
                            myWriteBuilder.Append(myReadBuilder);
                            myReadBuilder.Clear();
                        }
                        else
                        {
                            myReadBuilder.Clear();
                        }
                    }
                }

                if (myWriteBuilder.ToString() != string.Empty)
                {
                    myWriteBuilder.Append(Environment.NewLine);
                }
            }
        }

        using (StreamWriter myWriter = new StreamWriter(inputName))
        {
            myWriter.WriteLine(myWriteBuilder);
        }

        ////using(StreamReader myReader = new StreamReader(inputName))
        ////{
        ////    while (!myReader.EndOfStream)
        ////    {
        ////        string readLine = myReader.ReadLine();
        ////        string[] separatedWords = readLine
        ////            .Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
        ////            .Where(x => !x.StartsWith("start", StringComparison.OrdinalIgnoreCase))
        ////            .ToArray();

        ////        if (separatedWords.Length != 0)
        ////        {
        ////            myWriteBuilder.AppendLine(String.Join(" ", separatedWords));
        ////        }
        ////    }
        ////}

        ////using (StreamWriter myWriter = new StreamWriter(outputName))
        ////{
        ////    myWriter.Write(myWriteBuilder);
        ////}
    }
}
