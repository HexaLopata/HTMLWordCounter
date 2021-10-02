
namespace VolgaIT
{
    partial class WaitingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WaitingForm));
            this.AnalysisAgainButton = new System.Windows.Forms.Button();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AnalysisAgainButton
            // 
            this.AnalysisAgainButton.Location = new System.Drawing.Point(12, 87);
            this.AnalysisAgainButton.Name = "AnalysisAgainButton";
            this.AnalysisAgainButton.Size = new System.Drawing.Size(191, 25);
            this.AnalysisAgainButton.TabIndex = 0;
            this.AnalysisAgainButton.Text = "Анализировать снова";
            this.AnalysisAgainButton.UseVisualStyleBackColor = true;
            this.AnalysisAgainButton.Click += new System.EventHandler(this.AnalysisAgainButton_Click);
            // 
            // InfoLabel
            // 
            this.InfoLabel.Location = new System.Drawing.Point(12, 18);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.InfoLabel.Size = new System.Drawing.Size(484, 66);
            this.InfoLabel.TabIndex = 1;
            this.InfoLabel.Text = "Обработка файла в процессе завершения. Когда она будет завершена, результат запиш" +
    "ется в указанный вами файл";
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Location = new System.Drawing.Point(305, 87);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(191, 25);
            this.OpenFileButton.TabIndex = 2;
            this.OpenFileButton.Text = "Открыть файл";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // WaitingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 121);
            this.Controls.Add(this.OpenFileButton);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.AnalysisAgainButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "WaitingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HTMLWordCounter";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AnalysisAgainButton;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Button OpenFileButton;
    }
}