using System;

namespace VolgaIT.Views
{
    public interface IAnalyzerView : IView
    {
        string[] IgnoredTags { get; set; }
        int MaxWordLength { get; set; }
        bool IgnoreCase { get; set; }
        string OutputFilePath { get; set; }
        /// <summary>
        /// Должно срабатывать при выборе файла для анализа и передать путь для файла
        /// </summary>
        event Action<string> AnalizeButtonClicked;
        event Action CancelButtonClicked;
    }
}
