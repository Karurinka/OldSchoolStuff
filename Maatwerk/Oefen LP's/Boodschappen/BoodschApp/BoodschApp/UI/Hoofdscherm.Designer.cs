namespace BoodschApp
{
    partial class Form1
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
            this.lbVakerBesteld = new System.Windows.Forms.ListBox();
            this.lblBesteldeProducten = new System.Windows.Forms.Label();
            this.lbSupermarkten = new System.Windows.Forms.ListBox();
            this.lblWinkels = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbHuidigeProducten = new System.Windows.Forms.ListBox();
            this.lblProducten = new System.Windows.Forms.Label();
            this.lbProducten = new System.Windows.Forms.ListBox();
            this.lblGerechten = new System.Windows.Forms.Label();
            this.lbGerechten = new System.Windows.Forms.ListBox();
            this.btnBestel = new System.Windows.Forms.Button();
            this.btnSupermarkt = new System.Windows.Forms.Button();
            this.btnProducten = new System.Windows.Forms.Button();
            this.btnGerecht = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbVakerBesteld
            // 
            this.lbVakerBesteld.FormattingEnabled = true;
            this.lbVakerBesteld.Location = new System.Drawing.Point(12, 264);
            this.lbVakerBesteld.Name = "lbVakerBesteld";
            this.lbVakerBesteld.Size = new System.Drawing.Size(159, 134);
            this.lbVakerBesteld.TabIndex = 1;
            // 
            // lblBesteldeProducten
            // 
            this.lblBesteldeProducten.AutoSize = true;
            this.lblBesteldeProducten.Location = new System.Drawing.Point(12, 248);
            this.lblBesteldeProducten.Name = "lblBesteldeProducten";
            this.lblBesteldeProducten.Size = new System.Drawing.Size(99, 13);
            this.lblBesteldeProducten.TabIndex = 3;
            this.lblBesteldeProducten.Text = "Bestelde producten";
            // 
            // lbSupermarkten
            // 
            this.lbSupermarkten.FormattingEnabled = true;
            this.lbSupermarkten.Location = new System.Drawing.Point(15, 25);
            this.lbSupermarkten.Name = "lbSupermarkten";
            this.lbSupermarkten.Size = new System.Drawing.Size(159, 134);
            this.lbSupermarkten.TabIndex = 4;
            // 
            // lblWinkels
            // 
            this.lblWinkels.AutoSize = true;
            this.lblWinkels.Location = new System.Drawing.Point(12, 9);
            this.lblWinkels.Name = "lblWinkels";
            this.lblWinkels.Size = new System.Drawing.Size(79, 13);
            this.lblWinkels.TabIndex = 5;
            this.lblWinkels.Text = "Supermarkten: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Huidige producten:";
            // 
            // lbHuidigeProducten
            // 
            this.lbHuidigeProducten.FormattingEnabled = true;
            this.lbHuidigeProducten.Location = new System.Drawing.Point(271, 264);
            this.lbHuidigeProducten.Name = "lbHuidigeProducten";
            this.lbHuidigeProducten.Size = new System.Drawing.Size(159, 134);
            this.lbHuidigeProducten.TabIndex = 6;
            // 
            // lblProducten
            // 
            this.lblProducten.AutoSize = true;
            this.lblProducten.Location = new System.Drawing.Point(268, 9);
            this.lblProducten.Name = "lblProducten";
            this.lblProducten.Size = new System.Drawing.Size(59, 13);
            this.lblProducten.TabIndex = 9;
            this.lblProducten.Text = "Producten:";
            // 
            // lbProducten
            // 
            this.lbProducten.FormattingEnabled = true;
            this.lbProducten.Location = new System.Drawing.Point(271, 25);
            this.lbProducten.Name = "lbProducten";
            this.lbProducten.Size = new System.Drawing.Size(159, 134);
            this.lbProducten.TabIndex = 8;
            // 
            // lblGerechten
            // 
            this.lblGerechten.AutoSize = true;
            this.lblGerechten.Location = new System.Drawing.Point(513, 9);
            this.lblGerechten.Name = "lblGerechten";
            this.lblGerechten.Size = new System.Drawing.Size(60, 13);
            this.lblGerechten.TabIndex = 11;
            this.lblGerechten.Text = "Gerechten:";
            // 
            // lbGerechten
            // 
            this.lbGerechten.FormattingEnabled = true;
            this.lbGerechten.Location = new System.Drawing.Point(516, 25);
            this.lbGerechten.Name = "lbGerechten";
            this.lbGerechten.Size = new System.Drawing.Size(159, 134);
            this.lbGerechten.TabIndex = 10;
            // 
            // btnBestel
            // 
            this.btnBestel.Location = new System.Drawing.Point(516, 264);
            this.btnBestel.Name = "btnBestel";
            this.btnBestel.Size = new System.Drawing.Size(159, 134);
            this.btnBestel.TabIndex = 12;
            this.btnBestel.Text = "Bestel !";
            this.btnBestel.UseVisualStyleBackColor = true;
            this.btnBestel.Click += new System.EventHandler(this.btnBestel_Click);
            // 
            // btnSupermarkt
            // 
            this.btnSupermarkt.Location = new System.Drawing.Point(15, 166);
            this.btnSupermarkt.Name = "btnSupermarkt";
            this.btnSupermarkt.Size = new System.Drawing.Size(159, 23);
            this.btnSupermarkt.TabIndex = 13;
            this.btnSupermarkt.Text = "Kies supermarkt";
            this.btnSupermarkt.UseVisualStyleBackColor = true;
            this.btnSupermarkt.Click += new System.EventHandler(this.btnSupermarkt_Click);
            // 
            // btnProducten
            // 
            this.btnProducten.Location = new System.Drawing.Point(271, 166);
            this.btnProducten.Name = "btnProducten";
            this.btnProducten.Size = new System.Drawing.Size(159, 23);
            this.btnProducten.TabIndex = 14;
            this.btnProducten.Text = "Kies product";
            this.btnProducten.UseVisualStyleBackColor = true;
            this.btnProducten.Click += new System.EventHandler(this.btnProducten_Click);
            // 
            // btnGerecht
            // 
            this.btnGerecht.Location = new System.Drawing.Point(516, 166);
            this.btnGerecht.Name = "btnGerecht";
            this.btnGerecht.Size = new System.Drawing.Size(159, 23);
            this.btnGerecht.TabIndex = 15;
            this.btnGerecht.Text = "Kies gerecht";
            this.btnGerecht.UseVisualStyleBackColor = true;
            this.btnGerecht.Click += new System.EventHandler(this.btnGerechten_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 442);
            this.Controls.Add(this.btnGerecht);
            this.Controls.Add(this.btnProducten);
            this.Controls.Add(this.btnSupermarkt);
            this.Controls.Add(this.btnBestel);
            this.Controls.Add(this.lblGerechten);
            this.Controls.Add(this.lbGerechten);
            this.Controls.Add(this.lblProducten);
            this.Controls.Add(this.lbProducten);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbHuidigeProducten);
            this.Controls.Add(this.lblWinkels);
            this.Controls.Add(this.lbSupermarkten);
            this.Controls.Add(this.lblBesteldeProducten);
            this.Controls.Add(this.lbVakerBesteld);
            this.Name = "Form1";
            this.Text = "Hoofdscherm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbVakerBesteld;
        private System.Windows.Forms.Label lblBesteldeProducten;
        private System.Windows.Forms.ListBox lbSupermarkten;
        private System.Windows.Forms.Label lblWinkels;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbHuidigeProducten;
        private System.Windows.Forms.Label lblProducten;
        private System.Windows.Forms.ListBox lbProducten;
        private System.Windows.Forms.Label lblGerechten;
        private System.Windows.Forms.ListBox lbGerechten;
        private System.Windows.Forms.Button btnBestel;
        private System.Windows.Forms.Button btnSupermarkt;
        private System.Windows.Forms.Button btnProducten;
        private System.Windows.Forms.Button btnGerecht;
    }
}

