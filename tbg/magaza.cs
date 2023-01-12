using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace tbg
{
    public partial class magaza : Form
    {
        public magaza()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;
        void formgetir(Form frm)
        {
            panel7.Controls.Clear();
            frm.TopLevel = false;
            panel7.Controls.Add(frm);
            frm.Show();
            frm.Dock = DockStyle.Fill;
            frm.BringToFront();
        }
        private void magaza_Load(object sender, EventArgs e)
        {
            
            panel2.Visible = true;
            panel6.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel6.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            oyunlar oyunlar = new oyunlar();
            formgetir(oyunlar);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel6.Visible = true;
            panel2.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel2.Visible = false;
            panel6.Visible = false;
            panel5.Visible = false;
            Sepet sepet = new Sepet();
            formgetir(sepet);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
            panel2.Visible = false;
            panel6.Visible = false;
            panel4.Visible = false;
            profil profil = new profil();
            formgetir(profil);
        }
    }
}
