using System;
using System.IO;

namespace FileIOPrograms
{
    public class TextFileManager
    {
        public void WriteText(string filePath, string content)
        {
            File.WriteAllText(filePath, content);
        }

        public string ReadText(string filePath)
        {
            return File.ReadAllText(filePath);
        }

        public void AppendText(string filePath, string content)
        {
            File.AppendAllText(filePath, content);
        }

        public void DeleteFile(string filePath)
        {
            File.Delete(filePath);
        }
    }
}