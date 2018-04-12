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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public object Button1 { get; internal set; }

        internal void addEvent(Event c)
        {
            Label l = new Label();
            l.Text=  c.ToString();
            this.Labels[c.getDay()].Text += c.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
