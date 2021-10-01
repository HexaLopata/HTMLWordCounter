using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace VolgaIT.BL
{
    public class SimpleWordSaver : IWordSaver
    {
        public bool IgnoreCase { get; set; }
        public string FilePath
        {
            get => _filePath;
            set => _filePath = value;
        }

        private List<string> _words = new List<string>();

        private FileStream _writer;
        private string _filePath;

        public SimpleWordSaver(string filePath = "output.txt")
        {
            Clear();
            _filePath = filePath;
        }

        public void AddWord(string word)
        {
            _words.Add(word);
        }

        public void Clear()
        {
            if (File.Exists(_filePath))
                File.Delete(_filePath);
            _words.Clear();
        }

        public void SaveAll()
        {
            if (File.Exists(_filePath))
                File.Delete(_filePath);
            using (_writer = File.OpenWrite(_filePath))
            {
                foreach (var word in _words)
                {
                    byte[] wordAsBytes = Encoding.UTF8.GetBytes(word + "\r\n");
                    _writer.Write(wordAsBytes, 0, wordAsBytes.Length);
                }
            }
            _words.Clear();
        }
    }
}
