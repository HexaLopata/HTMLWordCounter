using System;
using VolgaIT.BL;
using VolgaIT.Views;

namespace VolgaIT.Presenters
{
    public class AnalizerPresenter : IPresenter
    {
        private IAnalyzerView _view;
        private IWordCountService _wordCounter;
        private ViewFactory _viewFactory;

        public AnalizerPresenter(ViewFactory viewFactory, IWordCountService wordCounter)
        {
            _viewFactory = viewFactory;
            _view = viewFactory.AnalyzerView;
            _wordCounter = wordCounter;
            SubscribeOnViewEvents();
        }

        public void Run()
        {
            _view.Show();
        }

        private void SubscribeOnViewEvents()
        {
            _view.AnalizeButtonClicked += OnAnalyze;
            _view.CancelButtonClicked += OnCancel;
        }

        private void OnCancel(object sender, EventArgs e)
        {
            var newPresenter = new MainPresenter(_viewFactory);
            newPresenter.Run();
            _view.Close();
        }

        private void OnAnalyze(object sender, string filePath)
        {
            _wordCounter.Analyze(filePath);
        }
    }
}
