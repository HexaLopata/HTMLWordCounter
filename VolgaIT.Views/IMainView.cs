using System;

namespace VolgaIT.Views
{
    public interface IMainView : IView
    {
        event Action AnalyzeButtonClicked;
        event Action HelpButtonClicked;
    }
}
