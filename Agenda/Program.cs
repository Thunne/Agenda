using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    static class Program
    {
        static Form1 app;
        static FormulaireEvents app2;

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            app = new Form1();
            app.button1.Click += new EventHandler(buttonClick);

            Application.EnableVisualStyles();            
            Application.Run(app);
        }


        static void getContact(Event c)
        {
            Label label = new Label();
            label.Text = c.ToString();
            //app.addEvent(label);
        }   

        static void buttonClick(object sender, EventArgs e)
        {
            app2 = new FormulaireEvents();
            app2.listener += new FormulaireEvents.ContactListener(getContact);
            app2.Show();
        }


    }
}
