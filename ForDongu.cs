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
    public partial class ForDongu : Form
    {
        public ForDongu()
        {
            InitializeComponent();
        }

       
        private void ForDongu_Load(object sender, EventArgs e)
        {
            for (int i = 1;  i < 11; i++)
            {
                lbNumbers.Items.Add(i);
            }
        }

        private void lbNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {
          lblIndex.Text = lbNumbers.SelectedIndex.ToString();
          lblValue.Text = lbNumbers.SelectedItem.ToString();

        }
    }
}
