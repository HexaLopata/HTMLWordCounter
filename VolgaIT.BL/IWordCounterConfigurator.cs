namespace VolgaIT.BL
{
    public interface IWordCounterConfigurator
    {
        IWordSaver WordSaver { get; }
        WordCounterConfig Config { get; set; }

        void Configure(IWordCountService wordCounter);
    }
}
