namespace BakkerijGoedGeSpelt
{
    partial class bakkerijForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bakkerijForm));
            this.gbBroodjes = new System.Windows.Forms.GroupBox();
            this.btMaakPrijsLijst = new System.Windows.Forms.Button();
            this.btHaalBroodjesOp = new System.Windows.Forms.Button();
            this.btSlaBroodjesOp = new System.Windows.Forms.Button();
            this.lblBeleg = new System.Windows.Forms.Label();
            this.lblGeselecteerdBroodje = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbToevoegen = new System.Windows.Forms.GroupBox();
            this.btBroodjeKlaar = new System.Windows.Forms.Button();
            this.btBelegToevoegen = new System.Windows.Forms.Button();
            this.cbBeleg = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btBroodjeAanmaken = new System.Windows.Forms.Button();
            this.cbBroodSoorten = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNaamBroodje = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbBroodjes = new System.Windows.Forms.ListBox();
            this.gbBroodjes.SuspendLayout();
            this.gbToevoegen.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbBroodjes
            // 
            this.gbBroodjes.BackColor = System.Drawing.Color.Ivory;
            this.gbBroodjes.Controls.Add(this.btMaakPrijsLijst);
            this.gbBroodjes.Controls.Add(this.btHaalBroodjesOp);
            this.gbBroodjes.Controls.Add(this.btSlaBroodjesOp);
            this.gbBroodjes.Controls.Add(this.lblBeleg);
            this.gbBroodjes.Controls.Add(this.lblGeselecteerdBroodje);
            this.gbBroodjes.Controls.Add(this.label4);
            this.gbBroodjes.Controls.Add(this.gbToevoegen);
            this.gbBroodjes.Controls.Add(this.lbBroodjes);
            this.gbBroodjes.Location = new System.Drawing.Point(22, 31);
            this.gbBroodjes.Name = "gbBroodjes";
            this.gbBroodjes.Size = new System.Drawing.Size(721, 386);
            this.gbBroodjes.TabIndex = 0;
            this.gbBroodjes.TabStop = false;
            this.gbBroodjes.Text = "Broodjes";
            // 
            // btMaakPrijsLijst
            // 
            this.btMaakPrijsLijst.Location = new System.Drawing.Point(421, 284);
            this.btMaakPrijsLijst.Name = "btMaakPrijsLijst";
            this.btMaakPrijsLijst.Size = new System.Drawing.Size(279, 38);
            this.btMaakPrijsLijst.TabIndex = 7;
            this.btMaakPrijsLijst.Text = "Maak prijslijst";
            this.btMaakPrijsLijst.UseVisualStyleBackColor = true;
            this.btMaakPrijsLijst.Click += new System.EventHandler(this.btMaakPrijsLijst_Click);
            // 
            // btHaalBroodjesOp
            // 
            this.btHaalBroodjesOp.Location = new System.Drawing.Point(570, 328);
            this.btHaalBroodjesOp.Name = "btHaalBroodjesOp";
            this.btHaalBroodjesOp.Size = new System.Drawing.Size(130, 37);
            this.btHaalBroodjesOp.TabIndex = 6;
            this.btHaalBroodjesOp.Text = "Haal broodjes op";
            this.btHaalBroodjesOp.UseVisualStyleBackColor = true;
            // 
            // btSlaBroodjesOp
            // 
            this.btSlaBroodjesOp.Location = new System.Drawing.Point(421, 328);
            this.btSlaBroodjesOp.Name = "btSlaBroodjesOp";
            this.btSlaBroodjesOp.Size = new System.Drawing.Size(130, 37);
            this.btSlaBroodjesOp.TabIndex = 5;
            this.btSlaBroodjesOp.Text = "Sla broodjes op";
            this.btSlaBroodjesOp.UseVisualStyleBackColor = true;
            this.btSlaBroodjesOp.Click += new System.EventHandler(this.btSlaBroodjesOp_Click);
            // 
            // lblBeleg
            // 
            this.lblBeleg.AutoSize = true;
            this.lblBeleg.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeleg.Location = new System.Drawing.Point(402, 85);
            this.lblBeleg.Name = "lblBeleg";
            this.lblBeleg.Size = new System.Drawing.Size(21, 20);
            this.lblBeleg.TabIndex = 4;
            this.lblBeleg.Text = "...";
            // 
            // lblGeselecteerdBroodje
            // 
            this.lblGeselecteerdBroodje.AutoSize = true;
            this.lblGeselecteerdBroodje.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeselecteerdBroodje.Location = new System.Drawing.Point(400, 47);
            this.lblGeselecteerdBroodje.Name = "lblGeselecteerdBroodje";
            this.lblGeselecteerdBroodje.Size = new System.Drawing.Size(22, 23);
            this.lblGeselecteerdBroodje.TabIndex = 3;
            this.lblGeselecteerdBroodje.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(403, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Informatie broodje:";
            // 
            // gbToevoegen
            // 
            this.gbToevoegen.Controls.Add(this.btBroodjeKlaar);
            this.gbToevoegen.Controls.Add(this.btBelegToevoegen);
            this.gbToevoegen.Controls.Add(this.cbBeleg);
            this.gbToevoegen.Controls.Add(this.label3);
            this.gbToevoegen.Controls.Add(this.btBroodjeAanmaken);
            this.gbToevoegen.Controls.Add(this.cbBroodSoorten);
            this.gbToevoegen.Controls.Add(this.label2);
            this.gbToevoegen.Controls.Add(this.tbNaamBroodje);
            this.gbToevoegen.Controls.Add(this.label1);
            this.gbToevoegen.Location = new System.Drawing.Point(6, 19);
            this.gbToevoegen.Name = "gbToevoegen";
            this.gbToevoegen.Size = new System.Drawing.Size(225, 183);
            this.gbToevoegen.TabIndex = 1;
            this.gbToevoegen.TabStop = false;
            this.gbToevoegen.Text = "Broodje toevoegen";
            // 
            // btBroodjeKlaar
            // 
            this.btBroodjeKlaar.Enabled = false;
            this.btBroodjeKlaar.Location = new System.Drawing.Point(117, 150);
            this.btBroodjeKlaar.Name = "btBroodjeKlaar";
            this.btBroodjeKlaar.Size = new System.Drawing.Size(102, 23);
            this.btBroodjeKlaar.TabIndex = 8;
            this.btBroodjeKlaar.Text = "Broodje is klaar";
            this.btBroodjeKlaar.UseVisualStyleBackColor = true;
            // 
            // btBelegToevoegen
            // 
            this.btBelegToevoegen.Enabled = false;
            this.btBelegToevoegen.Location = new System.Drawing.Point(14, 150);
            this.btBelegToevoegen.Name = "btBelegToevoegen";
            this.btBelegToevoegen.Size = new System.Drawing.Size(102, 23);
            this.btBelegToevoegen.TabIndex = 7;
            this.btBelegToevoegen.Text = "Beleg toevoegen";
            this.btBelegToevoegen.UseVisualStyleBackColor = true;
            // 
            // cbBeleg
            // 
            this.cbBeleg.Enabled = false;
            this.cbBeleg.FormattingEnabled = true;
            this.cbBeleg.Location = new System.Drawing.Point(77, 123);
            this.cbBeleg.Name = "cbBeleg";
            this.cbBeleg.Size = new System.Drawing.Size(131, 21);
            this.cbBeleg.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Beleg:";
            // 
            // btBroodjeAanmaken
            // 
            this.btBroodjeAanmaken.Location = new System.Drawing.Point(53, 90);
            this.btBroodjeAanmaken.Name = "btBroodjeAanmaken";
            this.btBroodjeAanmaken.Size = new System.Drawing.Size(122, 23);
            this.btBroodjeAanmaken.TabIndex = 4;
            this.btBroodjeAanmaken.Text = "Broodje toevoegen";
            this.btBroodjeAanmaken.UseVisualStyleBackColor = true;
            this.btBroodjeAanmaken.Click += new System.EventHandler(this.btBroodjeAanmaken_Click);
            // 
            // cbBroodSoorten
            // 
            this.cbBroodSoorten.FormattingEnabled = true;
            this.cbBroodSoorten.Location = new System.Drawing.Point(77, 58);
            this.cbBroodSoorten.Name = "cbBroodSoorten";
            this.cbBroodSoorten.Size = new System.Drawing.Size(131, 21);
            this.cbBroodSoorten.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Broodsoort:";
            // 
            // tbNaamBroodje
            // 
            this.tbNaamBroodje.Location = new System.Drawing.Point(77, 28);
            this.tbNaamBroodje.Name = "tbNaamBroodje";
            this.tbNaamBroodje.Size = new System.Drawing.Size(131, 20);
            this.tbNaamBroodje.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naam:";
            // 
            // lbBroodjes
            // 
            this.lbBroodjes.FormattingEnabled = true;
            this.lbBroodjes.Location = new System.Drawing.Point(237, 24);
            this.lbBroodjes.Name = "lbBroodjes";
            this.lbBroodjes.Size = new System.Drawing.Size(160, 342);
            this.lbBroodjes.TabIndex = 0;
            // 
            // bakkerijForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(780, 446);
            this.Controls.Add(this.gbBroodjes);
            this.Name = "bakkerijForm";
            this.Text = "Bakkerij GoedGeSpelt";
            this.gbBroodjes.ResumeLayout(false);
            this.gbBroodjes.PerformLayout();
            this.gbToevoegen.ResumeLayout(false);
            this.gbToevoegen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBroodjes;
        private System.Windows.Forms.GroupBox gbToevoegen;
        private System.Windows.Forms.Button btBelegToevoegen;
        private System.Windows.Forms.ComboBox cbBeleg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btBroodjeAanmaken;
        private System.Windows.Forms.ComboBox cbBroodSoorten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNaamBroodje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbBroodjes;
        private System.Windows.Forms.Button btBroodjeKlaar;
        private System.Windows.Forms.Label lblBeleg;
        private System.Windows.Forms.Label lblGeselecteerdBroodje;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btMaakPrijsLijst;
        private System.Windows.Forms.Button btHaalBroodjesOp;
        private System.Windows.Forms.Button btSlaBroodjesOp;
    }
}

