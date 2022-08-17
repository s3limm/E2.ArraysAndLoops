namespace calculator.exe
{
    partial class Foreach
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
            this.lstBook = new System.Windows.Forms.ListBox();
            this.btnaktar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBook
            // 
            this.lstBook.FormattingEnabled = true;
            this.lstBook.Location = new System.Drawing.Point(12, 12);
            this.lstBook.Name = "lstBook";
            this.lstBook.Size = new System.Drawing.Size(120, 355);
            this.lstBook.TabIndex = 0;
            // 
            // btnaktar
            // 
            this.btnaktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnaktar.Location = new System.Drawing.Point(197, 278);
            this.btnaktar.Name = "btnaktar";
            this.btnaktar.Size = new System.Drawing.Size(125, 89);
            this.btnaktar.TabIndex = 1;
            this.btnaktar.Text = "Aktar";
            this.btnaktar.UseVisualStyleBackColor = true;
            this.btnaktar.Click += new System.EventHandler(this.btnaktar_Click);
            // 
            // Foreach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 450);
            this.Controls.Add(this.btnaktar);
            this.Controls.Add(this.lstBook);
            this.Name = "Foreach";
            this.Text = "Foreach";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstBook;
        private System.Windows.Forms.Button btnaktar;
    }
}