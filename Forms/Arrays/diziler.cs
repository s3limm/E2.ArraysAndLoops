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
    public partial class diziler : Form
    {
        public diziler()
        {
            InitializeComponent();
        }

        /*string[] cities = new string[4] ;*/
        int[] number = new int[4] { 4, 5, 6, 7 };

        private void bChoise_Click(object sender, EventArgs e)
        {
            //    cities[0] = "İstanbul";
            //    cities[1] = "Ankara";
            //    cities[2] = "Antalya";
            //    cities[3] = "İzmir";

            //    MessageBox.Show(cities[2]);

            MessageBox.Show(number[0].ToString());
        }
    }
}
