using System;
using VolgaIT.BL;

namespace VolgaIT
{
    public class ConfigurableServiceFactory : ServiceFactory
    {
        public override IWordCountService WordCountService => GetWordCountServiceAction();
        public override IWordCounterConfigurator WordCounterConfigurator => GetWordCounterConfiguratorAction();

        public Func<IWordCountService> GetWordCountServiceAction;
        public Func<IWordCounterConfigurator> GetWordCounterConfiguratorAction;
    }
}
