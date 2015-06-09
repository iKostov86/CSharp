using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security;
using System.Threading.Tasks;

class FileNameWithFilePath
{
    static void Main()
    {
        string message1 = "Invalid path!";
        string message2 = "You don't have permission!";
        string path = @"D:\Cloud\Google Drive\VisualStudio2013\MyProjects\MyExercises\C# - part 2\ExceptionHandling\Test.txt";
        //string path = "   ";
        try
        {
            if (!File.Exists(path))
            {
                //Create a file to write to.
                string createText = "Hello and Welcome" + Environment.NewLine;
                File.WriteAllText(path, createText);
            }

            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);
        }
        catch (ArgumentException)
        {
            Console.WriteLine(message1);
        }
        catch (IOException)
        {
            Console.WriteLine(message1);
        }
        catch (NotSupportedException)
        {
            Console.WriteLine(message1);
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine(message2);
        }
        catch (SecurityException)
        {
            Console.WriteLine(message2);
        }
        catch (Exception exc)
        {
            Console.WriteLine(exc.Message);
        }
    }
}
