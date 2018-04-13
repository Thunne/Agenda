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
    public partial class Connexion : Form
    {
        static Form1 app2;
        static Connexion app;
        static FormulaireEvents app3;
        private DataSet userInfo;

        public Connexion()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User(textBox1.Text, textBox2.Text);
            // Création de l'objet Bdd pour l'intéraction avec la base de donnée MySQL
            ConnexionDAO bdd = new ConnexionDAO();
            userInfo = bdd.getUser(textBox1.Text);

            if(userInfo.Tables[0].Rows[0][3].Equals(textBox1.Text))
            {
                if(userInfo.Tables[0].Rows[0][4].Equals(sha1(textBox2.Text)))
                {
                   Program.app.Button1.Click += new EventHandler(buttonClick2);
                }
            }
            else
            {
                MessageBox.Show("Pseudo ou mot de passe incorrect",
                    "Erreur",
                    MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.Error);
            }
        }



        static void buttonClick2(object sender, EventArgs e)
        {
            app2 = new Form1();
            app2.button1.Click += new EventHandler(buttonClick3);
            app2.Show();
        }

        static void buttonClick3(object sender, EventArgs e)
        {
            app3 = new FormulaireEvents();
            app3.listener += new FormulaireEvents.ContactListener(getContact);
            app3.Show();
        }

        static void getContact(Event c)
        {
            app2.addEvent(c);
        }

        private string sha1(string randomString)
        {
            var crypt = new System.Security.Cryptography.SHA1Managed();
            var hash = new System.Text.StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(randomString));
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }
            return hash.ToString();
        }



    }
}
