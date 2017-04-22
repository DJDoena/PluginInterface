using System;
using System.IO;
using System.Text;

namespace MakeXmlComments
{
    public static class Program
    {
        public static void Main(String[] args)
        {
            if ((args == null) || (args.Length == 0))
            {
                Console.WriteLine("Invalid argument. Please specify path to PluginInterface.cs");

                return;
            }

            String fileName = args[0];

            if (File.Exists(fileName) == false)
            {
                Console.WriteLine("Invalid argument. PluginInterface.cs not found.");

                return;
            }

            ProcessFile(fileName);
        }

        private static void ProcessFile(String fileName)
        {
            StringBuilder outFile = new StringBuilder();

            Encoding encoding;
            using (StreamReader sr = new StreamReader(fileName))
            {
                encoding = sr.CurrentEncoding;

                while (sr.EndOfStream == false)
                {
                    String inFile = sr.ReadLine();

                    String[] split = inFile.Split(';');

                    if (split.Length > 1)
                    {
                        String comment = split[1];

                        if (comment.Contains("//"))
                        {
                            RewriteLine(outFile, split[0], comment);

                            continue;
                        }
                    }

                    outFile.AppendLine(inFile);
                }
            }

            using (StreamWriter sw = new StreamWriter(fileName, false, encoding))
            {
                sw.Write(outFile.ToString());
            }
        }

        private static void RewriteLine(StringBuilder outFile
            , String code
            , String comment)
        {
            comment = comment.Trim().Replace("//", String.Empty).Trim();

            String indentation = code.Substring(0, code.Length - code.TrimStart().Length);

            outFile.Append(indentation);
            outFile.AppendLine("///<summary>");
            outFile.Append(indentation);
            outFile.Append("/// ");
            outFile.AppendLine(comment);
            outFile.Append(indentation);
            outFile.AppendLine("///</summary>");
            outFile.Append(code);
            outFile.AppendLine(";");
        }
    }
}