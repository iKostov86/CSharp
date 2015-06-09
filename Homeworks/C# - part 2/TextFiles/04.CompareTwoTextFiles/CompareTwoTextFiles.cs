using System;
using System.IO;

public class CompareTwoTextFiles
{
    internal static void Main()
    {
        string firstFileName = "inputOne.txt";
        string secondFileName = "inputTwo.txt";

        if (!File.Exists(firstFileName))
        {
            string createFirstText = "Hello and Welcome!" + Environment.NewLine + "How are you?";
            File.WriteAllText(firstFileName, createFirstText);
        }

        if (!File.Exists(secondFileName))
        {
            string createSecondText = "Hello and Welcome!" + Environment.NewLine + "What do you do?";
            File.WriteAllText(secondFileName, createSecondText);
        }

        try
        {
            TextReader myFirstReader = new StreamReader(firstFileName);
            TextReader mySecondReader = new StreamReader(secondFileName);

            int sameLineCount = 0;
            int diffLineCount = 0;

            using (myFirstReader)
            {
                using (mySecondReader)
                {
                    string firstLine = myFirstReader.ReadLine();
                    string secondLine = mySecondReader.ReadLine();

                    while (firstLine != null || secondLine != null)
                    {
                        if (firstLine == secondLine)
                        {
                            sameLineCount++;
                        }
                        else
                        {
                            diffLineCount++;
                        }

                        firstLine = myFirstReader.ReadLine();
                        secondLine = mySecondReader.ReadLine();
                    }
                }
            }

            Console.WriteLine("The number of lines that are the same is: {0}", sameLineCount);
            Console.WriteLine("The number of lines that are different is: {0}", diffLineCount);
        }
        catch
        {
            Console.Error.WriteLine("Error!");
        }
    }
}
