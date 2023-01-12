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
    public partial class profil : Form
    {
        public profil()
        {
            InitializeComponent();
        }

        private void profil_Load(object sender, EventArgs e)
        {
            Form1 form1 = (Form1)Application.OpenForms["Form1"];
            label1.Text = form1.textBox1.Text;
            profil Profill = (profil)Application.OpenForms["profil"];
            Profill.pictureBox2.ImageLocation = "./profile/" + form1.textBox1.Text + ".jpg";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            button3.Visible = true;
            button2.Visible = true;
            button1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            label2.Text = textBox2.Text;
            textBox1.Visible = false;
            textBox2.Visible = false;
            button3.Visible = false;
            button2.Visible = false;
            button1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           openFileDialog1.ShowDialog();
            pictureBox2.ImageLocation = openFileDialog1.FileName;
        }
    }
}
