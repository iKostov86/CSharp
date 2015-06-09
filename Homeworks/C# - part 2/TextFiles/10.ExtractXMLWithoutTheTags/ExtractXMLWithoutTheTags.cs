using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class ExtractXMLWithoutTheTags
{
    internal static void Main()
    {
        List<char> listOfTags = new List<char> { '<', '>' };
        StringBuilder myBuilder = new StringBuilder();

        string inputName = "input.txt";

        if (!File.Exists(inputName))
        {
            string createText = @"<?xml version=""1.0""><student><name>Pesho</name>" + Environment.NewLine
                              + @"<age>21</age><interests count=""3""><interest>" + Environment.NewLine
                              + @"Games</instrest><interest>C#</instrest><interest>" + Environment.NewLine
                              + @"Java</instrest></interests></student>" + Environment.NewLine;

            File.WriteAllText(inputName, createText);
        }

        using (TextReader myReader = new StreamReader(inputName))
        {
            string readLine = myReader.ReadLine();
            bool bracketIsClose = true;

            while (readLine != null)
            {
                for (int i = 0; i < readLine.Length; i++)
                {
                    if (bracketIsClose)
                    {
                        if (!listOfTags.Contains(readLine[i]))
                        {
                            myBuilder.Append(readLine[i]);
                        }
                        else
                        {
                            bracketIsClose = false;
                        }
                    }
                    else if (listOfTags.Contains(readLine[i]))
                    {
                        bracketIsClose = true;
                    }
                }

                myBuilder.Append(Environment.NewLine);
                readLine = myReader.ReadLine();
            }
        }

        Console.WriteLine(myBuilder);
    }
}
