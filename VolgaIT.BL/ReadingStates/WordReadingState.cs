using System;
using System.Linq;
using System.IO;

namespace VolgaIT.BL.ReadingStates
{
    public class WordReadingState : IHTMLReadingState
    {
        private string _currentWord;

        public void Read(WordCountService wordCounter, StreamReader reader)
        {
            var c = (char)reader.Read();
            if (wordCounter.Separators.Contains(c))
            {
                SaveWord(wordCounter.WordSaver);
            }
            else if (c == '<')
            {
                SaveWord(wordCounter.WordSaver);
                wordCounter.ChangeState(new TagReadingState());
            }
            else
            {
                if(_currentWord.Length > wordCounter.MaxWordLength)
                    throw new Exception("Превышен максимальный размер слова");
                _currentWord += c.ToString();
            }
        }

        private void SaveWord(IWordSaver wordSaver)
        {
            wordSaver.AddWord(_currentWord);
            _currentWord = string.Empty;
        }
    }
}
