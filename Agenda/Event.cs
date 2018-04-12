using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
   public class Event 
    {
        private string intitule;
        private string lieux;
        private DateTime date;
        private string heure;

        public string Intitule { get => intitule; set => intitule = value; }
        public string Lieux { get => lieux; set => lieux = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Heure { get => heure; set => heure = value; }

        public Event(String intitule, String lieux, DateTime date, String heure)
        {
            this.intitule = intitule;
            this.lieux = lieux;
            this.date = date;
            this.heure = heure;
        }


        public override string ToString()
        {
            return "\n" + this.intitule + " " + this.lieux+" "+this.date+" "+this.heure;
        }
    }
}
