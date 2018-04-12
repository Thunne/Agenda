using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class FormulaireEvents : Form
    {
        public delegate void ContactListener(Event c);
        public ContactListener listener;
        public FormulaireEvents()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Parse(dateTimePicker1.Text);
            Event c = new Event(textBox1.Text, textBox2.Text, dt, textBox4.Text);
            c.Intitule = textBox1.Text;
            c.Lieux = textBox2.Text;
            c.Date = dt;
            c.DateHeure = textBox4.Text;
            listener(c);

            // Création de l'objet Bdd pour l'intéraction avec la base de donnée MySQL
            FormulaireEventsDAO bdd = new FormulaireEventsDAO();
            bdd.addEvent(c);


            this.Close();
        }
    }
}
