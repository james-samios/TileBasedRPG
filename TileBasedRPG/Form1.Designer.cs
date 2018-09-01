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
            this.healthBar = new System.Windows.Forms.ProgressBar();
            this.abilityBar = new System.Windows.Forms.ProgressBar();
            this.abilityLbl = new System.Windows.Forms.Label();
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
            this.healthLbl.ForeColor = System.Drawing.Color.Green;
            this.healthLbl.Location = new System.Drawing.Point(468, 409);
            this.healthLbl.Name = "healthLbl";
            this.healthLbl.Size = new System.Drawing.Size(56, 16);
            this.healthLbl.TabIndex = 1;
            this.healthLbl.Text = "Health:";
            // 
            // healthBar
            // 
            this.healthBar.Location = new System.Drawing.Point(530, 409);
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(254, 16);
            this.healthBar.TabIndex = 2;
            this.healthBar.Value = 100;
            // 
            // abilityBar
            // 
            this.abilityBar.Location = new System.Drawing.Point(530, 431);
            this.abilityBar.Name = "abilityBar";
            this.abilityBar.Size = new System.Drawing.Size(254, 16);
            this.abilityBar.TabIndex = 4;
            this.abilityBar.Value = 1;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.abilityBar);
            this.Controls.Add(this.abilityLbl);
            this.Controls.Add(this.healthBar);
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
        private System.Windows.Forms.ProgressBar healthBar;
        private System.Windows.Forms.ProgressBar abilityBar;
        private System.Windows.Forms.Label abilityLbl;
    }
}

