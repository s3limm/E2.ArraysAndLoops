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
    public partial class BıletAlmaOtomasyonu : Form
    {
        public BıletAlmaOtomasyonu()
        {
            InitializeComponent();
        }

        string[] cities = new string[] { "İstanbul", "Ankara", "Antalya", "İzmir", "Eskişehir", "Bursa" };

        private void BıletAlmaOtomasyonu_Load(object sender, EventArgs e)
        {
            cmbFrom.Items.Add(cities[0]);
            cmbFrom.Items.Add(cities[1]);
            MessageBox.Show(cities.Length + " tane şehir bulunmaktadır.");
        }

        private void cmbFrom_SelectedValueChanged(object sender, EventArgs e)
        {



            cmbTo.Items.Clear();

            if (cmbFrom.SelectedItem.ToString() == cities[0])
            {
                cmbTo.Items.Add(cities[2]);
                cmbTo.Items.Add(cities[3]);

            }
            else
            {
                cmbTo.Items.Add(cities[4]);
                cmbTo.Items.Add(cities[5]);
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {

            if (cmbFrom.Text == "")
            {
                MessageBox.Show("Lütfen bulunduğunuz yeri seçin.");
            }
            else if (cmbTo.Text == "")
            {
                MessageBox.Show("Lütfen gitmek istediğiniz yeri seçiniz.");
            }

            else
            {
                string from = cmbFrom.SelectedItem.ToString();
                string to = cmbTo.SelectedItem.ToString();
                MessageBox.Show($"{from} ile {to} arasındaki seyahatinizde sizlere iyi yolculuklar dileriz.");
            }

        }
    }
}
