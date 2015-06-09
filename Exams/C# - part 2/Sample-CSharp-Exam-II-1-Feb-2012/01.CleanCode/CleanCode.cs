using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CleanCode
{
    static void Main()
    {
        //int numberN = int.Parse(Console.ReadLine());
        Console.Clear();

        List<string> myList = new List<string>();
        myList.Add("using System; // no comment...");
        myList.Add("class JustClass");
        myList.Add("{ /* Just");
        myList.Add("multiline");
        myList.Add("comment */private void JustMethod()");
        myList.Add(" {");
        myList.Add("// string str=\"inception/*//*/;");
        myList.Add(" }");
        myList.Add("}");

        //List<string> myList = new List<string>();
        //myList.Add("class HardTest");
        //myList.Add("{");
        //myList.Add("public HardMethod()");
        //myList.Add(" {");
        //myList.Add(@"string str = @""//not a");
        //myList.Add(@"comment ;)"";//(y)");
        //myList.Add(@"string str2 = ""/*no\""oo\\oo*/"";/*noo*/");
        //myList.Add(@" }");
        //myList.Add(@"}");

        foreach (var item in myList)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("\r\n\r\n");

        StringBuilder myBuilder = new StringBuilder();

        bool inSingleLineComment = false;
        bool inMultiLineComment = false;
        bool inSingleLineString = false;
        bool inMultiLineString = false;

        for (int i = 0; i < myList.Count; i++)
        {
            string line = myList[i];

            for (int j = 0; j < line.Length; j++)
            {
                // in singleline comment
                if (inSingleLineComment)
                {
                    inSingleLineComment = false;
                    if (line.Substring(0, line.IndexOf('/')) == "")
                    {
                        line = string.Empty;
                    }

                    break;
                }
                // in multiline comment
                else if (inMultiLineComment)
                {
                    if ((j + 1) < line.Length && 
                        line[j] == '*' &&
                        line[j + 1] == '/')
                    {
                        inMultiLineComment = false;
                        j++;
                    }

                    continue;
                }
                // in singleline string
                else if (inSingleLineString)
                {
                    myBuilder.Append(line[j]);

                    if ((j + 1) < line.Length &&
                        line[j] == '"' &&
                        line[j + 1] == ';')
                    {
                        myBuilder.Append(line[j + 1]);
                        inSingleLineString = false;
                        j++;
                    }

                    continue;
                }
                // in multiline string
                else if(inMultiLineString)
                {
                    myBuilder.Append(line[j]);

                    if ((j + 1) < line.Length &&
                        line[j] == '"' &&
                        line[j + 1] == ';')
                    {
                        inMultiLineString = false;
                    }

                    continue;
                }
                else
                {
                    // chek for singleline comment
                    if ((j + 1) < line.Length &&
                        line[j] == '/' &&
                        line[j + 1] == '/')
                    {
                        inSingleLineComment = true;
                        j++;
                        continue;
                    }
                    // chek for multiline comment
                    if ((j + 1) < line.Length &&
                        line[j] == '/' &&
                        line[j + 1] == '*')
                    {
                        inMultiLineComment = true;
                        j++;
                        continue;
                    }
                    // chek for singleline string
                    if (line[j] == '"')
                    {
                        inSingleLineString = true;
                        myBuilder.Append(line[j]);
                        continue;
                    }
                    // chek for multiline string
                    if ((j + 1) < line.Length &&
                        line[j] == '@' &&
                        line[j + 1] == '"')
                    {
                        inMultiLineString = true;
                        myBuilder.Append(line[j]);
                        myBuilder.Append(line[j + 1]);
                        j++;
                        continue;
                    }
                }

                myBuilder.Append(line[j]);
            }

            if (line != string.Empty && !inMultiLineComment)
            {
                myBuilder.AppendLine();
            }
        }

        Console.WriteLine(myBuilder);
    }
}
