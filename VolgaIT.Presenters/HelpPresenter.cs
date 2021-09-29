using VolgaIT.BL;
using VolgaIT.Views;

namespace VolgaIT.Presenters
{
    public class HelpPresenter : PresenterBase, IPresenter
    {
        private readonly IHelpView _view;

        public HelpPresenter(ViewFactory viewFactory, ServiceFactory serviceFactory) : base(viewFactory, serviceFactory)
        {
            _view = _viewFactory.HelpView;
        }

        public void Run()
        {
            _view.Show();
            _view.CancelButtonClicked += OnCancel;
        }

        private void OnCancel()
        {
            new MainPresenter(_viewFactory, _serviceFactory).Run();
            _view.Close();
        }
    }
}
