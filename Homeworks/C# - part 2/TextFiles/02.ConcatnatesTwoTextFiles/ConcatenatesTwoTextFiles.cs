using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ConcatenatesTwoTextFiles
{
    internal static void Main()
    {
        ////string fileName1 = "TextFile1.txt";
        ////string fileName2 = "TextFile2.txt";

        ////TextReader myReader1 = new StreamReader(fileName1);
        ////TextReader myReader2 = new StreamReader(fileName2);

        ////string fileName3 = myReader1.ReadToEnd() + myReader2.ReadToEnd();
        ////TextWriter myWriter3 = new StreamWriter("TextFile3.txt");
        ////myWriter3.Write(fileName3);

        ////myReader1.Close();
        ////myReader2.Close();
        ////myWriter3.Close();

        try
        {
            string file1 = @"../../input1.txt";
            string file2 = @"../../input2.txt";

            if (File.Exists(file1) && File.Exists(file2))
            {
                file1 = File.ReadAllText(@"../../input1.txt");
                file2 = File.ReadAllText(@"../../input2.txt");
                File.WriteAllText(@"../../output3.txt", file1 + file2);
                Console.WriteLine("File is written to the project's directory.");
            }
        }
        catch
        {
            Console.Error.WriteLine("Error!");
        }
    }
}
