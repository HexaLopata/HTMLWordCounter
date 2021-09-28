using System;

namespace VolgaIT.Views
{
    public interface IMainView : IView
    {
        event EventHandler AnalyzeButtonClicked;
        event EventHandler AboutButtonClicked;
    }
}
