namespace calculator.exe
{
    partial class calculator1
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
            this.txt1 = new System.Windows.Forms.TextBox();
            this.btnCa = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnT = new System.Windows.Forms.Button();
            this.btnBo = new System.Windows.Forms.Button();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(12, 83);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(136, 20);
            this.txt1.TabIndex = 1;
            // 
            // btnCa
            // 
            this.btnCa.Location = new System.Drawing.Point(174, 215);
            this.btnCa.Name = "btnCa";
            this.btnCa.Size = new System.Drawing.Size(75, 23);
            this.btnCa.TabIndex = 2;
            this.btnCa.Text = "X";
            this.btnCa.UseVisualStyleBackColor = true;
            this.btnCa.Click += new System.EventHandler(this.btnCa_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(93, 215);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(75, 23);
            this.btnC.TabIndex = 4;
            this.btnC.Text = "-";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnT
            // 
            this.btnT.Location = new System.Drawing.Point(12, 215);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(75, 23);
            this.btnT.TabIndex = 5;
            this.btnT.Text = "+";
            this.btnT.UseVisualStyleBackColor = true;
            this.btnT.Click += new System.EventHandler(this.btnT_Click);
            // 
            // btnBo
            // 
            this.btnBo.Location = new System.Drawing.Point(255, 215);
            this.btnBo.Name = "btnBo";
            this.btnBo.Size = new System.Drawing.Size(75, 23);
            this.btnBo.TabIndex = 6;
            this.btnBo.Text = "/";
            this.btnBo.UseVisualStyleBackColor = true;
            this.btnBo.Click += new System.EventHandler(this.btnBo_Click);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(154, 83);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(136, 20);
            this.txt2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 531);
            this.Controls.Add(this.btnBo);
            this.Controls.Add(this.btnT);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnCa);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button btnCa;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnT;
        private System.Windows.Forms.Button btnBo;
        private System.Windows.Forms.TextBox txt2;
    }
}

