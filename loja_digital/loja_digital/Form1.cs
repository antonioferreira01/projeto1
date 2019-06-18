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

    
    public partial class Form1 : Form
    {
        private static string _connectionString = "Server=127.0.0.1;Database=lojadigital;Uid=root;Pwd=sporting01;";
        private static MySqlConnection db = new MySqlConnection(_connectionString);

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Owner = this;
            this.Hide();
            f2.ShowDialog();
            this.Dispose();

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Owner = this;
            this.Hide();
            f3.ShowDialog();
            this.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
