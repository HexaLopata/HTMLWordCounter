using VolgaIT.Views;
using System.Windows.Forms;
using System;

namespace VolgaIT
{
    public partial class AnalyzeForm : Form, IAnalyzerView
    {
        public AnalyzeForm()
        {
            InitializeComponent();
        }

        public event EventHandler<string> AnalizeButtonClicked;
        public event EventHandler CancelButtonClicked;

        void IView.Close()
        {
            FormsManager.Instance.Close(this);
        }

        void IView.Show()
        {
            FormsManager.Instance.Show(this);
        }

        void IView.ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
