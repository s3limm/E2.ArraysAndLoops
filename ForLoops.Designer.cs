namespace calculator.exe
{
    partial class ForLoops
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
            this.lstbGenerateNumbers = new System.Windows.Forms.ListBox();
            this.btnGenrateNumbers = new System.Windows.Forms.Button();
            this.lstbSendtheNumbers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstbGenerateNumbers
            // 
            this.lstbGenerateNumbers.FormattingEnabled = true;
            this.lstbGenerateNumbers.Location = new System.Drawing.Point(45, 44);
            this.lstbGenerateNumbers.Name = "lstbGenerateNumbers";
            this.lstbGenerateNumbers.Size = new System.Drawing.Size(296, 368);
            this.lstbGenerateNumbers.TabIndex = 0;
          
            // 
            // btnGenrateNumbers
            // 
            this.btnGenrateNumbers.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenrateNumbers.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnGenrateNumbers.Location = new System.Drawing.Point(347, 215);
            this.btnGenrateNumbers.Name = "btnGenrateNumbers";
            this.btnGenrateNumbers.Size = new System.Drawing.Size(127, 66);
            this.btnGenrateNumbers.TabIndex = 1;
            this.btnGenrateNumbers.Text = "List The Numbers";
            this.btnGenrateNumbers.UseVisualStyleBackColor = true;
            this.btnGenrateNumbers.Click += new System.EventHandler(this.btnGenrateNumbers_Click);
            // 
            // lstbSendtheNumbers
            // 
            this.lstbSendtheNumbers.FormattingEnabled = true;
            this.lstbSendtheNumbers.Location = new System.Drawing.Point(492, 44);
            this.lstbSendtheNumbers.Name = "lstbSendtheNumbers";
            this.lstbSendtheNumbers.Size = new System.Drawing.Size(296, 368);
            this.lstbSendtheNumbers.TabIndex = 0;
            // 
            // ForLoops
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGenrateNumbers);
            this.Controls.Add(this.lstbSendtheNumbers);
            this.Controls.Add(this.lstbGenerateNumbers);
            this.Name = "ForLoops";
            this.Text = "ForLoops";
            this.Load += new System.EventHandler(this.ForLoops_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstbGenerateNumbers;
        private System.Windows.Forms.Button btnGenrateNumbers;
        private System.Windows.Forms.ListBox lstbSendtheNumbers;
    }
}