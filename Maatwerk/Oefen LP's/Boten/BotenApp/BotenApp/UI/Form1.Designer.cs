namespace BotenApp
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
            this.lblBudget = new System.Windows.Forms.Label();
            this.lblBoten = new System.Windows.Forms.Label();
            this.tbBudget = new System.Windows.Forms.TextBox();
            this.btnBudget = new System.Windows.Forms.Button();
            this.lbBoten = new System.Windows.Forms.ListBox();
            this.lblExtraArtiekelen = new System.Windows.Forms.Label();
            this.lbExtraArtiekelen = new System.Windows.Forms.ListBox();
            this.lblWateren = new System.Windows.Forms.Label();
            this.lbWateren = new System.Windows.Forms.ListBox();
            this.lblHuurcontract = new System.Windows.Forms.Label();
            this.lbHuurcontract = new System.Windows.Forms.ListBox();
            this.lbEerdereHuurcontracten = new System.Windows.Forms.ListBox();
            this.lblEerdereHuurcontracten = new System.Windows.Forms.Label();
            this.btnBevestig = new System.Windows.Forms.Button();
            this.btnExporteren = new System.Windows.Forms.Button();
            this.btnVoegBootToe = new System.Windows.Forms.Button();
            this.btnVoegArtiekelToe = new System.Windows.Forms.Button();
            this.btnVoegWaterToe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.Location = new System.Drawing.Point(13, 13);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(47, 13);
            this.lblBudget.TabIndex = 0;
            this.lblBudget.Text = "Budget: ";
            // 
            // lblBoten
            // 
            this.lblBoten.AutoSize = true;
            this.lblBoten.Location = new System.Drawing.Point(13, 45);
            this.lblBoten.Name = "lblBoten";
            this.lblBoten.Size = new System.Drawing.Size(41, 13);
            this.lblBoten.TabIndex = 1;
            this.lblBoten.Text = "Boten: ";
            // 
            // tbBudget
            // 
            this.tbBudget.Location = new System.Drawing.Point(66, 10);
            this.tbBudget.Name = "tbBudget";
            this.tbBudget.Size = new System.Drawing.Size(100, 20);
            this.tbBudget.TabIndex = 2;
            // 
            // btnBudget
            // 
            this.btnBudget.Location = new System.Drawing.Point(190, 8);
            this.btnBudget.Name = "btnBudget";
            this.btnBudget.Size = new System.Drawing.Size(116, 23);
            this.btnBudget.TabIndex = 3;
            this.btnBudget.Text = "Bevestig budget";
            this.btnBudget.UseVisualStyleBackColor = true;
            this.btnBudget.Click += new System.EventHandler(this.btnBudget_Click);
            // 
            // lbBoten
            // 
            this.lbBoten.FormattingEnabled = true;
            this.lbBoten.Location = new System.Drawing.Point(16, 61);
            this.lbBoten.Name = "lbBoten";
            this.lbBoten.Size = new System.Drawing.Size(332, 108);
            this.lbBoten.TabIndex = 4;
            // 
            // lblExtraArtiekelen
            // 
            this.lblExtraArtiekelen.AutoSize = true;
            this.lblExtraArtiekelen.Location = new System.Drawing.Point(369, 45);
            this.lblExtraArtiekelen.Name = "lblExtraArtiekelen";
            this.lblExtraArtiekelen.Size = new System.Drawing.Size(86, 13);
            this.lblExtraArtiekelen.TabIndex = 5;
            this.lblExtraArtiekelen.Text = "Extra artiekelen: ";
            // 
            // lbExtraArtiekelen
            // 
            this.lbExtraArtiekelen.FormattingEnabled = true;
            this.lbExtraArtiekelen.Location = new System.Drawing.Point(372, 61);
            this.lbExtraArtiekelen.Name = "lbExtraArtiekelen";
            this.lbExtraArtiekelen.Size = new System.Drawing.Size(332, 108);
            this.lbExtraArtiekelen.TabIndex = 6;
            // 
            // lblWateren
            // 
            this.lblWateren.AutoSize = true;
            this.lblWateren.Location = new System.Drawing.Point(709, 45);
            this.lblWateren.Name = "lblWateren";
            this.lblWateren.Size = new System.Drawing.Size(54, 13);
            this.lblWateren.TabIndex = 7;
            this.lblWateren.Text = "Wateren: ";
            // 
            // lbWateren
            // 
            this.lbWateren.FormattingEnabled = true;
            this.lbWateren.Location = new System.Drawing.Point(712, 61);
            this.lbWateren.Name = "lbWateren";
            this.lbWateren.Size = new System.Drawing.Size(332, 108);
            this.lbWateren.TabIndex = 8;
            // 
            // lblHuurcontract
            // 
            this.lblHuurcontract.AutoSize = true;
            this.lblHuurcontract.Location = new System.Drawing.Point(12, 208);
            this.lblHuurcontract.Name = "lblHuurcontract";
            this.lblHuurcontract.Size = new System.Drawing.Size(75, 13);
            this.lblHuurcontract.TabIndex = 9;
            this.lblHuurcontract.Text = "Huurcontract: ";
            // 
            // lbHuurcontract
            // 
            this.lbHuurcontract.FormattingEnabled = true;
            this.lbHuurcontract.Location = new System.Drawing.Point(16, 224);
            this.lbHuurcontract.Name = "lbHuurcontract";
            this.lbHuurcontract.Size = new System.Drawing.Size(332, 160);
            this.lbHuurcontract.TabIndex = 10;
            // 
            // lbEerdereHuurcontracten
            // 
            this.lbEerdereHuurcontracten.FormattingEnabled = true;
            this.lbEerdereHuurcontracten.Location = new System.Drawing.Point(712, 224);
            this.lbEerdereHuurcontracten.Name = "lbEerdereHuurcontracten";
            this.lbEerdereHuurcontracten.Size = new System.Drawing.Size(330, 160);
            this.lbEerdereHuurcontracten.TabIndex = 12;
            // 
            // lblEerdereHuurcontracten
            // 
            this.lblEerdereHuurcontracten.AutoSize = true;
            this.lblEerdereHuurcontracten.Location = new System.Drawing.Point(709, 208);
            this.lblEerdereHuurcontracten.Name = "lblEerdereHuurcontracten";
            this.lblEerdereHuurcontracten.Size = new System.Drawing.Size(125, 13);
            this.lblEerdereHuurcontracten.TabIndex = 13;
            this.lblEerdereHuurcontracten.Text = "Eerdere huurcontracten: ";
            // 
            // btnBevestig
            // 
            this.btnBevestig.Location = new System.Drawing.Point(16, 390);
            this.btnBevestig.Name = "btnBevestig";
            this.btnBevestig.Size = new System.Drawing.Size(75, 23);
            this.btnBevestig.TabIndex = 14;
            this.btnBevestig.Text = "Bevestig";
            this.btnBevestig.UseVisualStyleBackColor = true;
            // 
            // btnExporteren
            // 
            this.btnExporteren.Location = new System.Drawing.Point(273, 390);
            this.btnExporteren.Name = "btnExporteren";
            this.btnExporteren.Size = new System.Drawing.Size(75, 23);
            this.btnExporteren.TabIndex = 15;
            this.btnExporteren.Text = "Exporteren";
            this.btnExporteren.UseVisualStyleBackColor = true;
            this.btnExporteren.Click += new System.EventHandler(this.btnExporteren_Click);
            // 
            // btnVoegBootToe
            // 
            this.btnVoegBootToe.Location = new System.Drawing.Point(244, 175);
            this.btnVoegBootToe.Name = "btnVoegBootToe";
            this.btnVoegBootToe.Size = new System.Drawing.Size(104, 23);
            this.btnVoegBootToe.TabIndex = 16;
            this.btnVoegBootToe.Text = "Voeg boot toe";
            this.btnVoegBootToe.UseVisualStyleBackColor = true;
            this.btnVoegBootToe.Click += new System.EventHandler(this.btnVoegBootToe_Click);
            // 
            // btnVoegArtiekelToe
            // 
            this.btnVoegArtiekelToe.Location = new System.Drawing.Point(600, 175);
            this.btnVoegArtiekelToe.Name = "btnVoegArtiekelToe";
            this.btnVoegArtiekelToe.Size = new System.Drawing.Size(104, 23);
            this.btnVoegArtiekelToe.TabIndex = 17;
            this.btnVoegArtiekelToe.Text = "Voeg artiekel toe";
            this.btnVoegArtiekelToe.UseVisualStyleBackColor = true;
            this.btnVoegArtiekelToe.Click += new System.EventHandler(this.btnVoegArtiekelToe_Click);
            // 
            // btnVoegWaterToe
            // 
            this.btnVoegWaterToe.Location = new System.Drawing.Point(938, 175);
            this.btnVoegWaterToe.Name = "btnVoegWaterToe";
            this.btnVoegWaterToe.Size = new System.Drawing.Size(104, 23);
            this.btnVoegWaterToe.TabIndex = 18;
            this.btnVoegWaterToe.Text = "Voeg water toe";
            this.btnVoegWaterToe.UseVisualStyleBackColor = true;
            this.btnVoegWaterToe.Click += new System.EventHandler(this.btnVoegWaterToe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 425);
            this.Controls.Add(this.btnVoegWaterToe);
            this.Controls.Add(this.btnVoegArtiekelToe);
            this.Controls.Add(this.btnVoegBootToe);
            this.Controls.Add(this.btnExporteren);
            this.Controls.Add(this.btnBevestig);
            this.Controls.Add(this.lblEerdereHuurcontracten);
            this.Controls.Add(this.lbEerdereHuurcontracten);
            this.Controls.Add(this.lbHuurcontract);
            this.Controls.Add(this.lblHuurcontract);
            this.Controls.Add(this.lbWateren);
            this.Controls.Add(this.lblWateren);
            this.Controls.Add(this.lbExtraArtiekelen);
            this.Controls.Add(this.lblExtraArtiekelen);
            this.Controls.Add(this.lbBoten);
            this.Controls.Add(this.btnBudget);
            this.Controls.Add(this.tbBudget);
            this.Controls.Add(this.lblBoten);
            this.Controls.Add(this.lblBudget);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.Label lblBoten;
        private System.Windows.Forms.TextBox tbBudget;
        private System.Windows.Forms.Button btnBudget;
        private System.Windows.Forms.ListBox lbBoten;
        private System.Windows.Forms.Label lblExtraArtiekelen;
        private System.Windows.Forms.ListBox lbExtraArtiekelen;
        private System.Windows.Forms.Label lblWateren;
        private System.Windows.Forms.ListBox lbWateren;
        private System.Windows.Forms.Label lblHuurcontract;
        private System.Windows.Forms.ListBox lbHuurcontract;
        private System.Windows.Forms.ListBox lbEerdereHuurcontracten;
        private System.Windows.Forms.Label lblEerdereHuurcontracten;
        private System.Windows.Forms.Button btnBevestig;
        private System.Windows.Forms.Button btnExporteren;
        private System.Windows.Forms.Button btnVoegBootToe;
        private System.Windows.Forms.Button btnVoegArtiekelToe;
        private System.Windows.Forms.Button btnVoegWaterToe;
    }
}

