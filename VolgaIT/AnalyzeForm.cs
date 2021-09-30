using VolgaIT.Views;
using System.Windows.Forms;
using System;
using System.Linq;

namespace VolgaIT
{
    public partial class AnalyzeForm : Form, IAnalyzerView
    {
        public string[] IgnoredTags
        {
            get => IgnoreTagsListBox.Items.OfType<string>().ToArray();
            set
            {
                IgnoreTagsListBox.Items.Clear();
                IgnoreTagsListBox.Items.AddRange(value);
            }
        }
        public int MaxWordLength
        {
            get => (int)MaxWordLengthNumeric.Value;
            set => MaxWordLengthNumeric.Value = value;
        }
        public bool IgnoreCase
        {
            get => !CaseSensitiveCheckBox.Checked;
            set => CaseSensitiveCheckBox.Checked = !value;
        }
        public string OutputFilePath
        {
            get => FilePathTextBox.Text;
            set => FilePathTextBox.Text = value;
        }

        public AnalyzeForm()
        {
            InitializeComponent();
            IgnoreTagsListBox.Items.Add("style");
            IgnoreTagsListBox.Items.Add("script");
        }

        public event Action<string> AnalizeButtonClicked;
        public event Action CancelButtonClicked;

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

        private void AnalyzeButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "html files (*.html)|*html|txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                AnalizeButtonClicked?.Invoke(openFileDialog1.FileName);
            }
        }

        private void IgnoreTagsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listBox = (ListBox)sender;
            var item = listBox.SelectedItem;
            listBox.Items.Remove(item);
        }

        private void AddIgnoreTagButton_Click(object sender, EventArgs e)
        {
            if (IgnoreTagTextBox.Text.Trim() != string.Empty)
            {
                IgnoreTagsListBox.Items.Add(IgnoreTagTextBox.Text);
                IgnoreTagTextBox.Text = string.Empty;
            }
        }

        private void OpenSaveFileDialogButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Текстовый файл (*.txt)|*.txt";
            var result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                FilePathTextBox.Text = saveFileDialog1.FileName;
            }
        }
    }
}
