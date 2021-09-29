namespace VolgaIT.BL
{
    public abstract class ServiceFactory
    {
        public abstract IWordCountService WordCountService { get; }
    }
}
