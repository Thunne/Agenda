using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class User
    {
        private string nom;
        private string prenom;
        private string pseudo;
        private string mdp;

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => Prenom; set => Prenom = value; }
        public string Pseudo { get => pseudo; set => pseudo = value; }
        public string Mdp { get => mdp; set => mdp = value; }

        public User(String pseudo, String mdp)
        {
            this.pseudo = pseudo;
            this.mdp = mdp;
        }

        public override string ToString()
        {
            return "Nom = " + this.nom + " \nPrenom = " + this.prenom + " \nPseudo = " + this.pseudo;
        }
    }
}
