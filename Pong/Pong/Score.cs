using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Media;


namespace Pong
{
    class Score
    {
        int punkte;
        int anzahl = 10;
        Liste[] bestenliste;
        string tempxmlDateiname;


        public Score()
        {
            punkte = 0;
            bestenliste = new Liste[anzahl];
            for (int i = 0; i < anzahl; i++)
            {
                bestenliste[i] = new Liste();
            }
            tempxmlDateiname = System.Windows.Forms.Application.StartupPath + "\\score.xml";
            if (System.IO.File.Exists(tempxmlDateiname))
                lesePunkte();
            else
            {
                schreibePunkte();
            }
        }

        public int VeraenderePunkte(int anzahl)
        {
            punkte = punkte + anzahl;
            return punkte;
        }

        public void LoeschePunkte()
        {
            punkte = 0;
        }

        public bool NeuerEintrag()
        {
            string tempName = string.Empty;

            if (punkte > bestenliste[anzahl - 1].GetPunkte())
            {
                Form2 neuerName = new Form2();
                if (neuerName.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    tempName = neuerName.LiefereName();
                }
                neuerName.Close();

                bestenliste[anzahl - 1].SetzeEintrag(punkte, tempName);
                Array.Sort(bestenliste);
                schreibePunkte();
                return true;
            }
            else
                return false;
        }

        public void ListeAusgeben(System.Drawing.Graphics zeichenflaeche, System.Drawing.RectangleF flaeche)
        {
            System.Drawing.SolidBrush tempPinsel = new System.Drawing.SolidBrush(System.Drawing.Color.White);

            System.Drawing.Font tempSchrift = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold);

            System.Drawing.StringFormat ausrichtung = new System.Drawing.StringFormat();

            float punktX, nameX, Y;
            punktX = (flaeche.Right / 2) + 150;
            nameX = (flaeche.Right / 2) - 150;
            Y = flaeche.Top + 50;
            ausrichtung.Alignment = System.Drawing.StringAlignment.Center;

            zeichenflaeche.Clear(System.Drawing.Color.Black);

            for (int i = 0; i < 10; i++)
            {
                SoundPlayer simpleSound = new SoundPlayer("C:\\Shared\\ILS_Hefte\\Pong\\Sound\\piano2.wav");
                if ((i % 2) != 0)
                    tempPinsel.Color = System.Drawing.Color.Pink;
                else
                    tempPinsel.Color = System.Drawing.Color.White;

                zeichenflaeche.DrawString("/************************************Bestenliste************************************\\", tempSchrift, tempPinsel, flaeche.Width / 2, Y, ausrichtung);
                simpleSound.Play();
                System.Threading.Thread.Sleep(250);
                zeichenflaeche.Clear(System.Drawing.Color.Black);
            }
            zeichenflaeche.Clear(System.Drawing.Color.Black);
            zeichenflaeche.DrawString("/************************************Bestenliste************************************\\", tempSchrift, tempPinsel, flaeche.Width / 2, Y, ausrichtung);
            Y = Y + 30;
            for (int i = 0; i < anzahl; i++)
            {
                Y = Y + 20;

                zeichenflaeche.DrawString(Convert.ToString(bestenliste[i].GetPunkte()), tempSchrift, tempPinsel, punktX, Y);

                zeichenflaeche.DrawString(Convert.ToString(bestenliste[i].GetName()), tempSchrift, tempPinsel, nameX, Y);
                System.Threading.Thread.Sleep(100);
            }
            zeichenflaeche.DrawString("\\************************************************************************************/", tempSchrift, tempPinsel, flaeche.Width / 2, (Y + 50), ausrichtung);
        }

        public string DruckenName(int temp)
        {
            return bestenliste[temp].GetName();
        }

        public int DruckenPunkte(int temp)
        {            
            return bestenliste[temp].GetPunkte();            
        }

        void lesePunkte()
        {
            int tempPunkte;
            string tempName;

            XmlReader xmlLesen = XmlReader.Create(tempxmlDateiname);

            for (int i = 0; i < anzahl; i++)
            {
                xmlLesen.ReadToFollowing("name");
                tempName = xmlLesen.ReadElementContentAsString();
                xmlLesen.ReadToFollowing("punkte");
                tempPunkte = Convert.ToInt32(xmlLesen.ReadElementContentAsString());

                bestenliste[i].SetzeEintrag(tempPunkte, tempName);
            }
            xmlLesen.Close();
        }

        void schreibePunkte()
        {
            XmlWriterSettings einstellungen = new XmlWriterSettings();
            einstellungen.Indent = true;

            XmlWriter xmlSchreiben = XmlWriter.Create(tempxmlDateiname, einstellungen);

            xmlSchreiben.WriteStartDocument();

            xmlSchreiben.WriteStartElement("bestenliste");
            for (int i = 0; i < anzahl; i++)
            {
                xmlSchreiben.WriteStartElement("eintrag");
                xmlSchreiben.WriteElementString("name", bestenliste[i].GetName());
                xmlSchreiben.WriteElementString("punkte", Convert.ToString(bestenliste[i].GetPunkte()));
                xmlSchreiben.WriteEndElement();
            }
            xmlSchreiben.WriteEndDocument();
            xmlSchreiben.Close();
        }

        public void Schummeln()
        {
            string tempName;
            int tempPunkte;
            XmlReader xmlLesen = XmlReader.Create(tempxmlDateiname);
            BesntenlisteBearbeitung Schummeln = new BesntenlisteBearbeitung();

            for (int temp = 0; temp < anzahl; temp++)
            {
                xmlLesen.ReadToFollowing("name");
                tempName = xmlLesen.ReadElementContentAsString();
                xmlLesen.ReadToFollowing("punkte");
                tempPunkte = Convert.ToInt32(xmlLesen.ReadElementContentAsString());
                bestenliste[temp].SetzeEintrag(tempPunkte, tempName);

                Schummeln.LeseEinstellungen(tempName, tempPunkte, temp);
            }
            xmlLesen.Close();
            if (Schummeln.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                for (int temp = 0; temp < anzahl; temp++)
                {
                    bestenliste[temp].SetName(Schummeln.SchreibeNamen(temp));
                    bestenliste[temp].SetPunkte(Schummeln.SchreibePunkte(temp));
                }
            }
            
            Array.Sort(bestenliste);
            schreibePunkte();
        }
    }

    class Liste : IComparable
    {
        int listePunkte;
        string listeName;

        public Liste()
        {
            listePunkte = 0;
            listeName = "XXX";
        }

        public int CompareTo(object objekt)
        {
            Liste tempListe = (Liste)(objekt);

            if (this.listePunkte < tempListe.listePunkte)
                return 1;

            if (this.listePunkte > tempListe.listePunkte)
                return -1;
            else
                return 0;
        }

        public void SetzeEintrag(int punkte, string name)
        {
            listePunkte = punkte;
            listeName = name;
        }

        public int GetPunkte()
        {
            return listePunkte;
        }

        public string GetName()
        {
            return listeName;
        }
        
        public void SetName(string tempName)
        {
            listeName = tempName;
        }

        public void SetPunkte(int tempPunkte)
        {
            listePunkte = tempPunkte;
        }        
    }
}