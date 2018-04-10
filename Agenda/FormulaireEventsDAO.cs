﻿using System;
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
        }

        public void addEvent(formulaireEvents task)
        {
            try
            {
                this.conn.Open();

                MySqlCommand cmd = this.conn.CreateCommand();

                cmd.CommandText = "INSERT INTO `event`(`intitule`, `lieux`, `jour`, `heure`, `id_user`) VALUES (@intitule,@lieux,@jour,@heure,@idUser)";
                cmd.Parameters.AddWithValue("@intitule", task.intitule);
                cmd.Parameters.AddWithValue("@lieux", task.lieux);
                cmd.Parameters.AddWithValue("@jour", task.jour);
                cmd.Parameters.AddWithValue("@heure", task.heure);
                cmd.Parameters.AddWithValue("@idUser", task.idUser);

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