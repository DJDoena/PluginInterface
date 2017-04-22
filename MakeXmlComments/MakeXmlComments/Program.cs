using System;
using System.IO;
using System.Text;

namespace MakeXmlComments
{
    public static class Program
    {
        public static void Main(String[] args)
        {
            StringBuilder outFile;
            String fileName;

            if ((args == null) || (args.Length == 0))
            {
                Console.WriteLine("Invalid argument. Please specify path to PluginInterface.cs");
                return;
            }
            fileName = args[0];
            if (File.Exists(args[0]) == false)
            {
                Console.WriteLine("Invalid argument. PluginInterface.cs not found.");
                return;
            }
            outFile = new StringBuilder();
            using (StreamReader sr = new StreamReader(fileName))
            {
                while (sr.EndOfStream == false)
                {
                    String inFile;
                    String[] split;

                    inFile = sr.ReadLine();
                    split = inFile.Split(';');
                    if (split.Length > 1)
                    {
                        String comment;

                        comment = split[1];
                        if (comment.Contains("//"))
                        {
                            Int32 countBlanks;
                            String blanks;
                            String code;

                            comment = comment.Trim().Replace("//", String.Empty).Trim();
                            code = split[0];
                            countBlanks = code.Length - code.TrimStart().Length;
                            blanks = String.Empty;
                            for (Int32 i = 0; i < countBlanks; i++)
                            {
                                blanks += " ";
                            }
                            outFile.Append(blanks);
                            outFile.AppendLine("///<summary>");
                            outFile.Append(blanks);
                            outFile.Append("/// ");
                            outFile.AppendLine(comment);
                            outFile.Append(blanks);
                            outFile.AppendLine("///</summary>");
                            outFile.Append(code);
                            outFile.AppendLine(";");
                        }
                        else
                        {
                            outFile.AppendLine(inFile);
                            continue;
                        }
                    }
                    else
                    {
                        outFile.AppendLine(inFile);
                        continue;
                    }
                }
            }
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                sw.Write(outFile.ToString());
            }
        }
    }
}