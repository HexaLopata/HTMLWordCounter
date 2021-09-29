using VolgaIT.BL;
using VolgaIT.Views;

namespace VolgaIT.Presenters
{
    public abstract class PresenterBase
    {
        protected ViewFactory _viewFactory;
        protected ServiceFactory _serviceFactory;

        public PresenterBase(ViewFactory viewFactory, ServiceFactory serviceFactory)
        {
            _viewFactory = viewFactory;
            _serviceFactory = serviceFactory;
        }
    }
}
