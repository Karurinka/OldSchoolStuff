namespace BattleSim
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblKnightName = new System.Windows.Forms.Label();
            this.lblWizardName = new System.Windows.Forms.Label();
            this.pbKnightHP = new System.Windows.Forms.ProgressBar();
            this.pbShieldPower = new System.Windows.Forms.ProgressBar();
            this.pbWizardHP = new System.Windows.Forms.ProgressBar();
            this.pbMana = new System.Windows.Forms.ProgressBar();
            this.btnKnightAttack = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 250);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(461, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 250);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // lblKnightName
            // 
            this.lblKnightName.AutoSize = true;
            this.lblKnightName.Location = new System.Drawing.Point(13, 269);
            this.lblKnightName.Name = "lblKnightName";
            this.lblKnightName.Size = new System.Drawing.Size(37, 13);
            this.lblKnightName.TabIndex = 2;
            this.lblKnightName.Text = "Knight";
            // 
            // lblWizardName
            // 
            this.lblWizardName.AutoSize = true;
            this.lblWizardName.Location = new System.Drawing.Point(461, 269);
            this.lblWizardName.Name = "lblWizardName";
            this.lblWizardName.Size = new System.Drawing.Size(40, 13);
            this.lblWizardName.TabIndex = 3;
            this.lblWizardName.Text = "Wizard";
            // 
            // pbKnightHP
            // 
            this.pbKnightHP.Location = new System.Drawing.Point(12, 285);
            this.pbKnightHP.Maximum = 250;
            this.pbKnightHP.Name = "pbKnightHP";
            this.pbKnightHP.Size = new System.Drawing.Size(200, 23);
            this.pbKnightHP.TabIndex = 4;
            // 
            // pbShieldPower
            // 
            this.pbShieldPower.Location = new System.Drawing.Point(13, 315);
            this.pbShieldPower.Name = "pbShieldPower";
            this.pbShieldPower.Size = new System.Drawing.Size(200, 23);
            this.pbShieldPower.TabIndex = 5;
            // 
            // pbWizardHP
            // 
            this.pbWizardHP.Location = new System.Drawing.Point(461, 285);
            this.pbWizardHP.Maximum = 200;
            this.pbWizardHP.Name = "pbWizardHP";
            this.pbWizardHP.Size = new System.Drawing.Size(200, 23);
            this.pbWizardHP.TabIndex = 6;
            // 
            // pbMana
            // 
            this.pbMana.Location = new System.Drawing.Point(461, 315);
            this.pbMana.Name = "pbMana";
            this.pbMana.Size = new System.Drawing.Size(200, 23);
            this.pbMana.TabIndex = 7;
            // 
            // btnKnightAttack
            // 
            this.btnKnightAttack.Location = new System.Drawing.Point(63, 344);
            this.btnKnightAttack.Name = "btnKnightAttack";
            this.btnKnightAttack.Size = new System.Drawing.Size(100, 23);
            this.btnKnightAttack.TabIndex = 8;
            this.btnKnightAttack.Text = "Attack";
            this.btnKnightAttack.UseVisualStyleBackColor = true;
            this.btnKnightAttack.Click += new System.EventHandler(this.btnKnightAttack_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(518, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Attack";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 439);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnKnightAttack);
            this.Controls.Add(this.pbMana);
            this.Controls.Add(this.pbWizardHP);
            this.Controls.Add(this.pbShieldPower);
            this.Controls.Add(this.pbKnightHP);
            this.Controls.Add(this.lblWizardName);
            this.Controls.Add(this.lblKnightName);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblKnightName;
        private System.Windows.Forms.Label lblWizardName;
        private System.Windows.Forms.ProgressBar pbKnightHP;
        private System.Windows.Forms.ProgressBar pbShieldPower;
        private System.Windows.Forms.ProgressBar pbWizardHP;
        private System.Windows.Forms.ProgressBar pbMana;
        private System.Windows.Forms.Button btnKnightAttack;
        private System.Windows.Forms.Button button1;
    }
}

