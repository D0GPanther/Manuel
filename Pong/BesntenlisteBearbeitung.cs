
//###############EinsendeAufgabe_16_2#################

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
    public partial class BesntenlisteBearbeitung : Form
    {
        public BesntenlisteBearbeitung()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void LeseEinstellungen(string namen, int punkte, int anzahl)
        {
            
            
                switch (anzahl)
                {
                    case 0:
                        textBoxName1.Text = namen;
                        textBoxPunkte1.Text = Convert.ToString(punkte);
                        break;
                    case 1:
                        textBoxName2.Text = namen;
                        textBoxPunkte2.Text = Convert.ToString(punkte);
                        break;
                    case 2:
                        textBoxName3.Text = namen;
                        textBoxPunkte3.Text = Convert.ToString(punkte);
                        break;
                    case 3:
                        textBoxName4.Text = namen;
                        textBoxPunkte4.Text = Convert.ToString(punkte);
                        break;
                    case 4:
                        textBoxName5.Text = namen;
                        textBoxPunkte5.Text = Convert.ToString(punkte);
                        break;
                    case 5:
                        textBoxName6.Text = namen;
                        textBoxPunkte6.Text = Convert.ToString(punkte);
                        break;
                    case 6:
                        textBoxName7.Text = namen;
                        textBoxPunkte7.Text = Convert.ToString(punkte);
                        break;
                    case 7:
                        textBoxName8.Text = namen;
                        textBoxPunkte8.Text = Convert.ToString(punkte);
                        break;
                    case 8:
                        textBoxName9.Text = namen;
                        textBoxPunkte9.Text = Convert.ToString(punkte);
                        break;
                    case 9:
                        textBoxName10.Text = namen;
                        textBoxPunkte10.Text = Convert.ToString(punkte);
                        break;
                    
                
            }
        }

        public string SchreibeNamen(int anzahl)
        {
            switch(anzahl)
            {
                case 0:
                    return textBoxName1.Text;
                case 1:
                    return textBoxName2.Text;
                case 2:
                    return textBoxName3.Text;
                case 3:
                    return textBoxName4.Text;
                case 4:
                    return textBoxName5.Text;
                case 5:
                    return textBoxName6.Text;
                case 6:
                    return textBoxName7.Text;
                case 7:
                    return textBoxName8.Text;
                case 8:
                    return textBoxName9.Text;
                case 9:
                    return textBoxName10.Text;
            }
            return null;
        }

        public int SchreibePunkte(int anzahl)
        {
            switch (anzahl)
            {
                case 0:
                    return Convert.ToInt32(textBoxPunkte1.Text);
                case 1:
                    return Convert.ToInt32(textBoxPunkte2.Text);
                case 2:
                    return Convert.ToInt32(textBoxPunkte3.Text);
                case 3:
                    return Convert.ToInt32(textBoxPunkte4.Text);
                case 4:
                    return Convert.ToInt32(textBoxPunkte5.Text);
                case 5:
                    return Convert.ToInt32(textBoxPunkte6.Text);
                case 6:
                    return Convert.ToInt32(textBoxPunkte7.Text);
                case 7:
                    return Convert.ToInt32(textBoxPunkte8.Text);
                case 8:
                    return Convert.ToInt32(textBoxPunkte9.Text);
                case 9:
                    return Convert.ToInt32(textBoxPunkte10.Text);
            }
            return 0;
        }
    }
}
