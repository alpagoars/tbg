﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tbg
{
    public partial class macera : Form
    {
        public macera()
        {
            InitializeComponent();
        }
        int sayfanum = 1;
        private void macera_Load(object sender, EventArgs e)
        {
            label9.Text = sayfanum.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            sayfanum++;
            label9.Text = sayfanum.ToString();
            oyunlar oyunlar = (oyunlar)Application.OpenForms["oyunlar"];
            oyunlar.comboBox1.SelectedIndex = sayfanum;
        }
    }
}
