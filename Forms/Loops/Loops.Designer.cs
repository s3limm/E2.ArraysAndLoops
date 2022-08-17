namespace calculator.exe
{
    partial class Loops
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
            this.listbTarif = new System.Windows.Forms.ListBox();
            this.btnTarif = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listbTarif
            // 
            this.listbTarif.FormattingEnabled = true;
            this.listbTarif.Location = new System.Drawing.Point(50, 56);
            this.listbTarif.Name = "listbTarif";
            this.listbTarif.Size = new System.Drawing.Size(285, 368);
            this.listbTarif.TabIndex = 0;
            // 
            // btnTarif
            // 
            this.btnTarif.Font = new System.Drawing.Font("Microsoft Tai Le", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTarif.Location = new System.Drawing.Point(474, 195);
            this.btnTarif.Name = "btnTarif";
            this.btnTarif.Size = new System.Drawing.Size(187, 72);
            this.btnTarif.TabIndex = 1;
            this.btnTarif.Text = "Tarif Al";
            this.btnTarif.UseVisualStyleBackColor = true;
            this.btnTarif.Click += new System.EventHandler(this.btnTarif_Click);
            // 
            // Loops
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTarif);
            this.Controls.Add(this.listbTarif);
            this.Name = "Loops";
            this.Text = "Loops";
            this.Load += new System.EventHandler(this.Loops_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listbTarif;
        private System.Windows.Forms.Button btnTarif;
    }
}