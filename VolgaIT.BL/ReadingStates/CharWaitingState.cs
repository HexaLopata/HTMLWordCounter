using System.IO;

namespace VolgaIT.BL.ReadingStates
{
    public class CharWaitingState : IHTMLReadingState
    {
        private readonly char _charForWaiting;
        private readonly IHTMLReadingState _transitionState;

        public CharWaitingState(char charForWaiting, IHTMLReadingState transitionState)
        {
            _charForWaiting = charForWaiting;
            _transitionState = transitionState;
        }

        public void Read(WordCountService wordCounter, StreamReader reader)
        {
            var c = (char)reader.Read();
            if (c == _charForWaiting)
                wordCounter.ChangeState(_transitionState);
        }
    }
}
