using System;
using System.IO;
using System.Text;

namespace VolgaIT.BL
{
    public class FileWordSaver : IWordSaver, IDisposable
    {
        public bool IgnoreCase { get; set; }

        private readonly string _filePath;
        private FileStream _writer;

        public FileWordSaver(string filePath)
        {
            _filePath = filePath;
            _writer = File.OpenWrite(filePath);
            Clear();
        }

        public void AddWord(string word)
        {
            if (!string.IsNullOrEmpty(word))
            {
                byte[] wordAsBytes = Encoding.Default.GetBytes(word + "\n");
                _writer.Write(wordAsBytes, 0, wordAsBytes.Length);
            }
        }

        public void Clear()
        {
            _writer.Close();
            File.WriteAllText(_filePath, string.Empty);
            _writer = File.OpenWrite(_filePath);
        }

        public void Dispose()
        {
            _writer.Close();
        }

        public void SaveAll()
        {
            _writer.Close();
        }
    }
}