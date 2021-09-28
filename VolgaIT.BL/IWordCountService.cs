using System.Collections.Generic;
using System.IO;

namespace VolgaIT.BL
{
    public interface IWordCountService
    {
        void Analyze(string path);
        void Analyze(StreamReader reader);
        List<string> IgnoredTags { get; }
        bool IgnoreCase { get; set; }
        int MaxWordLength { get; set; }
        int MaxTagLength { get; }
        char[] Separators { get; }
    }
}
