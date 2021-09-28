using System.IO;

namespace VolgaIT.BL.ReadingStates
{
    public interface IHTMLReadingState
    {
        void Read(WordCountService wordCounter, StreamReader reader);
    }
}
