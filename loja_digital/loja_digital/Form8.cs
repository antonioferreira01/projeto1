using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace loja_digital
{
    public partial class Form8 : Form
    {
        public Form8()
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

        private void GroupBox1_Enter(object sender, EventArgs e)
        {
            Form7 abrir = new Form7();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            

        }

        public void label (string texto)
        {
            label2.Text = texto;
           
        }
        MySqlConnection con = new MySqlConnection(Properties.Settings.Default.ConnectionString);
        private void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string Nome = label2.Text;
            int preco = 500;
            string insert = "INSERT INTO compra (nome_produto, preco_produtos) VALUES (@Nome, @preco)";
            MySqlCommand cmd = new MySqlCommand(insert, con);
            cmd.CommandText = insert;
            cmd.Parameters.Add("@Nome", MySqlDbType.String).Value = Nome;
            cmd.Parameters.Add("@preco", MySqlDbType.Int32).Value = preco;
            cmd.ExecuteNonQuery();
            
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            
           
           
        }
    }
}
