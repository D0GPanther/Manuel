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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.White;
            Score liste = new Score();
            richTextBox1.Text = "\n";
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox1.AppendText("\t\t\t\t\t\t\t\tBestenliste");
            richTextBox1.AppendText(Environment.NewLine + "\n\n");

            
            richTextBox1.AppendText("\t\t\t\t\tName:\t\t\t\t\t\tPunkte:\n\n");
            for (int temp = 0; temp < 10; temp++)
            {                
                richTextBox1.AppendText("\t\t\t\t\t" +liste.DruckenName(temp) + "\t\t\t\t\t\t" + Convert.ToString(liste.DruckenPunkte(temp)) + "\n");
            }
        }

        private void buttonBeenden_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonDrucken_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog(richTextBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.White;
            richTextBox1.ForeColor = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.Black;
            richTextBox1.ForeColor = Color.White;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.Tomato;
            richTextBox1.ForeColor = Color.PaleGreen;
        }
    }
}