using System;
using System.Threading.Tasks;
using VolgaIT.BL;
using VolgaIT.Views;

namespace VolgaIT.Presenters
{
    public class AnalizerPresenter : PresenterBase, IPresenter
    {
        private readonly IAnalyzerView _view;
        private IWaitingView _waitingView;
        private readonly IWordCountService _wordCounter;

        public AnalizerPresenter(ViewFactory viewFactory, ServiceFactory serviceFactory) : base(viewFactory, serviceFactory)
        {
            _view = viewFactory.AnalyzerView;
            _wordCounter = _serviceFactory.WordCountService;
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

        private void OnCancel()
        {
            new MainPresenter(_viewFactory, _serviceFactory).Run();
            _view.Close();
        }

        private void OnAnalyze(string filePath)
        {
            try
            {
                StartAnalysis(filePath);
                _waitingView = _viewFactory.WaitingView;
                _waitingView.AnalysisAgainButtonClicked += AnalysisAgain;
                _waitingView.Show();
                _view.Hide();
            }
            catch (Exception ex)
            {
                _view.ShowErrorMessage("Произошла ошибка: " + ex.Message);
            }
        }

        private void AnalysisAgain()
        {
            _view.Show();
            _waitingView.Close();
        }

        private void OnAlalysisEnded()
        {
            _waitingView.OnAnalysisEnded();
        }

        private async Task StartAnalysis(string filePath)
        {
            try
            {
                var task = Task.Run(() => _wordCounter.AnalyzeAsync(filePath));
                await task;
                task.ContinueWith((t) =>
                {
                    OnAlalysisEnded();
                }, TaskScheduler.FromCurrentSynchronizationContext());
            }
            catch (Exception ex)
            {
                _view.ShowErrorMessage("Произошла ошибка: " + ex.Message);
                _view.Show();
                _waitingView.Close();
            }
        }
    }
}
