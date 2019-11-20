/*
    Aufgabenliste:
    -Nach fehler, Ball in Mitte des zugehörigen Schlägers und auf Konpfdruck los.
    -Punkteanzeige für Spielmodus
    -Hauptmenü bei Start----Dafür noch optionen einbauen
    

    Bugs:
    -Nach Fehler bei Player2 immer folge fehler bei player1
    -player 2 erst nach drücken arrowdown bewegbar über w,s
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Microsoft.Win32;


namespace Pong
{
    public partial class Form1 : Form
    {
        struct spielball
        {
            public bool richtungX;
            public bool richtungY;
            public int winkel;
        }
        
        Graphics zeichenflaeche;
        Rectangle spielfeldGroesse;
        int spielfeldMaxX, spielfeldMaxY, spielfeldMinX, spielfeldMinY;
        int spielfeldLinienBreite;
        int schlaegergroesse;
        spielball balllPosition;
        SolidBrush pinsel;
        bool spielPause;
        int aktuelleSpielzeit;
        Font schrift;
        Score spielpunkte = new Score();
        int punkteMehr, punkteWeniger;
        int winkelZufall;
        int spielzeit;
        bool multiplayer;

        public string xmlDateiname;
        int xmlBreite;
        int xmlHoehe;
        int xmlSchwierigkeit;

        Color farbeHintergrund;
        Color farbeFuerAlles;
        
        // Initialisierung
        public Form1()
        {
            InitializeComponent();
            Password passwort = new Password();
            MainMenu menu = new MainMenu();
            spielfeldLinienBreite = 10;
            balllPosition.richtungX = true;
            balllPosition.richtungY = true;
            balllPosition.winkel = 0;
            punkteMehr = 1;
            punkteWeniger = -5;
            winkelZufall = 1;
            multiplayer = false;

            xmlDateiname = System.IO.Path.ChangeExtension(Application.ExecutablePath, ".xml");
            xmlSchwierigkeit = 3;
            xmlBreite = 640;
            xmlHoehe = 480;
            schlaegergroesse = 50;
            spielzeit = 120;
            comboBox1.SelectedIndex = 3;
            farbeHintergrund = Color.Black;
            farbeFuerAlles = Color.White;            

            leseReg();
            this.Height = xmlHoehe;
            this.Width = xmlBreite;            
                        
            pinsel = new SolidBrush(Color.Black);
            zeichenflaeche = panelFeld.CreateGraphics();
            panelFeld.BackColor = farbeHintergrund;
            setzeSpielfeld();
            neuerBall();
            
            object sender = "null";
            
            spielPause = true;
            aktuelleSpielzeit = timerSpielZeit.Interval / 1000;
            timer1.Enabled = false;
            timerSekunde.Enabled = false;
            timerSpielZeit.Enabled = false;
            schrift = new Font("Arial", 12, FontStyle.Bold);
            pauseToolStripMenuItem.Enabled = true;

            passwort.ShowDialog();
            menu.ShowDialog();
            multiplayer = menu.Multi_Player();
            spielfeldToolStripMenuItem_Click(sender, null);
        }

        void setzeSpielfeld()
        {
            spielfeldGroesse = panelFeld.ClientRectangle;
            spielfeldMaxX = spielfeldGroesse.Right - spielfeldLinienBreite;
            spielfeldMinX = spielfeldGroesse.Left + spielfeldLinienBreite + 1;
            spielfeldMaxY = spielfeldGroesse.Bottom - spielfeldLinienBreite;
            spielfeldMinY = spielfeldGroesse.Top + spielfeldLinienBreite;
        }
        

        // Oberfläche erschaffen        
        void zeichneSpielfeld()
        {
            pinsel.Color = farbeFuerAlles;
            zeichenflaeche.FillRectangle(pinsel, 0, 0, (spielfeldMaxX+2), spielfeldLinienBreite);            
            zeichenflaeche.FillRectangle(pinsel, 0, spielfeldMaxY, (spielfeldMaxX+2), spielfeldLinienBreite);

            //zeichenflaeche.FillRectangle(pinsel, spielfeldMaxX, 0, (spielfeldLinienBreite), spielfeldMaxY + spielfeldLinienBreite);
            

            pinsel.Color = Color.DarkSlateGray;
            zeichenflaeche.FillRectangle(pinsel, spielfeldMaxX / 2, spielfeldMinY, spielfeldLinienBreite, spielfeldMaxY - spielfeldLinienBreite);
        }

        void zeichneBall(Point position)
        {            
            Ball.Location = position;
            if (multiplayer == false)
            {
                if ((position.X + 10) >= spielfeldMaxX)
                    balllPosition.richtungX = false;
            }
            if ((position.Y + 10) >= spielfeldMaxY)
                balllPosition.richtungY = true;
            
            if (position.Y <= spielfeldMinY)
                balllPosition.richtungY = false;

            Random zufall = new Random();
            

            if ((position.X == spielfeldMinX) && ((Schlaeger.Top <= position.Y) && (Schlaeger.Bottom >= position.Y)))
            {
                if (balllPosition.richtungX == false)
                {
                    zeichnePunkte(Convert.ToString(spielpunkte.VeraenderePunkte(punkteMehr)));
                }
                balllPosition.richtungX = true;
                balllPosition.winkel = zufall.Next(winkelZufall);
            }

            if ((position.X+10 >= spielfeldMaxX) && ((Schlaeger2.Top <= position.Y) && (Schlaeger2.Bottom >= position.Y)))
            {
                if (balllPosition.richtungX == true)
                {
                    zeichnePunkte(Convert.ToString(spielpunkte.VeraenderePunkte(punkteMehr)));
                }
                balllPosition.richtungX = false;
                balllPosition.winkel = zufall.Next(winkelZufall);
            }

            if (position.X < spielfeldMinX)
            {
                //zeichnePunkte(Convert.ToString(spielpunkte.VeraenderePunkte(punkteWeniger)));
                System.Threading.Thread.Sleep(500);
                zeichneBall(new Point(spielfeldMinX, position.Y));
                balllPosition.richtungX = true;
            }
            if (multiplayer == true)
            {
                if (position.X > spielfeldMaxX)
                {
                    //zeichnePunkte(Convert.ToString(spielpunkte.VeraenderePunkte(punkteWeniger)));
                    System.Threading.Thread.Sleep(500);
                    zeichneBall(new Point(spielfeldMaxX, position.Y));
                    balllPosition.richtungX = false;
                }
            }
        }

        void zeichenSchlaeger1(int Y)
        {
            Schlaeger.Width = spielfeldLinienBreite;
            Schlaeger.Height = schlaegergroesse;
            Schlaeger.BackColor = farbeFuerAlles;
            Schlaeger.Left = 2;

            if (((Y + schlaegergroesse) < spielfeldMaxY) && (Y > spielfeldMinY))
                Schlaeger.Top = Y;
        }

        void zeichenSchlaeger2(int Y)
        {
            Schlaeger2.Width = spielfeldLinienBreite;
            Schlaeger2.Height = schlaegergroesse;
            Schlaeger2.BackColor = farbeFuerAlles;
            Schlaeger2.Left = (spielfeldMaxX);

            if (((Y + schlaegergroesse) < spielfeldMaxY) && (Y > spielfeldMinY))
                Schlaeger2.Top = Y;
        }

        private void panelFeld_Paint(object sender, PaintEventArgs e)
        {
            zeichneSpielfeld();
        }

        void neuerBall()
        {
            Ball.Width = 16;
            Ball.Height = 16;
            Ball.BackColor = farbeFuerAlles;
            
            zeichenSchlaeger1((spielfeldMaxY / 2) - (schlaegergroesse / 2));
            if (multiplayer == true)
            {
                zeichenSchlaeger2((spielfeldMaxY / 2) - (schlaegergroesse / 2));
            }
            zeichneBall(new Point(spielfeldMinX, spielfeldMaxY / 2));
        }

        void zeichneZeit(string restZeit)
        {
            pinsel.Color = panelFeld.BackColor;
            zeichenflaeche.FillRectangle(pinsel, spielfeldMaxX - 50, spielfeldMinY + 20, 30, 20);
            pinsel.Color = farbeFuerAlles;
            zeichenflaeche.DrawString(restZeit, schrift, pinsel, new Point(spielfeldMaxX - 50, spielfeldMinY + 20));
        }

        void zeichnePunkte(string punkte)
        {
            pinsel.Color = panelFeld.BackColor;

            zeichenflaeche.FillRectangle(pinsel, spielfeldMaxX - 50, spielfeldMinY + 40, 30, 20);
            pinsel.Color = farbeFuerAlles;

            zeichenflaeche.DrawString(punkte, schrift, pinsel, new Point(spielfeldMaxX - 50, spielfeldMinY + 40));
        }


        bool neuseSpiel()
        {
            bool ergebnis = false;
            if (MessageBox.Show("Neues Spiel starten?", "New Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                competitionToolStripMenuItem.Enabled = false;
                einstellungenToolStripMenuItem.Enabled = false;
                aktuelleSpielzeit = spielzeit;
                zeichneSpielfeld();
                neuerBall();
                zeichneZeit(Convert.ToString(aktuelleSpielzeit));
                spielpunkte.LoeschePunkte();
                zeichnePunkte("0");
                ergebnis = true;
                pauseToolStripMenuItem.Enabled = true;
            }
            else
            {
                ergebnis = false;
            }
            return ergebnis;
        }        


        // Steuerung        
        void Schlaeger_MouseMove(object sender, MouseEventArgs e)
        {
            if (spielPause == true)
                return;

            if (e.Button == MouseButtons.Left)
                zeichenSchlaeger1(e.Y + Schlaeger.Top);
        }

        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (spielPause == true)
                return;

            
            if (e.KeyData == Keys.W)
            {
                zeichenSchlaeger2(Schlaeger2.Top - 5);
                zeichenSchlaeger2(Schlaeger2.Top - 5);
                zeichenSchlaeger2(Schlaeger2.Top - 5);
                zeichenSchlaeger2(Schlaeger2.Top - 5);
                zeichenSchlaeger2(Schlaeger2.Top - 5);
                zeichenSchlaeger2(Schlaeger2.Top - 5);
            }

            if (e.KeyData == Keys.S)
            {
                zeichenSchlaeger2(Schlaeger2.Top + 5);
                zeichenSchlaeger2(Schlaeger2.Top + 5);
                zeichenSchlaeger2(Schlaeger2.Top + 5);
                zeichenSchlaeger2(Schlaeger2.Top + 5);
                zeichenSchlaeger2(Schlaeger2.Top + 5);
                zeichenSchlaeger2(Schlaeger2.Top + 5);                
            }
        }


        // Timer
        void timer1_Tick(object sender, EventArgs e)
        {
            int neuX = 0, neuY = 0;

            if (balllPosition.richtungX == true)
                neuX = Ball.Left + 5;
            else
                neuX = Ball.Left - 5;

            if (balllPosition.richtungY == true)
                neuY = Ball.Top - balllPosition.winkel;
            else
                neuY = Ball.Top + balllPosition.winkel;

            zeichneBall(new Point(neuX, neuY));
        }

        private void timerSekunde_Tick(object sender, EventArgs e)
        {
            aktuelleSpielzeit = aktuelleSpielzeit - 1;
            zeichneZeit(Convert.ToString(aktuelleSpielzeit));
        }

        private void timerSpielZeit_Tick(object sender, EventArgs e)
        {
            pauseToolStripMenuItem_Click(sender, e);
            if (spielpunkte.NeuerEintrag() == true)
            {
                Ball.Hide();
                Schlaeger.Hide();

                spielpunkte.ListeAusgeben(zeichenflaeche, spielfeldGroesse);
                System.Threading.Thread.Sleep(1000);
                zeichenflaeche.Clear(farbeHintergrund);
                Ball.Show();
                Schlaeger.Show();
            }

            MessageBox.Show("Die Zeit ist OVER!", "Game Over!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (neuseSpiel() == true)
            {
                pauseToolStripMenuItem_Click(sender, e);
            }
            else
            {
                competitionToolStripMenuItem.Enabled = true;
                zeichenflaeche = panelFeld.CreateGraphics();
                panelFeld.BackColor = farbeHintergrund;
                setzeSpielfeld();
                neuerBall();
                pauseToolStripMenuItem.Checked = false;
                einstellungenToolStripMenuItem.Enabled = false;
            }
        }


        // Tasten für Spiel
        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (spielPause == false)
            {
                timer1.Enabled = false;
                timerSekunde.Enabled = false;
                timerSpielZeit.Enabled = false;
                pauseToolStripMenuItem.Checked = true;
                this.Text = "PONG - Das Spiel ist angehalten!";
                spielPause = true;
            }
            else
            {
                timerSpielZeit.Interval = aktuelleSpielzeit * 1000;
                timer1.Enabled = true;
                timerSekunde.Enabled = true;
                timerSpielZeit.Enabled = true;
                pauseToolStripMenuItem.Checked = false;
                this.Text = "PONG";
                spielPause = false;
            }
        }

        private void neuStartenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (spielPause == false)
            {
                pauseToolStripMenuItem_Click(sender, e);
                neuseSpiel();
                pauseToolStripMenuItem_Click(sender, e);
            }
            else
            {
                if (neuseSpiel() == true)
                    pauseToolStripMenuItem_Click(sender, e);
            }
        }

        private void bestenlisteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool weiter = false;
            if (spielPause == false)
            {
                pauseToolStripMenuItem_Click(sender, e);
                weiter = true;
            }

            Ball.Hide();
            Schlaeger.Hide();

            spielpunkte.ListeAusgeben(zeichenflaeche, spielfeldGroesse);

            System.Threading.Thread.Sleep(4000);
            zeichenflaeche.Clear(panelFeld.BackColor);

            Ball.Show();
            Schlaeger.Show();

            if (weiter == true)
                pauseToolStripMenuItem_Click(sender, e);
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Tasten für Competition
        private void veryEasyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            setzeEinstellungen(schlaegergroesse+(schlaegergroesse/2), 1, -20, 2);

            veryEasyToolStripMenuItem.Checked = true;
            easyToolStripMenuItem.Checked = false;
            normiToolStripMenuItem.Checked = false;
            hardToolStripMenuItem.Checked = false;
            painInTheAssToolStripMenuItem.Checked = false;

            xmlSchwierigkeit = 1;
        }

        private void easyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 50;
            setzeEinstellungen(schlaegergroesse, 1, -5, 5);

            veryEasyToolStripMenuItem.Checked = false;
            easyToolStripMenuItem.Checked = true;
            normiToolStripMenuItem.Checked = false;
            hardToolStripMenuItem.Checked = false;
            painInTheAssToolStripMenuItem.Checked = false;

            xmlSchwierigkeit = 2;
        }

        private void normiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 25;
            setzeEinstellungen(schlaegergroesse, 3, -5, 15);

            veryEasyToolStripMenuItem.Checked = false;
            easyToolStripMenuItem.Checked = false;
            normiToolStripMenuItem.Checked = true;
            hardToolStripMenuItem.Checked = false;
            painInTheAssToolStripMenuItem.Checked = false;

            xmlSchwierigkeit = 3;
        }

        private void hardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 15;
            setzeEinstellungen(schlaegergroesse - (schlaegergroesse/2), 4, -5, 30);

            veryEasyToolStripMenuItem.Checked = false;
            easyToolStripMenuItem.Checked = false;
            normiToolStripMenuItem.Checked = false;
            hardToolStripMenuItem.Checked = true;
            painInTheAssToolStripMenuItem.Checked = false;

            xmlSchwierigkeit = 4;
        }

        private void painInTheAssToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 5;
            setzeEinstellungen(schlaegergroesse - (schlaegergroesse/10), 100, -5, 40);

            veryEasyToolStripMenuItem.Checked = false;
            easyToolStripMenuItem.Checked = false;
            normiToolStripMenuItem.Checked = false;
            hardToolStripMenuItem.Checked = false;
            painInTheAssToolStripMenuItem.Checked = true;

            xmlSchwierigkeit = 5;
        }

        // Tasten für Einstellungen
        private void spielfeldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color tempBack;
            Color tempRest;
            Point neueGroesse = new Point(0, 0);
            EinstellungenDialog neueWerte = new EinstellungenDialog();
            leseReg();
            neueWerte.Checked(xmlBreite);

            if (neueWerte.ShowDialog() == DialogResult.OK)
            {                
                neueGroesse = neueWerte.LiefereWerte();
                tempBack = neueWerte.LiefereFarbe1();
                tempRest = neueWerte.LiefereFarbe2();
                schlaegergroesse = neueWerte.setzeSchlaeger();

                neueWerte.Close();

                farbeFuerAlles = tempRest;
                panelFeld.BackColor = tempBack;
                Width = neueGroesse.X;
                Height = neueGroesse.Y;

                Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
                Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
                
                zeichenflaeche = panelFeld.CreateGraphics();
                setzeSpielfeld();
                zeichenflaeche.Clear(panelFeld.BackColor);
                neuerBall();
                schreibenReg(sender, null);
            }
        }

        private void spielToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (spielPause == false)
            {
                timer1.Enabled = false;
                timerSekunde.Enabled = false;
                timerSpielZeit.Enabled = false;
                pauseToolStripMenuItem.Checked = false;
                this.Text = "PONG - Das Spiel ist angehalten!";
                spielPause = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            spielzeit = Convert.ToInt32(comboBox1.Text);
        }

        private void schummelnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            spielpunkte.Schummeln();
        }


        // EInstellungen speichern und abrufen
        void setzeEinstellungen(int schlaeger, int mehr, int weniger, int winkel)
        {
            schlaegergroesse = schlaeger;
            punkteMehr = mehr;
            punkteWeniger = weniger;
            winkelZufall = winkel;
        }
     
        void leseEinstellungen()
        {
            if (System.IO.File.Exists(xmlDateiname) == false)
                return;

            XmlReader xmlLesen = XmlReader.Create(xmlDateiname);

            xmlLesen.ReadToFollowing("breite");
            xmlBreite = Convert.ToInt32(xmlLesen.ReadElementContentAsString());

            xmlLesen.ReadToFollowing("hoehe");
            xmlHoehe = Convert.ToInt32(xmlLesen.ReadElementContentAsString());

            xmlLesen.ReadToFollowing("schlaeger");
            schlaegergroesse = Convert.ToInt32(xmlLesen.ReadElementContentAsString());

            xmlLesen.ReadToFollowing("wert");
            xmlSchwierigkeit = Convert.ToInt32(xmlLesen.ReadElementContentAsString());

            xmlLesen.Close();

            switch(xmlSchwierigkeit)
            {
                case 1:
                    veryEasyToolStripMenuItem_Click(this, null);
                    break;
                case 2:
                    easyToolStripMenuItem_Click(this, null);
                    break;
                case 3:
                    normiToolStripMenuItem_Click(this, null);
                    break;
                case 4:
                    hardToolStripMenuItem_Click(this, null);
                    break;
                case 5:
                    painInTheAssToolStripMenuItem_Click(this, null);
                    break;
            }
        }

        private void schreibeEinstellungen(object sender, FormClosedEventArgs e)
        {
            XmlWriterSettings einstellungen = new XmlWriterSettings();
            einstellungen.Indent = true;

            XmlWriter xmlSchreiben = XmlWriter.Create(xmlDateiname, einstellungen);

            xmlSchreiben.WriteStartDocument();
            xmlSchreiben.WriteStartElement("pong");

            xmlSchreiben.WriteStartElement("groesse");
            xmlSchreiben.WriteElementString("breite", Convert.ToString(this.Width));
            xmlSchreiben.WriteElementString("hoehe", Convert.ToString(this.Height));
            xmlSchreiben.WriteElementString("schlaeger", Convert.ToString(schlaegergroesse));
            xmlSchreiben.WriteEndElement();

            xmlSchreiben.WriteStartElement("schwierigkeitsgrad");
            xmlSchreiben.WriteElementString("wert", Convert.ToString(xmlSchwierigkeit));
            xmlSchreiben.WriteEndElement();

            xmlSchreiben.WriteEndDocument();
            xmlSchreiben.Close();
        }



        //EinsendeAufgabe_15_2
        void schreibenReg(object sender, FormClosedEventArgs e)
        {
            RegistryKey regSchreiben;
            regSchreiben = Registry.CurrentUser.CreateSubKey("Sowftware\\Pong");
            regSchreiben.SetValue("breite", Convert.ToString(this.Width));
            regSchreiben.SetValue("hoehe", Convert.ToString(this.Height));
            regSchreiben.SetValue("schlaeger", Convert.ToString(schlaegergroesse));
            regSchreiben.SetValue("schwierigkeit", Convert.ToString(xmlSchwierigkeit));
            regSchreiben.SetValue("zeit", Convert.ToString(spielzeit));
            regSchreiben.Close();
        }

        void leseReg()
        {
            RegistryKey regPruefen;
            regPruefen = Registry.CurrentUser.OpenSubKey("Sowftware\\Pong");

            if (regPruefen == null)
            {
                return;
            }
            xmlBreite = Convert.ToInt32(regPruefen.GetValue("breite", null));
            xmlHoehe = Convert.ToInt32(regPruefen.GetValue("hoehe", null));
            schlaegergroesse = Convert.ToInt32(regPruefen.GetValue("schlaeger", null));
            xmlSchwierigkeit = Convert.ToInt32(regPruefen.GetValue("schwierigkeit", null));
            spielzeit = Convert.ToInt32(regPruefen.GetValue("zeit", null));
            regPruefen.Close();

            switch (xmlSchwierigkeit)
            {
                case 1:
                    veryEasyToolStripMenuItem_Click(this, null);
                    break;
                case 2:
                    easyToolStripMenuItem_Click(this, null);
                    break;
                case 3:
                    normiToolStripMenuItem_Click(this, null);
                    break;
                case 4:
                    hardToolStripMenuItem_Click(this, null);
                    break;
                case 5:
                    painInTheAssToolStripMenuItem_Click(this, null);
                    break;
            }

            switch (spielzeit)
            {
                case 30:
                    comboBox1.SelectedIndex = 0;
                    break;
                case 60:
                    comboBox1.SelectedIndex = 1;
                    break;
                case 90:
                    comboBox1.SelectedIndex = 2;
                    break;
                case 120:
                    comboBox1.SelectedIndex = 3;
                    break;
                case 150:
                    comboBox1.SelectedIndex = 4;
                    break;
                case 180:
                    comboBox1.SelectedIndex = 5;
                    break;
                case 15:
                    comboBox1.SelectedIndex = 6;
                    break;
            }
        }

        //EinsendeAufgabe_16_3
        private void bestenlisteDruckenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 Drucken = new Form3();
            Drucken.ShowDialog();            
        }
    }
}