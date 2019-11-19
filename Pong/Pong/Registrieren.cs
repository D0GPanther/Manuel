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
    public partial class Registrieren : Form
    {
        bool schliessen = false;
        public Registrieren()
        {
            InitializeComponent();
        }

        private void buttonAbbrechen_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if(textBoxPasswort1.Text == string.Empty)
            {
                MessageBox.Show("Das Passwort muss mindestens ein Zeichen lang sein.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if(textBoxPasswort1.Text != textBoxPasswort2.Text)
            {
                MessageBox.Show("Die Passwörter sitmmen nicht überein.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(textBoxPasswort1.Text == textBoxPasswort2.Text)
            {
                schliessen = true;
                RegistryKey regSchluessel;
                regSchluessel = Registry.CurrentUser.CreateSubKey("Sowftware\\Pong\\User");
                regSchluessel.SetValue(textBox1.Text, textBoxPasswort1.Text);
                regSchluessel.Close();
                Close();
            }
        }

        private void Registrieren_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(schliessen == false)
            {
                Application.Exit();
            }
        }
    }
}