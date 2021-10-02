
namespace VolgaIT
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.AnalyzeButton = new System.Windows.Forms.Button();
            this.HelpButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AnalyzeButton
            // 
            this.AnalyzeButton.Location = new System.Drawing.Point(302, 56);
            this.AnalyzeButton.Name = "AnalyzeButton";
            this.AnalyzeButton.Size = new System.Drawing.Size(136, 25);
            this.AnalyzeButton.TabIndex = 0;
            this.AnalyzeButton.Text = "Анализировать";
            this.AnalyzeButton.UseVisualStyleBackColor = true;
            this.AnalyzeButton.Click += new System.EventHandler(this.AnalyzeButton_Click);
            // 
            // HelpButton
            // 
            this.HelpButton.Location = new System.Drawing.Point(302, 94);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(136, 25);
            this.HelpButton.TabIndex = 1;
            this.HelpButton.Text = "Справка";
            this.HelpButton.UseVisualStyleBackColor = true;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 243);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(271, 12);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(204, 30);
            this.Title.TabIndex = 3;
            this.Title.Text = "HTMLWordCounter";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(506, 274);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.HelpButton);
            this.Controls.Add(this.AnalyzeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HTMLWordCounter";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AnalyzeButton;
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Title;
    }
}