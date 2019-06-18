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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
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


                //Create a new user
                DB db = new DB();
                MySqlCommand command = new MySqlCommand("INSERT INTO informacao_utilizador (username, Password) VALUES (@usn, @pass);", db.GetConnection());

                command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = textBoxUsername.Text;
                command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBoxPassword.Text;
                

                //Open the connection
                db.openConnection();

                //Execute  the query
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Conta Criada");
                    Form1 Inicio = new Form1();
                    this.Hide();
                    Inicio.ShowDialog();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("ERRO!");
                }

                //Close the connection
                db.closeConnection();

            }

        private void TextBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }

        
    
}
