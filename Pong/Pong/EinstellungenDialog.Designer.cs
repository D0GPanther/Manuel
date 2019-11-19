namespace Pong
{
    partial class EinstellungenDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonMax = new System.Windows.Forms.RadioButton();
            this.radioButton1024 = new System.Windows.Forms.RadioButton();
            this.radioButton640 = new System.Windows.Forms.RadioButton();
            this.radioButton320 = new System.Windows.Forms.RadioButton();
            this.buttonAnnehmen = new System.Windows.Forms.Button();
            this.buttonAbbruch = new System.Windows.Forms.Button();
            this.colorDialogHintergrund = new System.Windows.Forms.ColorDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelHintergrund = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonFarbeFeld = new System.Windows.Forms.Button();
            this.buttonFarbeBall = new System.Windows.Forms.Button();
            this.colorDialogRand = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panelHintergrund.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonMax);
            this.groupBox1.Controls.Add(this.radioButton1024);
            this.groupBox1.Controls.Add(this.radioButton640);
            this.groupBox1.Controls.Add(this.radioButton320);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 68);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Größe";
            // 
            // radioButtonMax
            // 
            this.radioButtonMax.AutoSize = true;
            this.radioButtonMax.Location = new System.Drawing.Point(225, 19);
            this.radioButtonMax.Name = "radioButtonMax";
            this.radioButtonMax.Size = new System.Drawing.Size(63, 17);
            this.radioButtonMax.TabIndex = 3;
            this.radioButtonMax.Text = "Maximal";
            this.radioButtonMax.UseVisualStyleBackColor = true;
            // 
            // radioButton1024
            // 
            this.radioButton1024.AutoSize = true;
            this.radioButton1024.Location = new System.Drawing.Point(148, 19);
            this.radioButton1024.Name = "radioButton1024";
            this.radioButton1024.Size = new System.Drawing.Size(71, 17);
            this.radioButton1024.TabIndex = 2;
            this.radioButton1024.Text = "1024*768";
            this.radioButton1024.UseVisualStyleBackColor = true;
            // 
            // radioButton640
            // 
            this.radioButton640.AutoSize = true;
            this.radioButton640.Checked = true;
            this.radioButton640.Location = new System.Drawing.Point(77, 19);
            this.radioButton640.Name = "radioButton640";
            this.radioButton640.Size = new System.Drawing.Size(65, 17);
            this.radioButton640.TabIndex = 1;
            this.radioButton640.TabStop = true;
            this.radioButton640.Text = "640*480";
            this.radioButton640.UseVisualStyleBackColor = true;
            // 
            // radioButton320
            // 
            this.radioButton320.AutoSize = true;
            this.radioButton320.Enabled = false;
            this.radioButton320.Location = new System.Drawing.Point(6, 19);
            this.radioButton320.Name = "radioButton320";
            this.radioButton320.Size = new System.Drawing.Size(65, 17);
            this.radioButton320.TabIndex = 0;
            this.radioButton320.Text = "320*200";
            this.radioButton320.UseVisualStyleBackColor = true;
            // 
            // buttonAnnehmen
            // 
            this.buttonAnnehmen.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAnnehmen.Location = new System.Drawing.Point(12, 319);
            this.buttonAnnehmen.Name = "buttonAnnehmen";
            this.buttonAnnehmen.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnehmen.TabIndex = 1;
            this.buttonAnnehmen.Text = "Annehmen";
            this.buttonAnnehmen.UseVisualStyleBackColor = true;
            // 
            // buttonAbbruch
            // 
            this.buttonAbbruch.Location = new System.Drawing.Point(237, 319);
            this.buttonAbbruch.Name = "buttonAbbruch";
            this.buttonAbbruch.Size = new System.Drawing.Size(75, 23);
            this.buttonAbbruch.TabIndex = 2;
            this.buttonAbbruch.Text = "Abbrechen";
            this.buttonAbbruch.UseVisualStyleBackColor = true;
            this.buttonAbbruch.Click += new System.EventHandler(this.buttonAbbruch_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(12, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 161);
            this.panel1.TabIndex = 3;
            // 
            // panelHintergrund
            // 
            this.panelHintergrund.BackColor = System.Drawing.Color.Black;
            this.panelHintergrund.Controls.Add(this.panel3);
            this.panelHintergrund.Location = new System.Drawing.Point(12, 155);
            this.panelHintergrund.Name = "panelHintergrund";
            this.panelHintergrund.Size = new System.Drawing.Size(288, 137);
            this.panelHintergrund.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(34, 67);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(20, 20);
            this.panel3.TabIndex = 4;
            // 
            // buttonFarbeFeld
            // 
            this.buttonFarbeFeld.Location = new System.Drawing.Point(168, 114);
            this.buttonFarbeFeld.Name = "buttonFarbeFeld";
            this.buttonFarbeFeld.Size = new System.Drawing.Size(75, 23);
            this.buttonFarbeFeld.TabIndex = 4;
            this.buttonFarbeFeld.Text = "Hintergrund";
            this.buttonFarbeFeld.UseVisualStyleBackColor = true;
            this.buttonFarbeFeld.Click += new System.EventHandler(this.buttonFarbeFeld_Click);
            // 
            // buttonFarbeBall
            // 
            this.buttonFarbeBall.Location = new System.Drawing.Point(87, 114);
            this.buttonFarbeBall.Name = "buttonFarbeBall";
            this.buttonFarbeBall.Size = new System.Drawing.Size(75, 23);
            this.buttonFarbeBall.TabIndex = 5;
            this.buttonFarbeBall.Text = "Rand";
            this.buttonFarbeBall.UseVisualStyleBackColor = true;
            this.buttonFarbeBall.Click += new System.EventHandler(this.buttonFarbeBall_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Farbwahl:";
            // 
            // EinstellungenDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 359);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonFarbeBall);
            this.Controls.Add(this.buttonFarbeFeld);
            this.Controls.Add(this.panelHintergrund);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonAbbruch);
            this.Controls.Add(this.buttonAnnehmen);
            this.Controls.Add(this.groupBox1);
            this.Name = "EinstellungenDialog";
            this.Text = "EinstellungenDialog";
            this.Load += new System.EventHandler(this.EinstellungenDialog_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelHintergrund.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAnnehmen;
        private System.Windows.Forms.Button buttonAbbruch;
        private System.Windows.Forms.RadioButton radioButtonMax;
        private System.Windows.Forms.RadioButton radioButton1024;
        private System.Windows.Forms.RadioButton radioButton640;
        private System.Windows.Forms.RadioButton radioButton320;
        private System.Windows.Forms.ColorDialog colorDialogHintergrund;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelHintergrund;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonFarbeFeld;
        private System.Windows.Forms.Button buttonFarbeBall;
        private System.Windows.Forms.ColorDialog colorDialogRand;
        private System.Windows.Forms.Label label1;
    }
}