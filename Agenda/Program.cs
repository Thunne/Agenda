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
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            app = new Form1();
            app.button1.Click += new EventHandler(buttonClick);
            Application.Run(app);
        }

        static void buttonClick(object sender, EventArgs e)
        {
            formulaireEvents formulaireEvents = new formulaireEvents();
            formulaireEvents.Show();

        }


    }
}
