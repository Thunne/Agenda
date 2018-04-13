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

namespace Agenda
{
    public partial class Form1 : Form
    {
        private MySqlDataReader eventInfo;
        private MySqlDataReader userInfo;

        public Form1()
        {
            InitializeComponent();
            //Création de l'objet Bdd pour l'intéraction avec la base de donnée MySQL
            FormulaireEventsDAO bdd = new FormulaireEventsDAO();
            eventInfo = bdd.getDataR();
            
            while (eventInfo.Read())
            {
                Label l = new Label();
                this.Labels[eventInfo.GetMySqlDateTime(3).Day].Text += "\n" + eventInfo.GetString(1) + "\n" + eventInfo["lieux"] + "\n" + eventInfo.GetMySqlDateTime(3) + " " + eventInfo["heure"] + "\n" + eventInfo["prenom"];
            }
            //Close la connexion sql
            eventInfo.Close();

            ConnexionDAO bddUser = new ConnexionDAO();
            userInfo = bddUser.getAllUser();

            while (userInfo.Read())
            {
                Label user = new Label();
                this.LabelsUser[userInfo.GetInt32(0)].Text += "nom = " + userInfo.GetString(1) + "\nprenom = " +  userInfo.GetString(2);
            }
        }

        public object Button1 { get; internal set; }

        internal void addEvent(Event c)
        {
            Label l = new Label();
            l.Text=  c.ToString();
            this.Labels[c.Date.Day].Text += c.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
