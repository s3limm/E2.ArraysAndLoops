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
    public partial class GuessTheNumbers : Form
    {
        public GuessTheNumbers()
        {
            InitializeComponent();
        }

        Random rastgele = new Random();

        private void btnGuess_Click(object sender, EventArgs e)
        {
            string[] questions = { "Yes", "No" };
            string question = "";
            DialogResult result;
            do
            {
                int number = rastgele.Next(0, 2);
                question = questions[number];
                result = MessageBox.Show("Yazı mı Tura mı?\n Yazı için Yes\n Tura için No ", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            } while (result.ToString() != question);
            MessageBox.Show("Kazandındız.");
        }


    }
}
