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

        public Form1()
        {
            InitializeComponent();
            //Création de l'objet Bdd pour l'intéraction avec la base de donnée MySQL
            FormulaireEventsDAO bdd = new FormulaireEventsDAO();
            eventInfo = bdd.getDataR();
            Console.Write("****************");
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
