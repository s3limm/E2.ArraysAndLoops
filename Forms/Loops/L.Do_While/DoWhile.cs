using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator.exe
{
    public partial class DoWhile : Form
    {
        public DoWhile()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(txtValue.Text);
            string result = "";


            try
            {
                do
                {
                    result += $"{number},";
                    number--;

                } while (number >= 0 && number < 5);
                result = result.TrimEnd(',');
                lblValue.Text = result;
                

            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen bir  sayı giriniz.");

            }
        }
    }
}
