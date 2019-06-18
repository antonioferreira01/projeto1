using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loja_digital
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Owner = this;
            this.Hide();
            f1.ShowDialog();
            this.Dispose();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Owner = this;
            this.Hide();
            f8.ShowDialog();
            this.Dispose();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Owner = this;
            this.Hide();
            f5.ShowDialog();
            this.Dispose();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void VScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Owner = this;
            this.Hide();
            f6.ShowDialog();
            this.Dispose();
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Owner = this;
            this.Hide();
            f7.ShowDialog();
            this.Dispose();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Owner = this;
            this.Hide();
            f5.ShowDialog();
            this.Dispose();
        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Owner = this;
            this.Hide();
            f6.ShowDialog();
            this.Dispose();
        }

        private void LinkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Owner = this;
            this.Hide();
            f7.ShowDialog();
            this.Dispose();
        }
    }
}
