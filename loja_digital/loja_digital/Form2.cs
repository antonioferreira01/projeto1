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
    public partial class Form2 : Form
    {
         


        public Form2()
        {
            InitializeComponent();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
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

        private void Button1_Click(object sender, EventArgs e)
        {

            {

                string nome = TextBox1.Text;
                string pass = textBox2.Text;
                string query;


                MySqlConnection db = new MySqlConnection(Properties.Settings.Default.ConnectionString);
                db.Open();

                try
                {

                    query = "SELECT username, password FROM informacao_utilizador WHERE username = @nome AND password = @pass";

                    MySqlCommand comando = new MySqlCommand(query, db);
                    comando.CommandText = query;
                    MySqlParameter uusername = new MySqlParameter("@nome", MySqlDbType.String);
                    MySqlParameter upassword = new MySqlParameter("@pass", MySqlDbType.String);
                    uusername.Value = TextBox1.Text;
                    upassword.Value = textBox2.Text;

                    comando.Parameters.Add(uusername);
                    comando.Parameters.Add(upassword);

                    MySqlDataReader mydb = comando.ExecuteReader(CommandBehavior.CloseConnection);
                    if (mydb.Read() == true)
                    {
                        Form4 f4 = new Form4();
                        f4.Owner = this;
                        this.Hide();
                        f4.ShowDialog();
                        this.Dispose();


                    }
                    else
                    {
                        TextBox1.Clear();
                        MessageBox.Show("Password ou Username incorretos");
                    }

                }
                catch (Exception k)
                {
                    MessageBox.Show(k.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                

            }
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
