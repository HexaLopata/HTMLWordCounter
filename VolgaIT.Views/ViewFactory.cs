namespace VolgaIT.Views
{
    public abstract class ViewFactory
    {
        public abstract IMainView MainView { get; }
        public abstract IAnalyzerView AnalyzerView { get; }
        public abstract IHelpView HelpView { get; }
        public abstract IWaitingView WaitingView { get; }
    }
}
