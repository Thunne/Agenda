using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Agenda
{
    class ConnexionDAO
    {
        private MySqlConnection conn;
        // Constructeur
        public ConnexionDAO()
        {
            this.connSqlDb();
        }

        // Méthode pour initialiser la connexion
        private void connSqlDb()
        {
            string MyConnectionString = "Server=localhost;Database=agenda;Uid=root;Pwd=;";
            this.conn = new MySqlConnection(MyConnectionString);
            if (this.conn.Equals(false))
            {
                throw new BddException();
            }
        }

        public DataSet getUser(string pseudo)
        {
            this.conn.Open();

            try
            {
                MySqlCommand cmd = this.conn.CreateCommand();

                cmd.CommandText = "SELECT * FROM user WHERE pseudo = @pseudo";
                cmd.Parameters.AddWithValue("@pseudo", pseudo);
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);

                this.conn.Close();
                return ds;
            }
            catch (BddException e)
            {
                throw;
            }
        }
    }
}
