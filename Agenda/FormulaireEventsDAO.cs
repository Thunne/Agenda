using System;
using System.Collections.Generic;
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
            /*if (!this.conn)
            {
                throw new 
            }*/
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
                cmd.Parameters.AddWithValue("@jour", task.Jour);
                cmd.Parameters.AddWithValue("@heure", task.DateHeure);
                cmd.Parameters.AddWithValue("@idUser", 1);

                cmd.ExecuteNonQuery();

                this.conn.Close();
            }
            catch(BddException e)
            {
                e.DisplayError();
            }
        }
    }
}
