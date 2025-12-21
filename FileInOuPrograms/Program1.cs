using System;
using System.IO;

namespace FileIOPrograms
{
    class Program1
    {
        static void Main()
        {
            string filePath = "sample.txt";//stores in C:\Users\Sinchana .A.N\source\repos\FileInOuPrograms\bin\Debug\net8.0

            TextFileManager textFileManager = new TextFileManager();
            // 1. WRITE to file
            textFileManager.WriteText(filePath, "Hello, this is the first line.\n");

            // 2. APPEND to file
            textFileManager.AppendText(filePath, "This is an appended line.\n");

            // 3. READ from file
            string content = textFileManager.ReadText(filePath);

            Console.WriteLine("File Content:\n");
            Console.WriteLine(content);

            //4.DELETE the file
            // textFileManager.DeleteFile(filePath);

            Console.WriteLine("------------------------------------------");

            string path = "streamfile.txt";

            // Write using StreamWriter
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine("Line 1: Written with StreamWriter");
                sw.WriteLine("Line 2: Another line");
            }

            /* using(){} block used to close the file automatically*/

            // Read using StreamReader
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                Console.WriteLine("Reading file line-by-line:\n");

                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
