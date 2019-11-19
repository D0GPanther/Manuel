namespace Pong
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.spielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuStartenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bestenlisteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.competitionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veryEasyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.easyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.painInTheAssToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einstellungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spielfeldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schummelnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bestenlisteDruckenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelFeld = new System.Windows.Forms.Panel();
            this.Ball = new System.Windows.Forms.Panel();
            this.Schlaeger = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerSpielZeit = new System.Windows.Forms.Timer(this.components);
            this.timerSekunde = new System.Windows.Forms.Timer(this.components);
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Schlaeger2 = new System.Windows.Forms.Panel();
            this.radioButtonMultiplayer = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.panelFeld.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spielToolStripMenuItem,
            this.competitionToolStripMenuItem,
            this.einstellungenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // spielToolStripMenuItem
            // 
            this.spielToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pauseToolStripMenuItem,
            this.neuStartenToolStripMenuItem,
            this.bestenlisteToolStripMenuItem,
            this.beendenToolStripMenuItem});
            this.spielToolStripMenuItem.Name = "spielToolStripMenuItem";
            this.spielToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.spielToolStripMenuItem.Text = "Spiel";
            this.spielToolStripMenuItem.Click += new System.EventHandler(this.spielToolStripMenuItem_Click);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.pauseToolStripMenuItem.Text = "&Pause beenden";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // neuStartenToolStripMenuItem
            // 
            this.neuStartenToolStripMenuItem.Name = "neuStartenToolStripMenuItem";
            this.neuStartenToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.neuStartenToolStripMenuItem.Text = "Neu Starten";
            this.neuStartenToolStripMenuItem.Click += new System.EventHandler(this.neuStartenToolStripMenuItem_Click);
            // 
            // bestenlisteToolStripMenuItem
            // 
            this.bestenlisteToolStripMenuItem.Name = "bestenlisteToolStripMenuItem";
            this.bestenlisteToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.bestenlisteToolStripMenuItem.Text = "Bestenliste";
            this.bestenlisteToolStripMenuItem.Click += new System.EventHandler(this.bestenlisteToolStripMenuItem_Click);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // competitionToolStripMenuItem
            // 
            this.competitionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.veryEasyToolStripMenuItem,
            this.easyToolStripMenuItem,
            this.normiToolStripMenuItem,
            this.hardToolStripMenuItem,
            this.painInTheAssToolStripMenuItem});
            this.competitionToolStripMenuItem.Name = "competitionToolStripMenuItem";
            this.competitionToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.competitionToolStripMenuItem.Text = "Competition";
            // 
            // veryEasyToolStripMenuItem
            // 
            this.veryEasyToolStripMenuItem.Name = "veryEasyToolStripMenuItem";
            this.veryEasyToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.veryEasyToolStripMenuItem.Text = "very easy";
            this.veryEasyToolStripMenuItem.Click += new System.EventHandler(this.veryEasyToolStripMenuItem_Click);
            // 
            // easyToolStripMenuItem
            // 
            this.easyToolStripMenuItem.Name = "easyToolStripMenuItem";
            this.easyToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.easyToolStripMenuItem.Text = "easy";
            this.easyToolStripMenuItem.Click += new System.EventHandler(this.easyToolStripMenuItem_Click);
            // 
            // normiToolStripMenuItem
            // 
            this.normiToolStripMenuItem.Name = "normiToolStripMenuItem";
            this.normiToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.normiToolStripMenuItem.Text = "normi";
            this.normiToolStripMenuItem.Click += new System.EventHandler(this.normiToolStripMenuItem_Click);
            // 
            // hardToolStripMenuItem
            // 
            this.hardToolStripMenuItem.Name = "hardToolStripMenuItem";
            this.hardToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.hardToolStripMenuItem.Text = "hard";
            this.hardToolStripMenuItem.Click += new System.EventHandler(this.hardToolStripMenuItem_Click);
            // 
            // painInTheAssToolStripMenuItem
            // 
            this.painInTheAssToolStripMenuItem.Name = "painInTheAssToolStripMenuItem";
            this.painInTheAssToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.painInTheAssToolStripMenuItem.Text = "pain in the ass";
            this.painInTheAssToolStripMenuItem.Click += new System.EventHandler(this.painInTheAssToolStripMenuItem_Click);
            // 
            // einstellungenToolStripMenuItem
            // 
            this.einstellungenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spielfeldToolStripMenuItem,
            this.schummelnToolStripMenuItem,
            this.bestenlisteDruckenToolStripMenuItem});
            this.einstellungenToolStripMenuItem.Name = "einstellungenToolStripMenuItem";
            this.einstellungenToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.einstellungenToolStripMenuItem.Text = "Einstellungen";
            // 
            // spielfeldToolStripMenuItem
            // 
            this.spielfeldToolStripMenuItem.Name = "spielfeldToolStripMenuItem";
            this.spielfeldToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.spielfeldToolStripMenuItem.Text = "Spielfeld";
            this.spielfeldToolStripMenuItem.Click += new System.EventHandler(this.spielfeldToolStripMenuItem_Click);
            // 
            // schummelnToolStripMenuItem
            // 
            this.schummelnToolStripMenuItem.Name = "schummelnToolStripMenuItem";
            this.schummelnToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.schummelnToolStripMenuItem.Text = "Schummeln";
            this.schummelnToolStripMenuItem.Click += new System.EventHandler(this.schummelnToolStripMenuItem_Click);
            // 
            // bestenlisteDruckenToolStripMenuItem
            // 
            this.bestenlisteDruckenToolStripMenuItem.Name = "bestenlisteDruckenToolStripMenuItem";
            this.bestenlisteDruckenToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.bestenlisteDruckenToolStripMenuItem.Text = "Bestenliste drucken";
            this.bestenlisteDruckenToolStripMenuItem.Click += new System.EventHandler(this.bestenlisteDruckenToolStripMenuItem_Click);
            // 
            // panelFeld
            // 
            this.panelFeld.Controls.Add(this.Schlaeger2);
            this.panelFeld.Controls.Add(this.Ball);
            this.panelFeld.Controls.Add(this.Schlaeger);
            this.panelFeld.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFeld.Location = new System.Drawing.Point(0, 24);
            this.panelFeld.Name = "panelFeld";
            this.panelFeld.Size = new System.Drawing.Size(624, 417);
            this.panelFeld.TabIndex = 1;
            this.panelFeld.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFeld_Paint);
            // 
            // Ball
            // 
            this.Ball.Location = new System.Drawing.Point(39, 163);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(47, 45);
            this.Ball.TabIndex = 1;
            // 
            // Schlaeger
            // 
            this.Schlaeger.Location = new System.Drawing.Point(9, 90);
            this.Schlaeger.Name = "Schlaeger";
            this.Schlaeger.Size = new System.Drawing.Size(14, 206);
            this.Schlaeger.TabIndex = 0;
            this.Schlaeger.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Schlaeger_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerSpielZeit
            // 
            this.timerSpielZeit.Interval = 120000;
            this.timerSpielZeit.Tick += new System.EventHandler(this.timerSpielZeit_Tick);
            // 
            // timerSekunde
            // 
            this.timerSekunde.Interval = 1000;
            this.timerSekunde.Tick += new System.EventHandler(this.timerSekunde_Tick);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 24);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 417);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "30",
            "60",
            "90",
            "120",
            "150",
            "180",
            "15"});
            this.comboBox1.Location = new System.Drawing.Point(503, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(435, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Spielzeit:";
            // 
            // Schlaeger2
            // 
            this.Schlaeger2.Location = new System.Drawing.Point(607, 114);
            this.Schlaeger2.Name = "Schlaeger2";
            this.Schlaeger2.Size = new System.Drawing.Size(14, 206);
            this.Schlaeger2.TabIndex = 2;
            // 
            // radioButtonMultiplayer
            // 
            this.radioButtonMultiplayer.AutoSize = true;
            this.radioButtonMultiplayer.Location = new System.Drawing.Point(344, 4);
            this.radioButtonMultiplayer.Name = "radioButtonMultiplayer";
            this.radioButtonMultiplayer.Size = new System.Drawing.Size(75, 17);
            this.radioButtonMultiplayer.TabIndex = 5;
            this.radioButtonMultiplayer.TabStop = true;
            this.radioButtonMultiplayer.Text = "Multiplayer";
            this.radioButtonMultiplayer.UseVisualStyleBackColor = true;
            this.radioButtonMultiplayer.CheckedChanged += new System.EventHandler(this.radioButtonMultiplayer_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.radioButtonMultiplayer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelFeld);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PONG";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.schreibenReg);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelFeld.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem spielToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.Panel panelFeld;
        private System.Windows.Forms.Panel Ball;
        private System.Windows.Forms.Panel Schlaeger;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerSpielZeit;
        private System.Windows.Forms.Timer timerSekunde;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ToolStripMenuItem neuStartenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bestenlisteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem competitionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veryEasyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem easyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem painInTheAssToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem einstellungenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spielfeldToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem schummelnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bestenlisteDruckenToolStripMenuItem;
        private System.Windows.Forms.Panel Schlaeger2;
        private System.Windows.Forms.RadioButton radioButtonMultiplayer;
    }
}