namespace _2016_NJ_SE2_BP3_OO_Programma
{
    partial class SpelForm
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
            this.lstKaartenSpeler = new System.Windows.Forms.ListBox();
            this.btnDoorgeven = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstStand = new System.Windows.Forms.ListBox();
            this.btnNieuweRonde = new System.Windows.Forms.Button();
            this.btnStandOpslaan = new System.Windows.Forms.Button();
            this.btnStandLaden = new System.Windows.Forms.Button();
            this.btnResetSpel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstKaartenSpeler
            // 
            this.lstKaartenSpeler.FormattingEnabled = true;
            this.lstKaartenSpeler.Location = new System.Drawing.Point(144, 25);
            this.lstKaartenSpeler.Name = "lstKaartenSpeler";
            this.lstKaartenSpeler.Size = new System.Drawing.Size(120, 56);
            this.lstKaartenSpeler.TabIndex = 0;
            // 
            // btnDoorgeven
            // 
            this.btnDoorgeven.Location = new System.Drawing.Point(144, 87);
            this.btnDoorgeven.Name = "btnDoorgeven";
            this.btnDoorgeven.Size = new System.Drawing.Size(120, 23);
            this.btnDoorgeven.TabIndex = 1;
            this.btnDoorgeven.Text = "Doorgeven";
            this.btnDoorgeven.UseVisualStyleBackColor = true;
            this.btnDoorgeven.Click += new System.EventHandler(this.btnDoorgeven_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kaarten in hand";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Stand";
            // 
            // lstStand
            // 
            this.lstStand.Enabled = false;
            this.lstStand.FormattingEnabled = true;
            this.lstStand.Location = new System.Drawing.Point(15, 25);
            this.lstStand.Name = "lstStand";
            this.lstStand.Size = new System.Drawing.Size(120, 56);
            this.lstStand.TabIndex = 3;
            // 
            // btnNieuweRonde
            // 
            this.btnNieuweRonde.Location = new System.Drawing.Point(144, 116);
            this.btnNieuweRonde.Name = "btnNieuweRonde";
            this.btnNieuweRonde.Size = new System.Drawing.Size(120, 23);
            this.btnNieuweRonde.TabIndex = 5;
            this.btnNieuweRonde.Text = "Nieuwe ronde";
            this.btnNieuweRonde.UseVisualStyleBackColor = true;
            this.btnNieuweRonde.Click += new System.EventHandler(this.btnNieuweRonde_Click);
            // 
            // btnStandOpslaan
            // 
            this.btnStandOpslaan.Location = new System.Drawing.Point(15, 87);
            this.btnStandOpslaan.Name = "btnStandOpslaan";
            this.btnStandOpslaan.Size = new System.Drawing.Size(120, 23);
            this.btnStandOpslaan.TabIndex = 6;
            this.btnStandOpslaan.Text = "Stand opslaan";
            this.btnStandOpslaan.UseVisualStyleBackColor = true;
            // 
            // btnStandLaden
            // 
            this.btnStandLaden.Location = new System.Drawing.Point(15, 116);
            this.btnStandLaden.Name = "btnStandLaden";
            this.btnStandLaden.Size = new System.Drawing.Size(120, 23);
            this.btnStandLaden.TabIndex = 7;
            this.btnStandLaden.Text = "Stand laden";
            this.btnStandLaden.UseVisualStyleBackColor = true;
            // 
            // btnResetSpel
            // 
            this.btnResetSpel.Location = new System.Drawing.Point(144, 145);
            this.btnResetSpel.Name = "btnResetSpel";
            this.btnResetSpel.Size = new System.Drawing.Size(120, 23);
            this.btnResetSpel.TabIndex = 8;
            this.btnResetSpel.Text = "Reset spel";
            this.btnResetSpel.UseVisualStyleBackColor = true;
            // 
            // SpelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 180);
            this.Controls.Add(this.btnResetSpel);
            this.Controls.Add(this.btnStandLaden);
            this.Controls.Add(this.btnStandOpslaan);
            this.Controls.Add(this.btnNieuweRonde);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstStand);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDoorgeven);
            this.Controls.Add(this.lstKaartenSpeler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SpelForm";
            this.Text = "Ezelen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstKaartenSpeler;
        private System.Windows.Forms.Button btnDoorgeven;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstStand;
        private System.Windows.Forms.Button btnNieuweRonde;
        private System.Windows.Forms.Button btnStandOpslaan;
        private System.Windows.Forms.Button btnStandLaden;
        private System.Windows.Forms.Button btnResetSpel;
    }
}

