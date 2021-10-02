
namespace VolgaIT
{
    partial class HelpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            this.label1 = new System.Windows.Forms.Label();
            this.HelpText = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // HelpText
            // 
            this.HelpText.Location = new System.Drawing.Point(12, 9);
            this.HelpText.Name = "HelpText";
            this.HelpText.Size = new System.Drawing.Size(425, 38);
            this.HelpText.TabIndex = 1;
            this.HelpText.Text = "Программа для парсинга и подсчета разных слов из html файла. Сделана для цифровой" +
    " Олимпиады Волга IT XXI в 2021 г.\r\n\r\n";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 172);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(83, 25);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(425, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Иконку сделал Smashicons с сайта www.flaticon.com";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(425, 35);
            this.label3.TabIndex = 4;
            this.label3.Text = "Программу сделал студент КубГТУ, Гасюк Алексей. Факультет компьютерных систем и и" +
    "нформационной безопасности.\r\n";
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 209);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.HelpText);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HelpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HTMLWordCounter";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label HelpText;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}