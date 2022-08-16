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
    public partial class YemekTarifi : Form
    {
        public YemekTarifi()
        {
            InitializeComponent();
        }

        string[] food = {"1- Merhablar Menemen yapımına hoşgeldininiz .İlk adımımızda yumurtaları çırpıyoruz." , "2- Sonrasında daha önceden doğradığımız domatesleri içine atıyoruz." , "3- Yumurtanın yaklaşık 10 dakika pişmesini bekliyoruz." , "Son olarak isteğe bağlı olarak üstüne kaşar rendeliyoruz ve menemenimiz hazır." };

        int index = 0;

        private void btnTarif_Click(object sender, EventArgs e)
        {


            //if(index <= food.Length -1 )
            //{
            //    lbTarif.Items.Add(food[index]);
            //    index++;
            //}
            //else
            //{
            //    MessageBox.Show("Tarifiniz tamamlanmıştır.");
            //}



            int index = 0;
            while (index < food.Length)
            {
                lbTarif.Items.Add(food[index]);
                index++;

            }


        }

        private void YemekTarifi_Load(object sender, EventArgs e)
        {
            MessageBox.Show("YemekTarifi.com'a hoşgeldiniz... ");

        }
    }
}
