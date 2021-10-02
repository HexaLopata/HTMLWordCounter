using System;
using System.Linq;
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
                    wordCounter.ChangeState(new AttributeReadingState(_currentTag));
                    break;

                case '>':
                    CheckForIgnoredTags(wordCounter);

                    if (wordCounter.IsIgnoringCurrentTag)
                    {
                        wordCounter.ChangeState(new TagIgnoringState(_currentTag));
                    }
                    else
                    {
                        wordCounter.ChangeState(new WordReadingState());
                    }
                    wordCounter.IsCurrentTagClosed = false;
                    break;

                case '/':
                    wordCounter.IsCurrentTagClosed = true;
                    if (_currentTag != string.Empty)
                    {
                        CheckForIgnoredTags(wordCounter);
                        if (wordCounter.IsIgnoringCurrentTag)
                        {
                            wordCounter.ChangeState(new TagIgnoringState(_currentTag));
                        }
                    }

                    break;
                case '<':
                    throw new Exception("Переданный html файл содержит ошибки синтаксиса");

                default:
                    _currentTag += c;
                    if (_currentTag.Length > wordCounter.MaxTagLength)
                        throw new Exception("Переданный html файл содержит ошибки синтаксиса");
                    break;
            }

            void CheckForIgnoredTags(WordCountService wordCounter)
            {
                wordCounter.IsIgnoringCurrentTag = !wordCounter.IsCurrentTagClosed &&
                                                    wordCounter.IgnoredTags.Contains(_currentTag);
            }
        }
    }
}
