using System;

namespace VolgaIT.Views
{
    public interface IWaitingView : IView
    {
        void OnAnalysisEnded();
        event Action AnalysisAgainButtonClicked;
        event Action OpenFileButtonClicked;
    }
}
