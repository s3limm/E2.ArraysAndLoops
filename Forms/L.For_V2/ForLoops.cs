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
    public partial class ForLoops : Form
    {
        public ForLoops()
        {
            InitializeComponent();
        }

        int i;
        private void ForLoops_Load(object sender, EventArgs e)
        {
            for (i = 1; i < 100; i++)
            {
                lstbGenerateNumbers.Items.Add(i);
            }
        }

        private void btnGenrateNumbers_Click(object sender, EventArgs e)
        {
            for (int i = lstbGenerateNumbers.Items.Count -1 ; i >= 0; i--)
            {
                int number = Convert.ToInt32(lstbGenerateNumbers.Items[i]);

                if (number % 5 == 0)
                {
                    lstbSendtheNumbers.Items.Add(number);
                }
            }
        }


    }
}
