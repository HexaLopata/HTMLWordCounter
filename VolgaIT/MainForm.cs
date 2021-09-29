using System;
using System.Windows.Forms;
using VolgaIT.Views;

namespace VolgaIT
{
    public partial class MainForm : Form, IMainView
    {
        public event Action AnalyzeButtonClicked;
        public new event Action HelpButtonClicked;

        public MainForm()
        {
            InitializeComponent();
        }

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

        private void AnalyzeButton_Click(object sender, EventArgs e)
        {
            AnalyzeButtonClicked?.Invoke();
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            HelpButtonClicked?.Invoke();
        }
    }
}