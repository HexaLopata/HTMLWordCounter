using System;
using System.IO;

namespace VolgaIT.BL.ReadingStates
{
    public class TagReadingState : IHTMLReadingState
    {
        private string _currentTag = string.Empty;

        public void Read(WordCountService wordCounter, StreamReader reader)
        {
            var c = (char)reader.Read();
            switch (c)
            {
                case ' ':
                    if (wordCounter.IgnoredTags.Contains(_currentTag))
                        wordCounter.IsIgnoringCurrentTag = true;
                    _currentTag = string.Empty;
                    wordCounter.ChangeState(new AttributeReadingState());
                    break;

                case '>':
                    if (!wordCounter.IsCurrentTagClosed && wordCounter.IgnoredTags.Contains(_currentTag))
                    {
                        wordCounter.IsIgnoringCurrentTag = true;
                    }
                    else
                    {
                        wordCounter.IsIgnoringCurrentTag = false;
                    }

                    if (wordCounter.IsIgnoringCurrentTag)
                    {
                        wordCounter.ChangeState(new CharWaitingState('<', new TagReadingState()));
                    }
                    else
                    {
                        wordCounter.ChangeState(new WordReadingState());
                    }
                    wordCounter.IsCurrentTagClosed = false;
                    _currentTag = string.Empty;
                    break;

                case '/':
                    wordCounter.IsCurrentTagClosed = true;
                    break;
                case '<':
                    throw new Exception("Переданный html файл содержит ошибки синтаксиса");

                default:
                    _currentTag += c;
                    if (_currentTag.Length > wordCounter.MaxTagLength)
                        throw new Exception("Переданный html файл содержит ошибки синтаксиса");
                    break;

            }
        }
    }
}
