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
    public partial class Loops : Form
    {
        public Loops()
        {
            InitializeComponent();
        }

        string[] recipe = { "1- Merhabalar sucuklu yumurta tarifine hoşgeldiniz.", "2- İlk önce bir kabın içerisine biraz tereyağı koyuyoruz ve kişi sayısından bir fazla kadar yumurta kırıp çırpıyoruz.", "3- Daha sonrasında sucuklarımızı kesiyoruz ve yumurtaların içine atıyoruz", "4- En son isteğe bağlı olarak baharat veya tuz atablirsiniz. Afiyet olsun." };

        int index = 0;

        private void Loops_Load(object sender, EventArgs e)
        {

            MessageBox.Show("Merhabalar YemekTarifi.com'a hoşgeldiniz.");

            //while (index < recipe.Length)
            //{
            //    listbTarif.Items.Add(recipe[index]);
            //    index++;
            //}

        }

        private void btnTarif_Click(object sender, EventArgs e)
        {
            //if de tek tek butona basmanız gerekıyor ancak whıle da bu ıslem son olana kdr kendısı yapıyor ve bıtınce otomatık kodu atlıyor.

            //if (index <= recipe.Length - 1)
            //{
            //    listbTarif.Items.Add(recipe[index]); // Yukarıda recipe nın ıcersınde 4 tane eleman var ancak bunlar 0 dan basladıgı ıcın 4.eleman 3 e esit oluyor bu yuzden if ın ıcerısıne -1 yazıyoruz kı 3 ten buyuk oldugunda dırek ıfı atlasın else gecsın cunku yazdıracak baska deger kalmadı arraysın ıcınde, eger -1 yazmasaydık ozaman 3 u gectıgı anda ıfın ıcerısınde listbTarif.Items.Add(recipe[index]); elemanını eklemeye calısacaktı ancak 5 tane eleman olmadıgı ıcın 4.elemanı bulamıyacagı ıcın hata verecektı.
            //    index++;
            //}
            //else
            //{
            //    MessageBox.Show("Yemek Tarifiniz tamamlanmıştır.");
            //}
            while(index < recipe.Length)
            {
                listbTarif.Items.Add(recipe[index]);
                index++;
            }
            MessageBox.Show("Yemek Tarifiniz tamamlanmıştır.");

        }
    }
}
