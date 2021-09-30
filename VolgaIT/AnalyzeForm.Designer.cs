
namespace VolgaIT
{
    partial class AnalyzeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BackButton = new System.Windows.Forms.Button();
            this.AnalyzeButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.CaseSensitiveCheckBox = new System.Windows.Forms.CheckBox();
            this.MaxWordLengthNumeric = new System.Windows.Forms.NumericUpDown();
            this.MaxWordLengthLabel = new System.Windows.Forms.Label();
            this.IgnoreTagsListBox = new System.Windows.Forms.ListBox();
            this.IgnoreTagTextBox = new System.Windows.Forms.TextBox();
            this.AddIgnoreTagButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.FilePathInfoLabel = new System.Windows.Forms.Label();
            this.FilePathTextBox = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.OpenSaveFileDialogButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MaxWordLengthNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(9, 415);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(155, 25);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // AnalyzeButton
            // 
            this.AnalyzeButton.Location = new System.Drawing.Point(232, 415);
            this.AnalyzeButton.Name = "AnalyzeButton";
            this.AnalyzeButton.Size = new System.Drawing.Size(155, 25);
            this.AnalyzeButton.TabIndex = 1;
            this.AnalyzeButton.Text = "Анализировать";
            this.AnalyzeButton.UseVisualStyleBackColor = true;
            this.AnalyzeButton.Click += new System.EventHandler(this.AnalyzeButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CaseSensitiveCheckBox
            // 
            this.CaseSensitiveCheckBox.AutoSize = true;
            this.CaseSensitiveCheckBox.Location = new System.Drawing.Point(9, 24);
            this.CaseSensitiveCheckBox.Name = "CaseSensitiveCheckBox";
            this.CaseSensitiveCheckBox.Size = new System.Drawing.Size(138, 21);
            this.CaseSensitiveCheckBox.TabIndex = 2;
            this.CaseSensitiveCheckBox.Text = "Учитывать регистр";
            this.CaseSensitiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // MaxWordLengthNumeric
            // 
            this.MaxWordLengthNumeric.Location = new System.Drawing.Point(250, 64);
            this.MaxWordLengthNumeric.Name = "MaxWordLengthNumeric";
            this.MaxWordLengthNumeric.Size = new System.Drawing.Size(132, 25);
            this.MaxWordLengthNumeric.TabIndex = 3;
            // 
            // MaxWordLengthLabel
            // 
            this.MaxWordLengthLabel.AutoSize = true;
            this.MaxWordLengthLabel.Location = new System.Drawing.Point(9, 66);
            this.MaxWordLengthLabel.Name = "MaxWordLengthLabel";
            this.MaxWordLengthLabel.Size = new System.Drawing.Size(235, 17);
            this.MaxWordLengthLabel.TabIndex = 4;
            this.MaxWordLengthLabel.Text = "Максимальная штатная длина слова: ";
            // 
            // IgnoreTagsListBox
            // 
            this.IgnoreTagsListBox.FormattingEnabled = true;
            this.IgnoreTagsListBox.ItemHeight = 17;
            this.IgnoreTagsListBox.Location = new System.Drawing.Point(12, 141);
            this.IgnoreTagsListBox.Name = "IgnoreTagsListBox";
            this.IgnoreTagsListBox.Size = new System.Drawing.Size(132, 106);
            this.IgnoreTagsListBox.TabIndex = 5;
            this.IgnoreTagsListBox.SelectedIndexChanged += new System.EventHandler(this.IgnoreTagsListBox_SelectedIndexChanged);
            // 
            // IgnoreTagTextBox
            // 
            this.IgnoreTagTextBox.Location = new System.Drawing.Point(183, 141);
            this.IgnoreTagTextBox.Name = "IgnoreTagTextBox";
            this.IgnoreTagTextBox.Size = new System.Drawing.Size(204, 25);
            this.IgnoreTagTextBox.TabIndex = 6;
            // 
            // AddIgnoreTagButton
            // 
            this.AddIgnoreTagButton.Location = new System.Drawing.Point(183, 184);
            this.AddIgnoreTagButton.Name = "AddIgnoreTagButton";
            this.AddIgnoreTagButton.Size = new System.Drawing.Size(110, 25);
            this.AddIgnoreTagButton.TabIndex = 7;
            this.AddIgnoreTagButton.Text = "Добавить";
            this.AddIgnoreTagButton.UseVisualStyleBackColor = true;
            this.AddIgnoreTagButton.Click += new System.EventHandler(this.AddIgnoreTagButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(9, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Игнорируемые теги";
            // 
            // FilePathInfoLabel
            // 
            this.FilePathInfoLabel.AutoSize = true;
            this.FilePathInfoLabel.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FilePathInfoLabel.Location = new System.Drawing.Point(9, 269);
            this.FilePathInfoLabel.Name = "FilePathInfoLabel";
            this.FilePathInfoLabel.Size = new System.Drawing.Size(250, 17);
            this.FilePathInfoLabel.TabIndex = 9;
            this.FilePathInfoLabel.Text = "Путь выходного файла (с названием)";
            // 
            // FilePathTextBox
            // 
            this.FilePathTextBox.Location = new System.Drawing.Point(13, 302);
            this.FilePathTextBox.Name = "FilePathTextBox";
            this.FilePathTextBox.ReadOnly = true;
            this.FilePathTextBox.Size = new System.Drawing.Size(369, 25);
            this.FilePathTextBox.TabIndex = 10;
            // 
            // OpenSaveFileDialogButton
            // 
            this.OpenSaveFileDialogButton.Location = new System.Drawing.Point(13, 346);
            this.OpenSaveFileDialogButton.Name = "OpenSaveFileDialogButton";
            this.OpenSaveFileDialogButton.Size = new System.Drawing.Size(110, 25);
            this.OpenSaveFileDialogButton.TabIndex = 12;
            this.OpenSaveFileDialogButton.Text = "Обзор";
            this.OpenSaveFileDialogButton.UseVisualStyleBackColor = true;
            this.OpenSaveFileDialogButton.Click += new System.EventHandler(this.OpenSaveFileDialogButton_Click);
            // 
            // AnalyzeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 452);
            this.Controls.Add(this.OpenSaveFileDialogButton);
            this.Controls.Add(this.FilePathTextBox);
            this.Controls.Add(this.FilePathInfoLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddIgnoreTagButton);
            this.Controls.Add(this.IgnoreTagTextBox);
            this.Controls.Add(this.IgnoreTagsListBox);
            this.Controls.Add(this.MaxWordLengthLabel);
            this.Controls.Add(this.MaxWordLengthNumeric);
            this.Controls.Add(this.CaseSensitiveCheckBox);
            this.Controls.Add(this.AnalyzeButton);
            this.Controls.Add(this.BackButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AnalyzeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnalizeForm";
            ((System.ComponentModel.ISupportInitialize)(this.MaxWordLengthNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button AnalyzeButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox CaseSensitiveCheckBox;
        private System.Windows.Forms.NumericUpDown MaxWordLengthNumeric;
        private System.Windows.Forms.Label MaxWordLengthLabel;
        private System.Windows.Forms.ListBox IgnoreTagsListBox;
        private System.Windows.Forms.TextBox IgnoreTagTextBox;
        private System.Windows.Forms.Button AddIgnoreTagButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label FilePathInfoLabel;
        private System.Windows.Forms.TextBox FilePathTextBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button OpenSaveFileDialogButton;
    }
}