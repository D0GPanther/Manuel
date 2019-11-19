using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Pong
{
    public partial class Password : Form
    {
        bool schliessen = false;
        int zaehler = 3;
        public Password()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Registrieren register = new Registrieren();
            register.ShowDialog();            
        }

        private void buttonBeenden_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            string kennwort;
            RegistryKey regSchluessel;
            regSchluessel = Registry.CurrentUser.OpenSubKey("Sowftware\\Pong\\User");
            kennwort = Convert.ToString(regSchluessel.GetValue(textBox2.Text));
            regSchluessel.Close();

            if(textBox2.Text == string.Empty)
            {
                MessageBox.Show("Bitte geben sie ein Benutzernamen ein.");
            }

            if (textBox1.Text == kennwort && textBox2.Text != string.Empty)
            {
                schliessen = true;
                Close();
            }
            else
            {
                MessageBox.Show("Falsches Kennwort, noch " + (zaehler - 1) +" Versuche.");
                zaehler = zaehler - 1;
                if (zaehler == 0)
                {
                    MessageBox.Show("Die Anwendung wird geschlossen!");
                    Application.Exit();
                }
                else
                {
                    textBox1.Clear();
                    textBox1.Select();
                }
            }
        }

        private void Password_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (schliessen == false)
            {
                Application.Exit();
            }
        }
    }
}