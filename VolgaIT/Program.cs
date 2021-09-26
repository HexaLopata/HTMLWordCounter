using System;
using System.Windows.Forms;
using VolgaIT.Presenters;

namespace VolgaIT
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var presenter = new MainPresenter(new FormsFactory());
            presenter.Run();
        }
    }
}
