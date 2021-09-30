namespace VolgaIT.BL
{
    public abstract class ServiceFactory
    {
        public abstract IWordCountService WordCountService { get; }
        public abstract IWordCounterConfigurator WordCounterConfigurator { get; }
    }
}
