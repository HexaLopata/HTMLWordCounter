using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

namespace VolgaIT.BL
{
    public class QuickFileWordSaver : IWordSaver
    {
        public bool IgnoreCase { get; set; }
        private Dictionary<string, int> _words = new Dictionary<string, int>();

        private FileStream _writer;
        private readonly string _filePath;

        public QuickFileWordSaver(string filePath)
        {
            _filePath = filePath;
        }

        public void AddWord(string word)
        {
            if (_words.ContainsKey(word))
            {
                _words[word] += 1;
            }
            else
            {
                _words.Add(word, 1);
            }
        }

        public void Clear()
        {
            _words.Clear();
        }

        public void SaveAll()
        {
            _words = new Dictionary<string, int>(_words.OrderByDescending((kw) => kw.Value));
            if(File.Exists(_filePath))
                File.Delete(_filePath);
            using (_writer = File.OpenWrite(_filePath))
            {
                foreach (var kw in _words)
                {
                    byte[] wordAsBytes = Encoding.UTF8.GetBytes(kw.Key + " - " + kw.Value + "\r\n");
                    _writer.Write(wordAsBytes, 0, wordAsBytes.Length);
                }
            }
            _words.Clear();
        }
    }
}
