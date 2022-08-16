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
    public partial class Foreach : Form
    {
        public Foreach()
        {
            InitializeComponent();
        }

        private void btnaktar_Click(object sender, EventArgs e)
        {
            string[] books = { "Anna Karanna 1 ", "Anna Karanna 2", "Anna Karanna 3", "Sefiller", "Çizgili Pijamalı Çocuk", };

            foreach (var book in books )
            {
                lstBook.Items.Add(book);
            }

        }
    }
}
