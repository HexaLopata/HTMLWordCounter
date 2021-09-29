﻿using VolgaIT.Views;
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
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                AnalizeButtonClicked?.Invoke(openFileDialog1.FileName);
            }
        }
    }
}
