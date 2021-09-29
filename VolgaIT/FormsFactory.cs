using VolgaIT.Views;

namespace VolgaIT
{
    internal class FormsFactory : ViewFactory
    {
        public override IMainView MainView => new MainForm();
        public override IAnalyzerView AnalyzerView => new AnalyzeForm();
        public override IHelpView HelpView => new HelpForm();
        public override IWaitingView WaitingView => new WaitingForm();
    }
}
