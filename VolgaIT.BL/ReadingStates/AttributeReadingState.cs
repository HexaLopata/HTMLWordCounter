using System;
using System.IO;
using System.Linq;

namespace VolgaIT.BL.ReadingStates
{
    public class AttributeReadingState : IHTMLReadingState
    {
        private string _currentTag = string.Empty;
        private bool _isInQuotationMarks = false;

        public AttributeReadingState(string currentTag)
        {
            _currentTag = currentTag;
        }

        public void Read(WordCountService wordCounter, StreamReader reader)
        {
            var c = (char)reader.Read();
            if ((c == '"' || c == '\''))
                _isInQuotationMarks = !_isInQuotationMarks;
            if (!_isInQuotationMarks)
            {
                if (c == '/')
                {
                    wordCounter.IsCurrentTagClosed = true;
                    if (_currentTag != string.Empty)
                    {
                        CheckForIgnoredTags(wordCounter);
                        if (wordCounter.IsIgnoringCurrentTag)
                        {
                            wordCounter.ChangeState(new TagCheckingState(_currentTag));
                        }
                    }
                }
                else if (c == '>')
                {
                    if (wordCounter.IsCurrentTagClosed)
                    {
                        wordCounter.ChangeState(new WordReadingState());
                    }
                    else
                    {
                        if (wordCounter.IsIgnoringCurrentTag)
                        {
                            wordCounter.ChangeState(new TagCheckingState(_currentTag));
                        }
                        else
                        {
                            wordCounter.ChangeState(new WordReadingState());
                        }
                    }
                    wordCounter.IsCurrentTagClosed = false;
                }
                else if (c == '<')
                {
                    throw new Exception("Переданный html файл содержит ошибки синтаксиса");
                }

                void CheckForIgnoredTags(WordCountService wordCounter)
                {
                    if (!wordCounter.IsCurrentTagClosed && wordCounter.IgnoredTags.Contains(_currentTag))
                    {
                        wordCounter.IsIgnoringCurrentTag = true;
                    }
                    else
                    {
                        wordCounter.IsIgnoringCurrentTag = false;
                    }
                }
            }
        }
    }
}
