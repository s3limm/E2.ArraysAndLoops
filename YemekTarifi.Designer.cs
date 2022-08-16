namespace calculator.exe
{
    partial class YemekTarifi
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
            this.lbTarif = new System.Windows.Forms.ListBox();
            this.btnTarif = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTarif
            // 
            this.lbTarif.FormattingEnabled = true;
            this.lbTarif.Location = new System.Drawing.Point(32, 29);
            this.lbTarif.Name = "lbTarif";
            this.lbTarif.Size = new System.Drawing.Size(347, 368);
            this.lbTarif.TabIndex = 0;
            // 
            // btnTarif
            // 
            this.btnTarif.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTarif.Location = new System.Drawing.Point(571, 276);
            this.btnTarif.Name = "btnTarif";
            this.btnTarif.Size = new System.Drawing.Size(179, 121);
            this.btnTarif.TabIndex = 1;
            this.btnTarif.Text = "Tıkla";
            this.btnTarif.UseVisualStyleBackColor = true;
            this.btnTarif.Click += new System.EventHandler(this.btnTarif_Click);
            // 
            // YemekTarifi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTarif);
            this.Controls.Add(this.lbTarif);
            this.Name = "YemekTarifi";
            this.Text = "YemekTarifi";
            this.Load += new System.EventHandler(this.YemekTarifi_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbTarif;
        private System.Windows.Forms.Button btnTarif;
    }
}