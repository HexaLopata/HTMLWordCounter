using System;
using System.Windows.Forms;
using VolgaIT.Views;

namespace VolgaIT
{
    public partial class HelpForm : Form, IHelpView
    {
        public event Action CancelButtonClicked;

        public HelpForm()
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

        private void BackButton_Click(object sender, EventArgs e)
        {
            CancelButtonClicked?.Invoke();
        }
    }
}
