using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace VolgaIT.BL
{
    public interface IWordCountService
    {
        List<string> IgnoredTags { get; }
        bool IgnoreCase { get; set; }
        int MaxWordLength { get; set; }
        int MaxTagLength { get; }
        char[] Separators { get; }
        char[] IgnoredChars { get; }
        string[] NeitherWordNorSeparators { get; }

        void Analyze(string path);
        void Analyze(StreamReader reader);
        Task AnalyzeAsync(string path);
        Task AnalyzeAsync(StreamReader reader);
    }
}
