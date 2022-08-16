namespace calculator.exe
{
    partial class ProjectÖdev
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
            this.lstFrom = new System.Windows.Forms.ListBox();
            this.lstTo = new System.Windows.Forms.ListBox();
            this.btnAktar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstFrom
            // 
            this.lstFrom.FormattingEnabled = true;
            this.lstFrom.Location = new System.Drawing.Point(22, 21);
            this.lstFrom.Name = "lstFrom";
            this.lstFrom.Size = new System.Drawing.Size(290, 407);
            this.lstFrom.TabIndex = 0;
            // 
            // lstTo
            // 
            this.lstTo.FormattingEnabled = true;
            this.lstTo.Location = new System.Drawing.Point(486, 21);
            this.lstTo.Name = "lstTo";
            this.lstTo.Size = new System.Drawing.Size(290, 407);
            this.lstTo.TabIndex = 0;
            // 
            // btnAktar
            // 
            this.btnAktar.Location = new System.Drawing.Point(342, 196);
            this.btnAktar.Name = "btnAktar";
            this.btnAktar.Size = new System.Drawing.Size(122, 60);
            this.btnAktar.TabIndex = 1;
            this.btnAktar.Text = "Aktar";
            this.btnAktar.UseVisualStyleBackColor = true;
            this.btnAktar.Click += new System.EventHandler(this.btnAktar_Click);
            // 
            // ProjectÖdev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAktar);
            this.Controls.Add(this.lstTo);
            this.Controls.Add(this.lstFrom);
            this.Name = "ProjectÖdev";
            this.Text = "ProjectÖdev";
            this.Load += new System.EventHandler(this.ProjectÖdev_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstFrom;
        private System.Windows.Forms.ListBox lstTo;
        private System.Windows.Forms.Button btnAktar;
    }
}