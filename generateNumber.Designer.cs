namespace calculator.exe
{
    partial class generateNumber
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
            this.txÜ = new System.Windows.Forms.TextBox();
            this.bGenerate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txÜ
            // 
            this.txÜ.Location = new System.Drawing.Point(88, 72);
            this.txÜ.Name = "txÜ";
            this.txÜ.Size = new System.Drawing.Size(609, 20);
            this.txÜ.TabIndex = 0;
            // 
            // bGenerate
            // 
            this.bGenerate.Location = new System.Drawing.Point(279, 255);
            this.bGenerate.Name = "bGenerate";
            this.bGenerate.Size = new System.Drawing.Size(247, 23);
            this.bGenerate.TabIndex = 1;
            this.bGenerate.Text = "Sayı Üret";
            this.bGenerate.UseVisualStyleBackColor = true;
            this.bGenerate.Click += new System.EventHandler(this.bGenerate_Click);
            // 
            // generateNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bGenerate);
            this.Controls.Add(this.txÜ);
            this.Name = "generateNumber";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txÜ;
        private System.Windows.Forms.Button bGenerate;
    }
}