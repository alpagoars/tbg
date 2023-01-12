using System;
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
    public partial class aksiyon : Form
    {
        public aksiyon()
        {
            InitializeComponent();
        }
        int sayfanum = 2;
        private void aksiyon_Load(object sender, EventArgs e)
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

        private void button9_Click(object sender, EventArgs e)
        {
            sayfanum--;
            label9.Text = sayfanum.ToString();
            oyunlar oyunlar = (oyunlar)Application.OpenForms["oyunlar"];
            oyunlar.comboBox1.SelectedIndex = sayfanum;
        }
    }
}
