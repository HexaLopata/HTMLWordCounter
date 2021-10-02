using VolgaIT.BL;
using VolgaIT.Views;

namespace VolgaIT.Presenters
{
    public class MainPresenter : PresenterBase, IPresenter
    {
        private readonly IMainView _view;

        public MainPresenter(ViewFactory viewFactory, ServiceFactory serviceFactory) : base(viewFactory, serviceFactory)
        {
            _view = _viewFactory.MainView;
            _view.AnalyzeButtonClicked += OnAnalyzeButtonClicked;
            _view.HelpButtonClicked += OnHelpButtonClicked;
        }

        public void Run()
        {
            _view.Show();
        }

        private void OnAnalyzeButtonClicked()
        {
            new AnalyzerPresenter(_viewFactory, _serviceFactory).Run();
            _view.Close();
        }

        private void OnHelpButtonClicked()
        {
            new HelpPresenter(_viewFactory, _serviceFactory).Run();
            _view.Close();
        }
    }
}
