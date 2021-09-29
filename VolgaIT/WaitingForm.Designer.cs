
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
            this.AnalysisAgainButton = new System.Windows.Forms.Button();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AnalysisAgainButton
            // 
            this.AnalysisAgainButton.Location = new System.Drawing.Point(12, 209);
            this.AnalysisAgainButton.Name = "AnalysisAgainButton";
            this.AnalysisAgainButton.Size = new System.Drawing.Size(217, 25);
            this.AnalysisAgainButton.TabIndex = 0;
            this.AnalysisAgainButton.Text = "Анализировать снова";
            this.AnalysisAgainButton.UseVisualStyleBackColor = true;
            this.AnalysisAgainButton.Click += new System.EventHandler(this.AnalysisAgainButton_Click);
            // 
            // InfoLabel
            // 
            this.InfoLabel.Location = new System.Drawing.Point(131, 9);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.InfoLabel.Size = new System.Drawing.Size(195, 118);
            this.InfoLabel.TabIndex = 1;
            this.InfoLabel.Text = "Обработка файла в процессе завершения. Когда она будет завершена, результат запиш" +
    "ется в файл output.txt\r\n";
            // 
            // WaitingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 246);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.AnalysisAgainButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "WaitingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WaitingForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AnalysisAgainButton;
        private System.Windows.Forms.Label InfoLabel;
    }
}