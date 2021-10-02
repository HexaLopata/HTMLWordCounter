using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace VolgaIT.BL.ReadingStates
{
    public class TagIgnoringState : IHTMLReadingState
    {
        private string _currentTag = string.Empty;
        private bool _isReadingTag = false;
        private bool _isCurrentTagClosed = false;
        private bool _isInQuotationMarks = false;
        private readonly string _ignoredTag;
        private char _previousChar;

        public TagIgnoringState(string ignoredTag)
        {
            _ignoredTag = ignoredTag;
        }

        public void Read(WordCountService wordCounter, StreamReader reader)
        {
            var c = (char)reader.Read();
            if ((c == '"' || c == '\'') && _previousChar != '\\')
                _isInQuotationMarks = !_isInQuotationMarks;
            if (!_isInQuotationMarks)
            {
                if (_isReadingTag)
                {
                    if (c == '/')
                    {
                        _isCurrentTagClosed = true;
                    }
                    else if (c == '>')
                    {
                        _isCurrentTagClosed = false;
                        _isReadingTag = false;
                        _currentTag = string.Empty;
                    }
                    else
                    {
                        _currentTag += c;
                        if (_currentTag == _ignoredTag && !string.IsNullOrEmpty(_currentTag))
                        {
                            if (!_isCurrentTagClosed)
                            {
                                _currentTag = string.Empty;
                                _isReadingTag = false;
                            }
                            else
                            {
                                wordCounter.IsCurrentTagClosed = true;
                                wordCounter.ChangeState(new TagReadingState());
                            }
                        }
                        if (_currentTag.Length >= wordCounter.MaxTagLength)
                        {
                            _isReadingTag = false;
                            _currentTag = string.Empty;
                        }
                    }
                }
                else if (c == '<')
                {
                    _isReadingTag = true;
                }
            }
            _previousChar = c;
        }
    }
}
