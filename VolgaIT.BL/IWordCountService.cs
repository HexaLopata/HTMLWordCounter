using System.IO;
using System.Threading.Tasks;

namespace VolgaIT.BL
{
    public interface IWordCountService
    {
        string[] IgnoredTags { get; set; }
        bool IgnoreCase { get; set; }
        int MaxWordLength { get; set; }
        int MaxTagLength { get; }
        char[] Separators { get; }
        char[] IgnoredChars { get; }
        string[] NeitherWordNorSeparators { get; }
        IWordSaver WordSaver { get; set; }

        void Analyze(string path);
        void Analyze(StreamReader reader);
        Task AnalyzeAsync(string path);
        Task AnalyzeAsync(StreamReader reader);
    }
}
