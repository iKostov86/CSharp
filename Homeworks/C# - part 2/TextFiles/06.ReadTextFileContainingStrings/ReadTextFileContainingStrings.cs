using System;
using System.Collections.Generic;
using System.IO;

public class ReadTextFileContainingStrings
{
    internal static void Main()
    {
        string fileName = "input.txt";
        List<string> listOfNames = new List<string>();

        if (!File.Exists(fileName))
        {
            string createText = "Ivan" + Environment.NewLine +
                                "Peter" + Environment.NewLine +
                                "Maria" + Environment.NewLine +
                                "George" + Environment.NewLine;

            File.WriteAllText(fileName, createText);
        }

        TextReader myReader = new StreamReader(fileName);

        using (myReader)
        {
            string readLine = myReader.ReadLine();

            while (readLine != null)
            {
                listOfNames.Add(readLine);
                readLine = myReader.ReadLine();
            }
        }

        listOfNames.Sort();

        TextWriter myWriter = new StreamWriter("output.txt");

        using (myWriter)
        {
            for (int i = 0; i < listOfNames.Count; i++)
            {
                myWriter.WriteLine(listOfNames[i]);
            }
        }
    }
}
