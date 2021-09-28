using System.Collections.Generic;
using System.IO;
using VolgaIT.BL.ReadingStates;

namespace VolgaIT.BL
{
    public class WordCountService : IWordCountService
    {
        public bool IgnoreCase
        {
            get
            {
                return WordSaver.IgnoreCase;
            }
            set
            {
                WordSaver.IgnoreCase = value;
            }
        }
        public int MaxWordLength { get; set; }
        public int MaxTagLength => 20;
        public List<string> IgnoredTags { get; } = new List<string>();
        public char[] Separators => _separators;
        public bool IsIgnoringCurrentTag { get; set; }
        public bool IsCurrentTagClosed { get; set; }
        public IWordSaver WordSaver { get; }

        private IHTMLReadingState _state;
        private char[] _separators = new char[] { ' ', ',', '.', ':', '!', '?', ';', '[', ']', '(', ')', '\n', '\t', '\r' };

        public WordCountService(IWordSaver wordSaver)
        {
            WordSaver = wordSaver;
        }

        public void Analyze(StreamReader reader)
        {
            using (reader)
            {
                do
                {
                    _state.Read(this, reader);
                }
                while (!reader.EndOfStream);
            }
        }

        public void Analyze(string path)
        {
            Analyze(File.OpenText(path));
        }

        public void ChangeState(IHTMLReadingState state)
        {
            _state = state;
        }
    }
}