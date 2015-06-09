using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;

namespace CustomException
{
    class CustomException
    {
        static void Main(string[] args)
        {
            string filePath = Console.ReadLine();
            string fileName = filePath.Substring(filePath.LastIndexOf('\\') + 1);
            try
            {
                string text = File.ReadAllText(filePath, Encoding.UTF8);
                string[] fileContent = text.Split('\n');
                long length = fileContent.Length;
                for (int line = 0; line < length; line++)
                {
                    ParseLine(fileName, fileContent[line].Trim(), line + 1);
                }
            }
            catch (FileParseException fpe)
            {
                Console.WriteLine(fpe.Message);
                Console.WriteLine(fpe.fileName);
                Console.WriteLine(fpe.lineNumber);
            }
        }

        static void ParseLine(string fileName, string lineOfFile, long lineNumber)
        {
            bool containesNumber = true;
            long length = lineOfFile.Length;
            for (int symbol = 0; symbol < length; symbol++)
            {
                if ((lineOfFile[symbol] < 47) || (lineOfFile[symbol] > 58))
                {
                    containesNumber = false;
                    break;
                }
            }
            if (!containesNumber)
            {
                throw new FileParseException(fileName, lineNumber);
            }
        }
    }

    class FileParseException : Exception
    {
        public string fileName { get; private set; }
        public long lineNumber { get; private set; }

        public FileParseException()
        {
        }

        public FileParseException(string fileName, long lineNumber)
            : base(string.Format("Error while parsing file {0} on line {1}.", fileName, lineNumber))
        {
            this.fileName = fileName;
            this.lineNumber = lineNumber;
        }
    }
}

