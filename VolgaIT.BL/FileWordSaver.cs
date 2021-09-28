using System;
using System.IO;

namespace VolgaIT.BL
{
    public class FileWordSaver : IWordSaver
    {
        public bool IgnoreCase { get; set; }

        private string _filePath;

        public FileWordSaver(string filePath)
        {
            _filePath = filePath;
        }

        public void AddWord(string word)
        {
            File.AppendAllText(_filePath, "\n" + word);
        }

        public void Clear()
        {
            File.WriteAllText(_filePath, string.Empty);
        }
    }
}
