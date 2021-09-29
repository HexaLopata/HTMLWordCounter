using VolgaIT.BL;

namespace VolgaIT
{
    public class DefaultServiceFactory : ServiceFactory
    {
        public override IWordCountService WordCountService => new WordCountService(new QuickFileWordSaver("output.txt"));
    }
}
