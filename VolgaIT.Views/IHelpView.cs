using System;

namespace VolgaIT.Views
{
    public interface IHelpView : IView
    {
        event Action CancelButtonClicked;
    }
}
