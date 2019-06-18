using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loja_digital
{
    class DB
    {
        private static string _connectionString = "Server=127.0.0.1;Database=mydb;Uid=root;Pwd=;";
        private static MySqlConnection db = new MySqlConnection(_connectionString);

        public void openConnection()
        {
            if (db.State == System.Data.ConnectionState.Closed)
            {
                db.Open();
            }
        }
        public void closeConnection()
        {
            if (db.State == System.Data.ConnectionState.Open)
            {
                db.Close();
            }
        }

        public MySqlConnection GetConnection()
        {
            return db;
        }
    }
}