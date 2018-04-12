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
        private string dateHeure;

        public string Intitule { get => intitule; set => intitule = value; }
        public string Lieux { get => lieux; set => lieux = value; }
        public string DateHeure { get => dateHeure; set => dateHeure = value; }
        public DateTime Date { get => date; set => date = value; }

        public Event(String intitule, String lieux, DateTime date, String dateHeure)
        {
            this.intitule = intitule;
            this.lieux = lieux;
            this.date = date;
            this.DateHeure = dateHeure;
        }


        public override string ToString()
        {
            return this.intitule + " " + this.lieux+" "+this.date;
        }
    }
}
