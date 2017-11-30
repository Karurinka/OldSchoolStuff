namespace SpaceMan
{
    partial class SpaceManForm
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
            this.gbSpaceMan = new System.Windows.Forms.GroupBox();
            this.lblNaam = new System.Windows.Forms.Label();
            this.lbPlaneten = new System.Windows.Forms.ListBox();
            this.btHaalPlaneten = new System.Windows.Forms.Button();
            this.gbSpaceMan.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSpaceMan
            // 
            this.gbSpaceMan.BackColor = System.Drawing.Color.LightSteelBlue;
            this.gbSpaceMan.Controls.Add(this.btHaalPlaneten);
            this.gbSpaceMan.Controls.Add(this.lbPlaneten);
            this.gbSpaceMan.Controls.Add(this.lblNaam);
            this.gbSpaceMan.Location = new System.Drawing.Point(23, 21);
            this.gbSpaceMan.Name = "gbSpaceMan";
            this.gbSpaceMan.Size = new System.Drawing.Size(387, 456);
            this.gbSpaceMan.TabIndex = 0;
            this.gbSpaceMan.TabStop = false;
            this.gbSpaceMan.Text = "SpaceMan";
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaam.Location = new System.Drawing.Point(16, 33);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(31, 29);
            this.lblNaam.TabIndex = 0;
            this.lblNaam.Text = "...";
            // 
            // lbPlaneten
            // 
            this.lbPlaneten.FormattingEnabled = true;
            this.lbPlaneten.Location = new System.Drawing.Point(21, 105);
            this.lbPlaneten.Name = "lbPlaneten";
            this.lbPlaneten.Size = new System.Drawing.Size(341, 329);
            this.lbPlaneten.TabIndex = 1;
            // 
            // btHaalPlaneten
            // 
            this.btHaalPlaneten.Location = new System.Drawing.Point(21, 76);
            this.btHaalPlaneten.Name = "btHaalPlaneten";
            this.btHaalPlaneten.Size = new System.Drawing.Size(341, 23);
            this.btHaalPlaneten.TabIndex = 2;
            this.btHaalPlaneten.Text = "Bezochte bewoonde planeten";
            this.btHaalPlaneten.UseVisualStyleBackColor = true;
            this.btHaalPlaneten.Click += new System.EventHandler(this.btHaalPlaneten_Click);
            // 
            // SpaceManForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpaceMan.Properties.Resources.deepSpace;
            this.ClientSize = new System.Drawing.Size(737, 503);
            this.Controls.Add(this.gbSpaceMan);
            this.Name = "SpaceManForm";
            this.Text = "Where did SpaceMan Go?";
            this.gbSpaceMan.ResumeLayout(false);
            this.gbSpaceMan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSpaceMan;
        private System.Windows.Forms.Button btHaalPlaneten;
        private System.Windows.Forms.ListBox lbPlaneten;
        private System.Windows.Forms.Label lblNaam;
    }
}

