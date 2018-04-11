using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
   public class Events 
    {
        private string intitule;
        private string lieux;
        private string jour;
        private string dateHeure;

        public string Intitule { get => intitule; set => intitule = value; }
        public string Lieux { get => lieux; set => lieux = value; }
        public string Jour { get => jour; set => jour = value; }
        public string DateHeure { get => dateHeure; set => dateHeure = value; }

        public Events(String intitule, String lieux, String jour, String dateHeure)
        {
            this.intitule = intitule;
            this.lieux = lieux;
            this.jour = jour;
            this.DateHeure = dateHeure;
        }

        public override string ToString()
        {
            return this.intitule + " " + this.lieux + " "+ this.jour;
        }
    }
}
