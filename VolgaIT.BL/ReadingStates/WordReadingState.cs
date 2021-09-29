using System;
using System.Linq;
using System.IO;

namespace VolgaIT.BL.ReadingStates
{
    public class WordReadingState : IHTMLReadingState
    {
        private string _currentWord = string.Empty;

        public void Read(WordCountService wordCounter, StreamReader reader)
        {
            var c = (char)reader.Read();
            if (wordCounter.Separators.Contains(c))
            {
                SaveWord(wordCounter.WordSaver, wordCounter);
            }
            else if (c == '<')
            {
                SaveWord(wordCounter.WordSaver, wordCounter);
                wordCounter.ChangeState(new TagReadingState());
            }
            // При встрече со спец символами
            else if(c == '&')
            {
                SaveWord(wordCounter.WordSaver, wordCounter);
                wordCounter.ChangeState(new CharWaitingState(';', new WordReadingState()));
            }
            else
            {
                if(_currentWord.Length > wordCounter.MaxWordLength)
                    throw new Exception("Превышен максимальный размер слова");
                if(!wordCounter.IgnoredChars.Contains(c))
                    _currentWord += c.ToString();
            }
        }

        private void SaveWord(IWordSaver wordSaver, WordCountService wordCounter)
        {
            if(!string.IsNullOrEmpty(_currentWord) && !wordCounter.NeitherWordNorSeparators.Contains(_currentWord))
                wordSaver.AddWord(_currentWord);
            _currentWord = string.Empty;
        }
    }
}
