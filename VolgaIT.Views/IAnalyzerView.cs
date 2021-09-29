using System;

namespace VolgaIT.Views
{
    public interface IAnalyzerView : IView
    {
        /// <summary>
        /// Должно срабатывать при выборе файла для анализа и передать путь для файла
        /// </summary>
        event Action<string> AnalizeButtonClicked;
        event Action CancelButtonClicked;
    }
}
