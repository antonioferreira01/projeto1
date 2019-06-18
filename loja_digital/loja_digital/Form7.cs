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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
           
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Owner = this;
            this.Hide();
            f4.ShowDialog();
            this.Dispose();
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            Form8 f8 = new Form8();
            f8.label(lbl.Text);
            
            f8.Show();
            
            
          
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Owner = this;
            this.Hide();
            f8.ShowDialog();
            this.Dispose();
        }
    }
}
