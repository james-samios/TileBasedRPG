namespace TileBasedRPG
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
            this.label1 = new System.Windows.Forms.Label();
            this.healthLbl = new System.Windows.Forms.Label();
            this.armourBar = new System.Windows.Forms.ProgressBar();
            this.abilityBar = new System.Windows.Forms.ProgressBar();
            this.abilityLbl = new System.Windows.Forms.Label();
            this.weaponLabel = new System.Windows.Forms.Label();
            this.healthBar = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.strengthBar = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.defenceBar = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.armourLabel = new System.Windows.Forms.Label();
            this.shieldLabel = new System.Windows.Forms.Label();
            this.speedBar = new System.Windows.Forms.ProgressBar();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(466, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "INVENTORY";
            // 
            // healthLbl
            // 
            this.healthLbl.AutoSize = true;
            this.healthLbl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthLbl.ForeColor = System.Drawing.Color.Blue;
            this.healthLbl.Location = new System.Drawing.Point(468, 384);
            this.healthLbl.Name = "healthLbl";
            this.healthLbl.Size = new System.Drawing.Size(60, 16);
            this.healthLbl.TabIndex = 1;
            this.healthLbl.Text = "Armour:";
            this.healthLbl.Click += new System.EventHandler(this.healthLbl_Click);
            // 
            // armourBar
            // 
            this.armourBar.Location = new System.Drawing.Point(530, 384);
            this.armourBar.Name = "armourBar";
            this.armourBar.Size = new System.Drawing.Size(254, 16);
            this.armourBar.TabIndex = 2;
            this.armourBar.Click += new System.EventHandler(this.healthBar_Click);
            // 
            // abilityBar
            // 
            this.abilityBar.Location = new System.Drawing.Point(530, 431);
            this.abilityBar.Name = "abilityBar";
            this.abilityBar.Size = new System.Drawing.Size(254, 16);
            this.abilityBar.TabIndex = 4;
            this.abilityBar.Click += new System.EventHandler(this.abilityBar_Click);
            // 
            // abilityLbl
            // 
            this.abilityLbl.AutoSize = true;
            this.abilityLbl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abilityLbl.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.abilityLbl.Location = new System.Drawing.Point(468, 431);
            this.abilityLbl.Name = "abilityLbl";
            this.abilityLbl.Size = new System.Drawing.Size(54, 16);
            this.abilityLbl.TabIndex = 3;
            this.abilityLbl.Text = "Ability:";
            // 
            // weaponLabel
            // 
            this.weaponLabel.AutoSize = true;
            this.weaponLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weaponLabel.Location = new System.Drawing.Point(468, 51);
            this.weaponLabel.Name = "weaponLabel";
            this.weaponLabel.Size = new System.Drawing.Size(212, 18);
            this.weaponLabel.TabIndex = 5;
            this.weaponLabel.Text = "Weapon: NOT EQUIPPED";
            // 
            // healthBar
            // 
            this.healthBar.Location = new System.Drawing.Point(530, 406);
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(254, 16);
            this.healthBar.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(468, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Health:";
            // 
            // strengthBar
            // 
            this.strengthBar.Location = new System.Drawing.Point(530, 362);
            this.strengthBar.Name = "strengthBar";
            this.strengthBar.Size = new System.Drawing.Size(254, 16);
            this.strengthBar.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(468, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Strength:";
            // 
            // defenceBar
            // 
            this.defenceBar.Location = new System.Drawing.Point(530, 340);
            this.defenceBar.Name = "defenceBar";
            this.defenceBar.Size = new System.Drawing.Size(254, 16);
            this.defenceBar.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Goldenrod;
            this.label5.Location = new System.Drawing.Point(468, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Defence:";
            // 
            // armourLabel
            // 
            this.armourLabel.AutoSize = true;
            this.armourLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.armourLabel.Location = new System.Drawing.Point(468, 79);
            this.armourLabel.Name = "armourLabel";
            this.armourLabel.Size = new System.Drawing.Size(210, 18);
            this.armourLabel.TabIndex = 12;
            this.armourLabel.Text = "Armour:  NOT EQUIPPED";
            // 
            // shieldLabel
            // 
            this.shieldLabel.AutoSize = true;
            this.shieldLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shieldLabel.Location = new System.Drawing.Point(468, 106);
            this.shieldLabel.Name = "shieldLabel";
            this.shieldLabel.Size = new System.Drawing.Size(208, 18);
            this.shieldLabel.TabIndex = 13;
            this.shieldLabel.Text = "Shield:   NOT EQUIPPED";
            // 
            // speedBar
            // 
            this.speedBar.Location = new System.Drawing.Point(530, 318);
            this.speedBar.Name = "speedBar";
            this.speedBar.Size = new System.Drawing.Size(254, 16);
            this.speedBar.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label8.Location = new System.Drawing.Point(468, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Speed:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.speedBar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.shieldLabel);
            this.Controls.Add(this.armourLabel);
            this.Controls.Add(this.defenceBar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.strengthBar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.healthBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.weaponLabel);
            this.Controls.Add(this.abilityBar);
            this.Controls.Add(this.abilityLbl);
            this.Controls.Add(this.armourBar);
            this.Controls.Add(this.healthLbl);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Tile Based RPG";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label healthLbl;
        private System.Windows.Forms.ProgressBar armourBar;
        private System.Windows.Forms.ProgressBar abilityBar;
        private System.Windows.Forms.Label abilityLbl;
        private System.Windows.Forms.Label weaponLabel;
        private System.Windows.Forms.ProgressBar healthBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar strengthBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar defenceBar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label armourLabel;
        private System.Windows.Forms.Label shieldLabel;
        private System.Windows.Forms.ProgressBar speedBar;
        private System.Windows.Forms.Label label8;
    }
}

