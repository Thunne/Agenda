using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Contact
    {
        private char intitule, lieux, jour;
        public delegate void handler(char intitule);
        public handler callback;

        

    }
}
