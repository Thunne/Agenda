using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    static class Program
    {
        public static Connexion app;
        static Form1 app2;
        static FormulaireEvents app3;

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            app = new Connexion();

            Application.EnableVisualStyles();            
            Application.Run(app);
        }

        static void getContact(Event c)
        {
            app2.addEvent(c);
        }


        static void buttonClick(object sender, EventArgs e)
        {
            app3 = new FormulaireEvents();
            app3.listener += new FormulaireEvents.ContactListener(getContact);
            app3.Show();
        }

        static void buttonClick2(object sender, EventArgs e)
        {
            app2 = new Form1();
            app2.button1.Click += new EventHandler(buttonClick3);
            app2.Show();
        }

        static void buttonClick3(object sender, EventArgs e)
        {
            app3 = new FormulaireEvents();
            app3.listener += new FormulaireEvents.ContactListener(getContact);
            app3.Show();
        }


    }
}
