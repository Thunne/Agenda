using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class FormulaireEvents : Form
    {
        public delegate void ContactListener(Contact c);
        public ContactListener listener;
        public FormulaireEvents()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Contact c = new Contact(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            listener(c);
            this.Close();
        }
    }
}
