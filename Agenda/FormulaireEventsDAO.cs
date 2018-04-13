using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Agenda
{
    public class FormulaireEventsDAO
    {
        private MySqlConnection conn;
        // Constructeur
        public FormulaireEventsDAO()
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

        public void addEvent(Event task)
        {
            try
            {
                this.conn.Open();

                MySqlCommand cmd = this.conn.CreateCommand();

                cmd.CommandText = "INSERT INTO `event`(`intitule`, `lieux`, `jour`, `heure`, `id_user`) VALUES (@intitule,@lieux,@jour,@heure,@idUser)";
                cmd.Parameters.AddWithValue("@intitule", task.Intitule);
                cmd.Parameters.AddWithValue("@lieux", task.Lieux);
                cmd.Parameters.AddWithValue("@jour", task.Date);
                cmd.Parameters.AddWithValue("@heure", task.Heure);
                cmd.Parameters.AddWithValue("@idUser", 1);

                cmd.ExecuteNonQuery();

                this.conn.Close();
            }
            catch(BddException e)
            {
                e.DisplayError();
            }
        }

        public MySqlDataReader getDataR()
        {
            string mySelectQuery = "SELECT * FROM event e INNER JOIN user u ON e.id_user = u.id";

            MySqlCommand myCommand = new MySqlCommand(mySelectQuery, this.conn);
            this.conn.Open();
            MySqlDataReader myReader;
            myReader = myCommand.ExecuteReader();
            // Close the connection when done with it.
            return myReader;
        }
    }
}
