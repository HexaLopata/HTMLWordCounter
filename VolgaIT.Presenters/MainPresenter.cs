using VolgaIT.Views;

namespace VolgaIT.Presenters
{
    public class MainPresenter : IPresenter
    {
        private IMainView _view;
        private readonly ViewFactory _viewFactory;

        public MainPresenter(ViewFactory viewFactory)
        {
            _viewFactory = viewFactory;
            _view = _viewFactory.MainView;
        }

        public void Run()
        {
            _view.Show();
        }
    }
}
