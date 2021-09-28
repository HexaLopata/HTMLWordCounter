using VolgaIT.Views;

namespace VolgaIT
{
    internal class FormsFactory : ViewFactory
    {
        public override IMainView MainView => new MainForm();
        public override IAnalyzerView AnalyzerView => new AnalyzeForm();
    }
}
