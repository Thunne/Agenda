using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    public class BddException : Exception
    {
        public BddException() : base("Erreur lors de la connexion à la base de donnée")
        {
        }

        public void DisplayError()
        {
            Console.WriteLine(Message);
        }
    }
}
