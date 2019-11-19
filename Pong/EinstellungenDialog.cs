using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    public partial class EinstellungenDialog : Form
    {
        int check;
        int schlaegergroesse;
        public EinstellungenDialog()
        {
            InitializeComponent();

            if (radioButton320.Checked == true)
                schlaegergroesse = 30;

            if (radioButton640.Checked == true)
                schlaegergroesse = 57;

            if (radioButton1024.Checked == true)
                schlaegergroesse = 100;

            if (radioButtonMax.Checked == true)
                schlaegergroesse = 125;
        }

        //EinsendeAufgabe_14_3
        public Color LiefereFarbe1()
        {
            return panelHintergrund.BackColor;
        }

        public Color LiefereFarbe2()
        {
            return panel1.BackColor;
        }

        private void buttonAbbruch_Click(object sender, EventArgs e)
        {
            Close();
        }
        public Point LiefereWerte()
        {
            Point rueckgabe = new Point(0, 0);

            if (radioButton320.Checked == true)
                rueckgabe = new Point(320, 200);

            if (radioButton640.Checked == true)
                rueckgabe = new Point(640, 480);

            if (radioButton1024.Checked == true)
                rueckgabe = new Point(1024, 768);

            if (radioButtonMax.Checked == true)
                rueckgabe = new Point(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

            return rueckgabe;
        }

        public int setzeSchlaeger()
        {
            if (radioButton320.Checked == true)
                schlaegergroesse = 30;

            if (radioButton640.Checked == true)
                schlaegergroesse = 75;

            if (radioButton1024.Checked == true)
                schlaegergroesse = 100;

            if (radioButtonMax.Checked == true)
                schlaegergroesse = 125;

            return schlaegergroesse;
        }

        public void Checked(int breite)
        {            
            check = breite;
        }

        //EinsendeAUfgabe_14_2
        private void EinstellungenDialog_Load(object sender, EventArgs e)
        {
            if (check == 320)
                radioButton320.Checked = true;

            if (check == 640)
                radioButton640.Checked = true;

            if (check == 1024)
                radioButton1024.Checked = true;

            if (check == SystemInformation.PrimaryMonitorSize.Width)
                radioButtonMax.Checked = true;
        }

        private void buttonFarbeFeld_Click(object sender, EventArgs e)
        {
            if(colorDialogHintergrund.ShowDialog() == DialogResult.OK)
            {
                panelHintergrund.BackColor = colorDialogHintergrund.Color;
            }
        }

        private void buttonFarbeBall_Click(object sender, EventArgs e)
        {
            if(colorDialogRand.ShowDialog() == DialogResult.OK)
            {
                panel1.BackColor = colorDialogRand.Color;
                panel3.BackColor = colorDialogRand.Color;
            }
        }
    }
}