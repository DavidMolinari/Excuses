using System.Drawing;
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
            this.components = new System.ComponentModel.Container();
            MetroFramework.Components.MetroStyleManager metroStyleManager1;
            this.lblTopGauche = new MetroFramework.Controls.MetroLabel();
            this.txtPrenomNOm = new MetroFramework.Controls.MetroTextBox();
            this.txtEtablissement = new MetroFramework.Controls.MetroTextBox();
            this.txtAdresseEtablissement = new MetroFramework.Controls.MetroTextBox();
            this.txtCpVille = new MetroFramework.Controls.MetroTextBox();
            this.txtTel = new MetroFramework.Controls.MetroTextBox();
            this.txaEmail = new MetroFramework.Controls.MetroTextBox();
            this.txaAlAttention = new MetroFramework.Controls.MetroTextBox();
            this.lblAttention = new MetroFramework.Controls.MetroLabel();
            this.txaEtablissementBis = new MetroFramework.Controls.MetroTextBox();
            this.txtVille = new MetroFramework.Controls.MetroTextBox();
            this.panelTopGauche = new MetroFramework.Controls.MetroPanel();
            this.panelTopRight = new MetroFramework.Controls.MetroPanel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lblMainCinq = new MetroFramework.Controls.MetroLabel();
            this.cbxExcuses = new MetroFramework.Controls.MetroComboBox();
            this.lblMainQuatre = new MetroFramework.Controls.MetroLabel();
            this.lblMainTrois = new MetroFramework.Controls.MetroLabel();
            this.lblMaindeux = new MetroFramework.Controls.MetroLabel();
            this.dateTimeSignature = new System.Windows.Forms.DateTimePicker();
            this.dateTimeMain = new System.Windows.Forms.DateTimePicker();
            this.lblMainUn = new MetroFramework.Controls.MetroLabel();
            this.cbxSexe = new MetroFramework.Controls.MetroComboBox();
            this.lblObjet = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.lblAddExcuses = new MetroFramework.Controls.MetroLabel();
            this.txtExcusesAdd = new MetroFramework.Controls.MetroTextBox();
            this.btnReset = new MetroFramework.Controls.MetroTile();
            this.btnAddExcuse = new MetroFramework.Controls.MetroTile();
            this.btnSaveInfos = new MetroFramework.Controls.MetroTile();
            this.btnSave = new MetroFramework.Controls.MetroTile();
            this.tileConfig = new MetroFramework.Controls.MetroTile();
            metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(metroStyleManager1)).BeginInit();
            this.panelTopGauche.SuspendLayout();
            this.panelTopRight.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            metroStyleManager1.Owner = this;
            metroStyleManager1.Style = MetroFramework.MetroColorStyle.Magenta;
            metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
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
            this.txtPrenomNOm.Location = new System.Drawing.Point(3, 3);
            this.txtPrenomNOm.Name = "txtPrenomNOm";
            this.txtPrenomNOm.Size = new System.Drawing.Size(211, 23);
            this.txtPrenomNOm.TabIndex = 1;
            this.txtPrenomNOm.Text = "David MOLINARI";
            // 
            // txtEtablissement
            // 
            this.txtEtablissement.BackColor = System.Drawing.Color.Maroon;
            this.txtEtablissement.ForeColor = System.Drawing.Color.Black;
            this.txtEtablissement.Location = new System.Drawing.Point(3, 32);
            this.txtEtablissement.Name = "txtEtablissement";
            this.txtEtablissement.Size = new System.Drawing.Size(211, 23);
            this.txtEtablissement.TabIndex = 1;
            this.txtEtablissement.Text = "Lycée Bonaparte";
            // 
            // txtAdresseEtablissement
            // 
            this.txtAdresseEtablissement.BackColor = System.Drawing.Color.Maroon;
            this.txtAdresseEtablissement.ForeColor = System.Drawing.Color.Black;
            this.txtAdresseEtablissement.Location = new System.Drawing.Point(2, 61);
            this.txtAdresseEtablissement.Name = "txtAdresseEtablissement";
            this.txtAdresseEtablissement.Size = new System.Drawing.Size(212, 23);
            this.txtAdresseEtablissement.TabIndex = 1;
            this.txtAdresseEtablissement.Text = "Avenue Winston Churchill";
            // 
            // txtCpVille
            // 
            this.txtCpVille.BackColor = System.Drawing.Color.Maroon;
            this.txtCpVille.ForeColor = System.Drawing.Color.Black;
            this.txtCpVille.Location = new System.Drawing.Point(2, 90);
            this.txtCpVille.Name = "txtCpVille";
            this.txtCpVille.Size = new System.Drawing.Size(212, 23);
            this.txtCpVille.TabIndex = 1;
            this.txtCpVille.Text = "83000 Toulon";
            // 
            // txtTel
            // 
            this.txtTel.BackColor = System.Drawing.Color.Maroon;
            this.txtTel.ForeColor = System.Drawing.Color.Black;
            this.txtTel.Location = new System.Drawing.Point(2, 119);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(212, 23);
            this.txtTel.TabIndex = 1;
            this.txtTel.Text = "0606060606";
            // 
            // txaEmail
            // 
            this.txaEmail.BackColor = System.Drawing.Color.Maroon;
            this.txaEmail.ForeColor = System.Drawing.Color.Black;
            this.txaEmail.Location = new System.Drawing.Point(2, 148);
            this.txaEmail.Name = "txaEmail";
            this.txaEmail.Size = new System.Drawing.Size(212, 23);
            this.txaEmail.TabIndex = 1;
            this.txaEmail.Text = "david@rmolinari.net";
            // 
            // txaAlAttention
            // 
            this.txaAlAttention.BackColor = System.Drawing.Color.Maroon;
            this.txaAlAttention.ForeColor = System.Drawing.Color.Black;
            this.txaAlAttention.Location = new System.Drawing.Point(165, 87);
            this.txaAlAttention.Name = "txaAlAttention";
            this.txaAlAttention.Size = new System.Drawing.Size(175, 23);
            this.txaAlAttention.TabIndex = 1;
            this.txaAlAttention.Text = "Monsieur Meh";
            // 
            // lblAttention
            // 
            this.lblAttention.AutoSize = true;
            this.lblAttention.Location = new System.Drawing.Point(3, 87);
            this.lblAttention.Name = "lblAttention";
            this.lblAttention.Size = new System.Drawing.Size(106, 20);
            this.lblAttention.TabIndex = 2;
            this.lblAttention.Text = "À l\'attention de ";
            // 
            // txaEtablissementBis
            // 
            this.txaEtablissementBis.BackColor = System.Drawing.Color.Maroon;
            this.txaEtablissementBis.ForeColor = System.Drawing.Color.Black;
            this.txaEtablissementBis.Location = new System.Drawing.Point(165, 116);
            this.txaEtablissementBis.Name = "txaEtablissementBis";
            this.txaEtablissementBis.Size = new System.Drawing.Size(175, 23);
            this.txaEtablissementBis.TabIndex = 1;
            this.txaEtablissementBis.Text = "Lycée Bonaparte";
            // 
            // txtVille
            // 
            this.txtVille.BackColor = System.Drawing.Color.Maroon;
            this.txtVille.ForeColor = System.Drawing.Color.Black;
            this.txtVille.Location = new System.Drawing.Point(165, 145);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(175, 23);
            this.txtVille.TabIndex = 1;
            this.txtVille.Text = "Toulon";
            // 
            // panelTopGauche
            // 
            this.panelTopGauche.BackColor = System.Drawing.Color.OrangeRed;
            this.panelTopGauche.Controls.Add(this.txaEmail);
            this.panelTopGauche.Controls.Add(this.txtPrenomNOm);
            this.panelTopGauche.Controls.Add(this.txtTel);
            this.panelTopGauche.Controls.Add(this.txtEtablissement);
            this.panelTopGauche.Controls.Add(this.txtAdresseEtablissement);
            this.panelTopGauche.Controls.Add(this.txtCpVille);
            this.panelTopGauche.HorizontalScrollbarBarColor = true;
            this.panelTopGauche.HorizontalScrollbarHighlightOnWheel = false;
            this.panelTopGauche.HorizontalScrollbarSize = 10;
            this.panelTopGauche.Location = new System.Drawing.Point(24, 87);
            this.panelTopGauche.Name = "panelTopGauche";
            this.panelTopGauche.Size = new System.Drawing.Size(217, 176);
            this.panelTopGauche.TabIndex = 3;
            this.panelTopGauche.VerticalScrollbarBarColor = true;
            this.panelTopGauche.VerticalScrollbarHighlightOnWheel = false;
            this.panelTopGauche.VerticalScrollbarSize = 10;
            // 
            // panelTopRight
            // 
            this.panelTopRight.Controls.Add(this.txtVille);
            this.panelTopRight.Controls.Add(this.lblAttention);
            this.panelTopRight.Controls.Add(this.txaEtablissementBis);
            this.panelTopRight.Controls.Add(this.txaAlAttention);
            this.panelTopRight.HorizontalScrollbarBarColor = true;
            this.panelTopRight.HorizontalScrollbarHighlightOnWheel = false;
            this.panelTopRight.HorizontalScrollbarSize = 10;
            this.panelTopRight.Location = new System.Drawing.Point(898, 90);
            this.panelTopRight.Name = "panelTopRight";
            this.panelTopRight.Size = new System.Drawing.Size(340, 173);
            this.panelTopRight.TabIndex = 4;
            this.panelTopRight.VerticalScrollbarBarColor = true;
            this.panelTopRight.VerticalScrollbarHighlightOnWheel = false;
            this.panelTopRight.VerticalScrollbarSize = 10;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.lblMainCinq);
            this.metroPanel1.Controls.Add(this.cbxExcuses);
            this.metroPanel1.Controls.Add(this.lblMainQuatre);
            this.metroPanel1.Controls.Add(this.lblMainTrois);
            this.metroPanel1.Controls.Add(this.lblMaindeux);
            this.metroPanel1.Controls.Add(this.dateTimeSignature);
            this.metroPanel1.Controls.Add(this.dateTimeMain);
            this.metroPanel1.Controls.Add(this.lblMainUn);
            this.metroPanel1.Controls.Add(this.cbxSexe);
            this.metroPanel1.Controls.Add(this.lblObjet);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(24, 286);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1214, 262);
            this.metroPanel1.TabIndex = 5;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // lblMainCinq
            // 
            this.lblMainCinq.AutoSize = true;
            this.lblMainCinq.Location = new System.Drawing.Point(874, 224);
            this.lblMainCinq.Name = "lblMainCinq";
            this.lblMainCinq.Size = new System.Drawing.Size(69, 20);
            this.lblMainCinq.TabIndex = 8;
            this.lblMainCinq.Text = "Toulon le ";
            // 
            // cbxExcuses
            // 
            this.cbxExcuses.FormattingEnabled = true;
            this.cbxExcuses.ItemHeight = 24;
            this.cbxExcuses.Items.AddRange(new object[] {
            "mon chien a volé mon cahier",
            "je n\'ai pas assez dormi"});
            this.cbxExcuses.Location = new System.Drawing.Point(457, 64);
            this.cbxExcuses.Name = "cbxExcuses";
            this.cbxExcuses.Size = new System.Drawing.Size(735, 30);
            this.cbxExcuses.TabIndex = 7;
            // 
            // lblMainQuatre
            // 
            this.lblMainQuatre.AutoSize = true;
            this.lblMainQuatre.Location = new System.Drawing.Point(2, 134);
            this.lblMainQuatre.Name = "lblMainQuatre";
            this.lblMainQuatre.Size = new System.Drawing.Size(793, 20);
            this.lblMainQuatre.TabIndex = 6;
            this.lblMainQuatre.Text = "En espérant que vous considéreriez mes excuses avec bienveillance, je vous prie d" +
    "\'agréer mes salutations les plus distinguées.";
            // 
            // lblMainTrois
            // 
            this.lblMainTrois.AutoSize = true;
            this.lblMainTrois.Location = new System.Drawing.Point(4, 100);
            this.lblMainTrois.Name = "lblMainTrois";
            this.lblMainTrois.Size = new System.Drawing.Size(762, 20);
            this.lblMainTrois.TabIndex = 6;
            this.lblMainTrois.Text = "J\'ai conscience que cette absence exceptionnelle a été source de bien des désagré" +
    "ments et j\'en suis sincèrement désolé.";
            // 
            // lblMaindeux
            // 
            this.lblMaindeux.AutoSize = true;
            this.lblMaindeux.Location = new System.Drawing.Point(4, 64);
            this.lblMaindeux.Name = "lblMaindeux";
            this.lblMaindeux.Size = new System.Drawing.Size(346, 20);
            this.lblMaindeux.TabIndex = 6;
            this.lblMaindeux.Text = "En effet, ce jour-là je n\'ai pu être présent en cours car ";
            // 
            // dateTimeSignature
            // 
            this.dateTimeSignature.Location = new System.Drawing.Point(966, 224);
            this.dateTimeSignature.Name = "dateTimeSignature";
            this.dateTimeSignature.Size = new System.Drawing.Size(226, 22);
            this.dateTimeSignature.TabIndex = 5;
            // 
            // dateTimeMain
            // 
            this.dateTimeMain.Location = new System.Drawing.Point(848, 27);
            this.dateTimeMain.Name = "dateTimeMain";
            this.dateTimeMain.Size = new System.Drawing.Size(226, 22);
            this.dateTimeMain.TabIndex = 5;
            // 
            // lblMainUn
            // 
            this.lblMainUn.AutoSize = true;
            this.lblMainUn.Location = new System.Drawing.Point(131, 27);
            this.lblMainUn.Name = "lblMainUn";
            this.lblMainUn.Size = new System.Drawing.Size(586, 20);
            this.lblMainUn.TabIndex = 4;
            this.lblMainUn.Text = " par la présente, je souhaite vous présenter toutes mes excuses au sujet de mon a" +
    "bsence du ";
            // 
            // cbxSexe
            // 
            this.cbxSexe.FormattingEnabled = true;
            this.cbxSexe.ItemHeight = 24;
            this.cbxSexe.Items.AddRange(new object[] {
            "Madame,",
            "Monsieur,"});
            this.cbxSexe.Location = new System.Drawing.Point(4, 27);
            this.cbxSexe.Name = "cbxSexe";
            this.cbxSexe.Size = new System.Drawing.Size(121, 30);
            this.cbxSexe.TabIndex = 3;
            // 
            // lblObjet
            // 
            this.lblObjet.AutoSize = true;
            this.lblObjet.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblObjet.Location = new System.Drawing.Point(4, 4);
            this.lblObjet.Name = "lblObjet";
            this.lblObjet.Size = new System.Drawing.Size(170, 20);
            this.lblObjet.TabIndex = 2;
            this.lblObjet.Text = "Objet : lettre d\'absence";
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.lblAddExcuses);
            this.metroPanel2.Controls.Add(this.txtExcusesAdd);
            this.metroPanel2.Controls.Add(this.btnReset);
            this.metroPanel2.Controls.Add(this.btnAddExcuse);
            this.metroPanel2.Controls.Add(this.btnSaveInfos);
            this.metroPanel2.Controls.Add(this.btnSave);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(24, 589);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(1214, 108);
            this.metroPanel2.TabIndex = 6;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // lblAddExcuses
            // 
            this.lblAddExcuses.AutoSize = true;
            this.lblAddExcuses.Location = new System.Drawing.Point(0, 40);
            this.lblAddExcuses.Name = "lblAddExcuses";
            this.lblAddExcuses.Size = new System.Drawing.Size(140, 20);
            this.lblAddExcuses.TabIndex = 10;
            this.lblAddExcuses.Text = "Ajouter des excuses :";
            // 
            // txtExcusesAdd
            // 
            this.txtExcusesAdd.Location = new System.Drawing.Point(2, 66);
            this.txtExcusesAdd.Name = "txtExcusesAdd";
            this.txtExcusesAdd.Size = new System.Drawing.Size(249, 23);
            this.txtExcusesAdd.TabIndex = 9;
            this.txtExcusesAdd.Text = "J\'ai raté mon train :>";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(554, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(187, 23);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            // 
            // btnAddExcuse
            // 
            this.btnAddExcuse.Location = new System.Drawing.Point(284, 66);
            this.btnAddExcuse.Name = "btnAddExcuse";
            this.btnAddExcuse.Size = new System.Drawing.Size(187, 23);
            this.btnAddExcuse.TabIndex = 8;
            this.btnAddExcuse.Text = "Ajouter";
            // 
            // btnSaveInfos
            // 
            this.btnSaveInfos.Location = new System.Drawing.Point(262, 3);
            this.btnSaveInfos.Name = "btnSaveInfos";
            this.btnSaveInfos.Size = new System.Drawing.Size(255, 23);
            this.btnSaveInfos.TabIndex = 7;
            this.btnSaveInfos.Text = "Sauvegarder les informations";
            this.btnSaveInfos.Click += new System.EventHandler(this.btnSaveInfos_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(223, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Sauvegarder le document";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tileConfig
            // 
            this.tileConfig.Location = new System.Drawing.Point(28, 560);
            this.tileConfig.Name = "tileConfig";
            this.tileConfig.Size = new System.Drawing.Size(171, 23);
            this.tileConfig.TabIndex = 7;
            this.tileConfig.Text = "Configuration ";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 740);
            this.Controls.Add(this.tileConfig);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.panelTopRight);
            this.Controls.Add(this.panelTopGauche);
            this.Controls.Add(this.lblTopGauche);
            this.Name = "Main";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(metroStyleManager1)).EndInit();
            this.panelTopGauche.ResumeLayout(false);
            this.panelTopRight.ResumeLayout(false);
            this.panelTopRight.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblTopGauche;
        private MetroFramework.Controls.MetroTextBox txtPrenomNOm;
        private MetroFramework.Controls.MetroTextBox txtEtablissement;
        private MetroFramework.Controls.MetroTextBox txtAdresseEtablissement;
        private MetroFramework.Controls.MetroTextBox txtCpVille;
        private MetroFramework.Controls.MetroTextBox txtTel;
        private MetroFramework.Controls.MetroTextBox txaEmail;
        private MetroFramework.Controls.MetroTextBox txaAlAttention;
        private MetroFramework.Controls.MetroLabel lblAttention;
        private MetroFramework.Controls.MetroTextBox txaEtablissementBis;
        private MetroFramework.Controls.MetroTextBox txtVille;
        private MetroFramework.Controls.MetroPanel panelTopGauche;
        private MetroFramework.Controls.MetroPanel panelTopRight;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel lblObjet;
        private MetroFramework.Controls.MetroComboBox cbxSexe;
        private MetroFramework.Controls.MetroLabel lblMainUn;
        private System.Windows.Forms.DateTimePicker dateTimeMain;
        private MetroFramework.Controls.MetroLabel lblMaindeux;
        private MetroFramework.Controls.MetroLabel lblMainQuatre;
        private MetroFramework.Controls.MetroLabel lblMainTrois;
        private MetroFramework.Controls.MetroComboBox cbxExcuses;
        private MetroFramework.Controls.MetroLabel lblMainCinq;
        private System.Windows.Forms.DateTimePicker dateTimeSignature;
        private MetroFramework.Controls.MetroTile tileConfig;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroTile btnSave;
        private MetroFramework.Controls.MetroTile btnSaveInfos;
        private MetroFramework.Controls.MetroTile btnAddExcuse;
        private MetroFramework.Controls.MetroLabel lblAddExcuses;
        private MetroFramework.Controls.MetroTextBox txtExcusesAdd;
        private MetroFramework.Controls.MetroTile btnReset;
    }
}