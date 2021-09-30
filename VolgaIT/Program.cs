using System;
using System.Windows.Forms;
using VolgaIT.Presenters;
using VolgaIT.BL;

namespace VolgaIT
{
    static class Program
    {
        const string JSON_FILE_PATH = "config.json";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var serviceFactory = new ConfigurableServiceFactory()
            {
                GetWordCountServiceAction = () => new WordCountService(),

                GetWordCounterConfiguratorAction = () =>
                new JsonWordCounterConfigurator
                (
                    new QuickFileWordSaver(),
                    JSON_FILE_PATH
                )
                
            };

            var presenter = new MainPresenter(new FormsFactory(), serviceFactory);
            presenter.Run();
        }
    }
}
