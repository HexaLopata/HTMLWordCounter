namespace VolgaIT.Views
{
    public interface IView
    {
        void Show();
        void Close();
        void ShowErrorMessage(string message);
    }
}
