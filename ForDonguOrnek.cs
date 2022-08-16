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
    public partial class ForDonguOrnek : Form
    {
        public ForDonguOrnek()
        {
            InitializeComponent();
        }

        private void ForDonguOrnek_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 11; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void bAktarma_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();

            for (int i = listBox1.Items.Count - 1; i >= 0; i--)
            {
                int number = Convert.ToInt32(listBox1.Items[i]);

                if (number % 2 == 0)
                {
                    listBox2.Items.Add(number);
                }

               
            }

        }
    }
}
