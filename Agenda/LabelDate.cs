using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    class LabelDate : Label
    {
        private int val;
        
        public int Value
        {
            get
            {
                return val;
            }
            set
            {
                val = value;
            }
        }

        public LabelDate(int n)
        {
            val = n;
            this.Text = n.ToString();
            this.Size = new System.Drawing.Size(100, 100);
        }
    }
}
