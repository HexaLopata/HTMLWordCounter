using System;
using VolgaIT.Views;
using System.Windows.Forms;

namespace VolgaIT
{
    public partial class WaitingForm : Form, IWaitingView
    {
        public event Action AnalysisAgainButtonClicked;

        private readonly string _waitingMessage = "Обработка файла в процессе завершения. Когда она будет завершена, результат запишется в файл output.txt";
        private readonly string _analysisEndedMessage = "Текст был успешно проанализирован, вы можете увидеть результат в файле output.txt";

        public WaitingForm()
        {
            InitializeComponent();

            InfoLabel.Text = _waitingMessage;
            AnalysisAgainButton.Hide();
        }

        public void OnAnalysisEnded()
        {
            AnalysisAgainButton.Show();
            InfoLabel.Text = _analysisEndedMessage;
        }

        private void AnalysisAgainButton_Click(object sender, EventArgs e)
        {
            AnalysisAgainButtonClicked?.Invoke();
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
    }
}
