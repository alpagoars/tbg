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
    public partial class oyunlar : Form
    {
        public oyunlar()
        {
            InitializeComponent();
        }
        void formgetir(Form frm)
        {
            panel2.Controls.Clear();
            frm.TopLevel = false;
            panel2.Controls.Add(frm);
            frm.Show();
            frm.Dock = DockStyle.Fill;
            frm.BringToFront();
        }
        private void oyunlar_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                macera macera = new macera();
                formgetir(macera);
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                macera macera = new macera();
                formgetir(macera);
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                aksiyon aksiyon = new aksiyon();
                formgetir(aksiyon);
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                bulmaca bulmaca = new bulmaca();
                formgetir(bulmaca);
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                jrpg jrpg = new jrpg();
                formgetir(jrpg);
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                strateji strateji = new strateji();
                formgetir(strateji);
            }
            else if (comboBox1.SelectedIndex == 6)
            {
                simülasyon simülasyon = new simülasyon();
                formgetir(simülasyon);
            }
        }
    }
}
