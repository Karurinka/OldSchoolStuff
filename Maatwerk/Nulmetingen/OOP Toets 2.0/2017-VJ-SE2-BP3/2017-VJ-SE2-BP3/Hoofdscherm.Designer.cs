namespace _2017_VJ_SE2_BP3
{
    partial class Hoofdscherm
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
            this.btnNieuwCentraleAanmaken = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nudPrijsPerLiter = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nudStartTarief = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstVoertuigen = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnRitUitvoeren = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.nudRitVolume = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.nudRitGewicht = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.nudRitPassagiers = new System.Windows.Forms.NumericUpDown();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lstVoertuigenOnderweg = new System.Windows.Forms.ListBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnRitAfronden = new System.Windows.Forms.Button();
            this.btnRitSorteerKenteken = new System.Windows.Forms.Button();
            this.btnRitSorteerDatum = new System.Windows.Forms.Button();
            this.lstRitten = new System.Windows.Forms.ListBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrijsPerLiter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartTarief)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRitVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRitGewicht)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRitPassagiers)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNieuwCentraleAanmaken);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nudPrijsPerLiter);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudStartTarief);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(12, 3, 12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 102);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Centrale administratie";
            // 
            // btnNieuwCentraleAanmaken
            // 
            this.btnNieuwCentraleAanmaken.Location = new System.Drawing.Point(9, 71);
            this.btnNieuwCentraleAanmaken.Name = "btnNieuwCentraleAanmaken";
            this.btnNieuwCentraleAanmaken.Size = new System.Drawing.Size(169, 23);
            this.btnNieuwCentraleAanmaken.TabIndex = 4;
            this.btnNieuwCentraleAanmaken.Text = "Nieuwe centrale aanmaken";
            this.btnNieuwCentraleAanmaken.UseVisualStyleBackColor = true;
            this.btnNieuwCentraleAanmaken.Click += new System.EventHandler(this.btnNieuwCentraleAanmaken_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prijs per liter:";
            // 
            // nudPrijsPerLiter
            // 
            this.nudPrijsPerLiter.DecimalPlaces = 2;
            this.nudPrijsPerLiter.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.nudPrijsPerLiter.Location = new System.Drawing.Point(85, 45);
            this.nudPrijsPerLiter.Name = "nudPrijsPerLiter";
            this.nudPrijsPerLiter.Size = new System.Drawing.Size(93, 20);
            this.nudPrijsPerLiter.TabIndex = 2;
            this.nudPrijsPerLiter.Value = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Starttarief:";
            // 
            // nudStartTarief
            // 
            this.nudStartTarief.DecimalPlaces = 2;
            this.nudStartTarief.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.nudStartTarief.Location = new System.Drawing.Point(85, 19);
            this.nudStartTarief.Name = "nudStartTarief";
            this.nudStartTarief.Size = new System.Drawing.Size(93, 20);
            this.nudStartTarief.TabIndex = 0;
            this.nudStartTarief.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstVoertuigen);
            this.groupBox2.Location = new System.Drawing.Point(12, 120);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(12, 3, 12, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(189, 207);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Voertuigen";
            // 
            // lstVoertuigen
            // 
            this.lstVoertuigen.FormattingEnabled = true;
            this.lstVoertuigen.Location = new System.Drawing.Point(9, 21);
            this.lstVoertuigen.Name = "lstVoertuigen";
            this.lstVoertuigen.Size = new System.Drawing.Size(174, 173);
            this.lstVoertuigen.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnRitUitvoeren);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.nudRitVolume);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.nudRitGewicht);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.nudRitPassagiers);
            this.groupBox4.Location = new System.Drawing.Point(225, 12);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(12, 3, 12, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(189, 126);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Nieuwe rit";
            // 
            // btnRitUitvoeren
            // 
            this.btnRitUitvoeren.Location = new System.Drawing.Point(14, 97);
            this.btnRitUitvoeren.Name = "btnRitUitvoeren";
            this.btnRitUitvoeren.Size = new System.Drawing.Size(169, 23);
            this.btnRitUitvoeren.TabIndex = 3;
            this.btnRitUitvoeren.Text = "Rit uitvoeren";
            this.btnRitUitvoeren.UseVisualStyleBackColor = true;
            this.btnRitUitvoeren.Click += new System.EventHandler(this.btnRitUitvoeren_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Volume:";
            // 
            // nudRitVolume
            // 
            this.nudRitVolume.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.nudRitVolume.Location = new System.Drawing.Point(90, 71);
            this.nudRitVolume.Name = "nudRitVolume";
            this.nudRitVolume.Size = new System.Drawing.Size(93, 20);
            this.nudRitVolume.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Gewicht:";
            // 
            // nudRitGewicht
            // 
            this.nudRitGewicht.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudRitGewicht.Location = new System.Drawing.Point(90, 45);
            this.nudRitGewicht.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudRitGewicht.Name = "nudRitGewicht";
            this.nudRitGewicht.Size = new System.Drawing.Size(93, 20);
            this.nudRitGewicht.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "# passagiers:";
            // 
            // nudRitPassagiers
            // 
            this.nudRitPassagiers.Location = new System.Drawing.Point(90, 19);
            this.nudRitPassagiers.Name = "nudRitPassagiers";
            this.nudRitPassagiers.Size = new System.Drawing.Size(93, 20);
            this.nudRitPassagiers.TabIndex = 9;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.lstVoertuigenOnderweg);
            this.groupBox5.Controls.Add(this.numericUpDown1);
            this.groupBox5.Controls.Add(this.btnRitAfronden);
            this.groupBox5.Location = new System.Drawing.Point(225, 144);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(12, 3, 12, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(189, 183);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Voertuigen onderweg";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 127);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Gereden km:";
            // 
            // lstVoertuigenOnderweg
            // 
            this.lstVoertuigenOnderweg.FormattingEnabled = true;
            this.lstVoertuigenOnderweg.Location = new System.Drawing.Point(9, 19);
            this.lstVoertuigenOnderweg.Name = "lstVoertuigenOnderweg";
            this.lstVoertuigenOnderweg.Size = new System.Drawing.Size(174, 95);
            this.lstVoertuigenOnderweg.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(90, 125);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(93, 20);
            this.numericUpDown1.TabIndex = 15;
            // 
            // btnRitAfronden
            // 
            this.btnRitAfronden.Location = new System.Drawing.Point(9, 151);
            this.btnRitAfronden.Name = "btnRitAfronden";
            this.btnRitAfronden.Size = new System.Drawing.Size(174, 23);
            this.btnRitAfronden.TabIndex = 3;
            this.btnRitAfronden.Text = "Rit afronden";
            this.btnRitAfronden.UseVisualStyleBackColor = true;
            this.btnRitAfronden.Click += new System.EventHandler(this.btnRitAfronden_Click);
            // 
            // btnRitSorteerKenteken
            // 
            this.btnRitSorteerKenteken.Location = new System.Drawing.Point(9, 283);
            this.btnRitSorteerKenteken.Name = "btnRitSorteerKenteken";
            this.btnRitSorteerKenteken.Size = new System.Drawing.Size(174, 23);
            this.btnRitSorteerKenteken.TabIndex = 2;
            this.btnRitSorteerKenteken.Text = "Sorteer op kenteken";
            this.btnRitSorteerKenteken.UseVisualStyleBackColor = true;
            // 
            // btnRitSorteerDatum
            // 
            this.btnRitSorteerDatum.Location = new System.Drawing.Point(9, 254);
            this.btnRitSorteerDatum.Name = "btnRitSorteerDatum";
            this.btnRitSorteerDatum.Size = new System.Drawing.Size(174, 23);
            this.btnRitSorteerDatum.TabIndex = 1;
            this.btnRitSorteerDatum.Text = "Sorteer op datum";
            this.btnRitSorteerDatum.UseVisualStyleBackColor = true;
            // 
            // lstRitten
            // 
            this.lstRitten.FormattingEnabled = true;
            this.lstRitten.Location = new System.Drawing.Point(9, 21);
            this.lstRitten.Name = "lstRitten";
            this.lstRitten.Size = new System.Drawing.Size(174, 225);
            this.lstRitten.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnRitSorteerKenteken);
            this.groupBox7.Controls.Add(this.btnRitSorteerDatum);
            this.groupBox7.Controls.Add(this.lstRitten);
            this.groupBox7.Location = new System.Drawing.Point(438, 12);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(12, 3, 12, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(189, 315);
            this.groupBox7.TabIndex = 17;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Verzorgde ritten";
            // 
            // Hoofdscherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 336);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Hoofdscherm";
            this.Text = "Transportcentrale";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrijsPerLiter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartTarief)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRitVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRitGewicht)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRitPassagiers)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNieuwCentraleAanmaken;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudPrijsPerLiter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudStartTarief;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstVoertuigen;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnRitUitvoeren;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudRitVolume;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudRitGewicht;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nudRitPassagiers;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnRitSorteerKenteken;
        private System.Windows.Forms.Button btnRitSorteerDatum;
        private System.Windows.Forms.ListBox lstRitten;
        private System.Windows.Forms.Button btnRitAfronden;
        private System.Windows.Forms.ListBox lstVoertuigenOnderweg;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

