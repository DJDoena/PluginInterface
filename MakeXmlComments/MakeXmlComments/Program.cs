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

            if (File.Exists(args[0]) == false)
            {
                Console.WriteLine("Invalid argument. PluginInterface.cs not found.");

                return;
            }

            StringBuilder outFile = new StringBuilder();

            using (StreamReader sr = new StreamReader(fileName))
            {
                while (sr.EndOfStream == false)
                {
                    String inFile = sr.ReadLine();

                    String[] split = inFile.Split(';');

                    if (split.Length > 1)
                    {
                        String comment = split[1];

                        if (comment.Contains("//"))
                        {
                            comment = comment.Trim().Replace("//", String.Empty).Trim();

                            String code = split[0];

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