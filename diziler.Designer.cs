namespace calculator.exe
{
    partial class diziler
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
            this.txtChoise = new System.Windows.Forms.TextBox();
            this.bChoise = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtChoise
            // 
            this.txtChoise.Location = new System.Drawing.Point(204, 79);
            this.txtChoise.Name = "txtChoise";
            this.txtChoise.Size = new System.Drawing.Size(421, 20);
            this.txtChoise.TabIndex = 0;
            // 
            // bChoise
            // 
            this.bChoise.Location = new System.Drawing.Point(266, 296);
            this.bChoise.Name = "bChoise";
            this.bChoise.Size = new System.Drawing.Size(294, 23);
            this.bChoise.TabIndex = 1;
            this.bChoise.Text = "Şehir seç";
            this.bChoise.UseVisualStyleBackColor = true;
            this.bChoise.Click += new System.EventHandler(this.bChoise_Click);
            // 
            // diziler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bChoise);
            this.Controls.Add(this.txtChoise);
            this.Name = "diziler";
            this.Text = "diziler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtChoise;
        private System.Windows.Forms.Button bChoise;
    }
}