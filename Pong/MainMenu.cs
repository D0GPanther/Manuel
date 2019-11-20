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
    public partial class MainMenu : Form
    {
        bool Multiplayer;
        
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Multiplayer = true;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Multiplayer = false;
            Close();
        }

        public bool Multi_Player()
        {
            return Multiplayer;
        }
    }
}
