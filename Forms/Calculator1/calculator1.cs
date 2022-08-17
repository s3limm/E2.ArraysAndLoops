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
    public partial class calculator1 : Form
    {
        public calculator1()
        {
            InitializeComponent();
        }

        

        private void btnT_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(txt1.Text);
            double number2 = Convert.ToDouble(txt2.Text);
            string result = (number1 + number2).ToString();
            MessageBox.Show($"Sonucunuz : {result}");
        }

        private void btnC_Click(object sender, EventArgs e)
        {

           double number1 = Convert.ToDouble(txt1.Text);
            double number2 = Convert.ToDouble(txt2.Text);
            string result = (number1 - number2).ToString();
            MessageBox.Show($"Sonucunuz : {result}");

        }

        private void btnCa_Click(object sender, EventArgs e)
        {
        double    number1 = Convert.ToDouble(txt1.Text);
            double number2 = Convert.ToDouble(txt2.Text);
            string result = (number1 * number2).ToString();
            MessageBox.Show($"Sonucunuz : {result}");
        }

        private void btnBo_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(txt1.Text);
            double number2 = Convert.ToDouble(txt2.Text);
            string result = (number1 / number2).ToString();
            MessageBox.Show($"Sonucunuz : {result}");

        }
    }
}
