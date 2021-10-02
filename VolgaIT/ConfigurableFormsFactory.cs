using System;
using VolgaIT.Views;

namespace VolgaIT
{
    internal class ConfigurableFormsFactory : ViewFactory
    {
        public override IMainView MainView => GetMainViewAction();
        public override IAnalyzerView AnalyzerView => GetAnalyzerViewAction();
        public override IHelpView HelpView => GetHelpViewAction();
        public override IWaitingView WaitingView => GetWaitingViewAction();

        public Func<IMainView> GetMainViewAction;
        public Func<IAnalyzerView> GetAnalyzerViewAction;
        public Func<IHelpView> GetHelpViewAction;
        public Func<IWaitingView> GetWaitingViewAction;
    }
}
