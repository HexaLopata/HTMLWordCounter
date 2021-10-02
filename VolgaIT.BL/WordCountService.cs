using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
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
        public int MaxWordLength { get; set; } = 100;
        public int MaxTagLength => 15;
        public string[] IgnoredTags { get; set;  } = new string[] { "style", "script" };
        public char[] Separators => _separators;
        public bool IsIgnoringCurrentTag { get; set; }
        public bool IsCurrentTagClosed { get; set; }
        public IWordSaver WordSaver { get; set; }
        public char[] IgnoredChars => _ignoredChars;
        public string[] NeitherWordNorSeparators => _neitherWordNorSeparators;

        private IHTMLReadingState _state = new WordReadingState();
        private readonly char[] _separators = new char[]
        { ' ', ',', '.', ':', '!', '?', ';', '[', ']', '(', ')', '\n', '\t', '\r', '"', '{', '}', '…', '*', '»', '«', '’', '/', '=' };
        private readonly char[] _ignoredChars = new char[0];
        private readonly string[] _neitherWordNorSeparators = new string[] { "-", "–", "—" };

        public WordCountService(IWordCounterConfigurator configurator = null)
        {
            if (configurator != null)
                configurator.Configure(this);
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
            if (_state.GetType() != typeof(WordReadingState))
            {
                throw new Exception("Переданный html файл содержит ошибки синтаксиса");
            }
            WordSaver.SaveAll();
        }

        public void Analyze(string path)
        {
            Analyze(File.OpenText(path));
        }

        public void ChangeState(IHTMLReadingState state)
        {
            _state = state;
        }

        public async Task AnalyzeAsync(string path)
        {
            await Task.Run(() => Analyze(path));
        }

        public async Task AnalyzeAsync(StreamReader reader)
        {
            await Task.Run(() => Analyze(reader));
        }
    }
}