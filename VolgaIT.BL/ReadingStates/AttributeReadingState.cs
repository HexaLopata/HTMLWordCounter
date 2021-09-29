using System;
using System.IO;

namespace VolgaIT.BL.ReadingStates
{
    public class AttributeReadingState : IHTMLReadingState
    {
        public void Read(WordCountService wordCounter, StreamReader reader)
        {
            var c = (char)reader.Read();
            if (c == '/')
                wordCounter.IsCurrentTagClosed = true;
            else if(c == '>')
            {
                if (wordCounter.IsCurrentTagClosed)
                {
                    wordCounter.ChangeState(new WordReadingState());
                }
                else
                {
                    if(wordCounter.IsIgnoringCurrentTag)
                    {
                        wordCounter.ChangeState(new CharWaitingState('<', new TagReadingState()));
                    }
                    else
                    {
                        wordCounter.ChangeState(new WordReadingState());
                    }
                }
            }
            else if(c == '<')
            {
                throw new Exception("Переданный html файл содержит ошибки синтаксиса");
            }
        }
    }
}
