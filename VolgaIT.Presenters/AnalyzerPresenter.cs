using System;
using System.IO;
using System.Diagnostics;
using System.Threading.Tasks;
using VolgaIT.BL;
using VolgaIT.Views;

namespace VolgaIT.Presenters
{
    public class AnalyzerPresenter : PresenterBase, IPresenter
    {
        private readonly IAnalyzerView _view;
        private IWaitingView _waitingView;
        private IWordCounterConfigurator _configurator;
        private readonly IWordCountService _wordCounter;

        public AnalyzerPresenter(ViewFactory viewFactory, ServiceFactory serviceFactory) : base(viewFactory, serviceFactory)
        {
            _view = viewFactory.AnalyzerView;
            _wordCounter = _serviceFactory.WordCountService;
            _configurator = _serviceFactory.WordCounterConfigurator;
            SubscribeOnViewEvents();
        }

        public void Run()
        {
            ConfigureView(_configurator.Config);
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
                var config = CreateConfigFromViewInfo();
                _configurator.Config = config;
                _configurator.Configure(_wordCounter);
                StartAnalysis(filePath);
                _waitingView = _viewFactory.WaitingView;
                _waitingView.AnalysisAgainButtonClicked += AnalysisAgain;
                _waitingView.OpenFileButtonClicked += OpenFileWithDefaultProgram;
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
        
        private void OpenFileWithDefaultProgram()
        {
            if (File.Exists(_configurator.Config.FilePath))
                Process.Start(new ProcessStartInfo(_configurator.Config.FilePath) { UseShellExecute = true });
            else
                _waitingView.ShowErrorMessage("Файл не найден");
        }

        private WordCounterConfig CreateConfigFromViewInfo()
        {
            var result = new WordCounterConfig();
            result.FilePath = _view.OutputFilePath;
            result.IgnoreCase = _view.IgnoreCase;
            result.IgnoredTags = _view.IgnoredTags;
            result.MaxWordLength = _view.MaxWordLength;
            return result;
        }

        private void ConfigureView(WordCounterConfig config)
        {
            _view.MaxWordLength = config.MaxWordLength;
            _view.IgnoredTags = config.IgnoredTags;
            _view.IgnoreCase = config.IgnoreCase;
            _view.OutputFilePath = config.FilePath;
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
