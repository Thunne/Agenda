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
<<<<<<< Updated upstream
        public delegate void ContactListener(Event c);
=======
        public delegate void ContactListener(Events c);
>>>>>>> Stashed changes
        public ContactListener listener;
        public FormulaireEvents()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
            Event c = new Event(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            c.Intitule = textBox1.Text;
            c.Lieux = textBox2.Text;
            c.Jour = textBox3.Text;
            c.DateHeure = textBox4.Text;
=======
            Events c = new Events(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
>>>>>>> Stashed changes
            listener(c);

            // Création de l'objet Bdd pour l'intéraction avec la base de donnée MySQL
            FormulaireEventsDAO bdd = new FormulaireEventsDAO();
            bdd.addEvent(c);


            this.Close();
        }
    }
}
