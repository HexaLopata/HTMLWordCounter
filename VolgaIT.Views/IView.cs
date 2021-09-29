namespace VolgaIT.Views
{
    public interface IView
    {
        void Show();
        void Close();
        void Hide();
        void ShowErrorMessage(string message);
    }
}
