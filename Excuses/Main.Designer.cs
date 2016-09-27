namespace Excuses
{
    partial class Main
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
            this.lblTopGauche = new MetroFramework.Controls.MetroLabel();
            this.txtPrenomNOm = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // lblTopGauche
            // 
            this.lblTopGauche.AutoSize = true;
            this.lblTopGauche.Location = new System.Drawing.Point(24, 64);
            this.lblTopGauche.Name = "lblTopGauche";
            this.lblTopGauche.Size = new System.Drawing.Size(175, 20);
            this.lblTopGauche.TabIndex = 0;
            this.lblTopGauche.Text = "Informations personnelles :";
            // 
            // txtPrenomNOm
            // 
            this.txtPrenomNOm.BackColor = System.Drawing.Color.Maroon;
            this.txtPrenomNOm.ForeColor = System.Drawing.Color.Black;
            this.txtPrenomNOm.Location = new System.Drawing.Point(24, 88);
            this.txtPrenomNOm.Name = "txtPrenomNOm";
            this.txtPrenomNOm.Size = new System.Drawing.Size(175, 23);
            this.txtPrenomNOm.TabIndex = 1;
            this.txtPrenomNOm.Text = "David MOLINARI";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 740);
            this.Controls.Add(this.txtPrenomNOm);
            this.Controls.Add(this.lblTopGauche);
            this.Name = "Main";
            this.Text = "Excuses Generation";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblTopGauche;
        private MetroFramework.Controls.MetroTextBox txtPrenomNOm;
    }
}