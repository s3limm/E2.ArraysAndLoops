﻿using System;
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
    public partial class ProjectÖdev : Form
    {
        public ProjectÖdev()
        {
            InitializeComponent();
        }

        private void ProjectÖdev_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 100; i++)
            {
                lstFrom.Items.Add(i);
            }
        }

        private void btnAktar_Click(object sender, EventArgs e)
        {
            for (int i = lstFrom.Items.Count; i >= 1; i--)
            {
                if(i % 5 == 0 )
                {
                    lstTo.Items.Add(i);
                }

            }
        }
    }
}
