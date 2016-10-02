using Novacode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;
using System.Windows.Forms;

namespace Excuses 
{
    public partial class Main : MetroForm
    {
        /// <summary>
        /// Initialisation d'un document avec un nom choisi en dur pour l'instant TODO L'init avec une textBox
        /// </summary>
        DocX doc = Tools.initDoc("NTM");

        public Main()
        {

            InitializeComponent();
            this.Theme = MetroFramework.MetroThemeStyle.Light;
        }

        public static object Properties { get; private set; }

        private void Main_Load(object sender, EventArgs e)
        {
            Tools.addHeader(doc); // Ajout d'un header avec une image incrustée dedans TODO : Input image personnelle
                 
             // T O D O : Méthodes de génération du document à commencer. 






            /*
                    * BLOC GAUCHE TOP
                    * Prenom NOM
                    * Nom de l'établissement
                    * Addresse de l'établissement
                    * CP + Ville
                    * Numéro de Telephone personnel
                    * Email personnel
                    */

                    // Je les insère dans l'ordre inverse d'apparition sur le document
                    // Insert AFTER Self /!\ les paragraph vont s'empiler et le premier redescendra en bas.
                    Paragraph pTopLeft = doc.InsertParagraph(TxtPrenomNOm.Text);
                    pTopLeft.InsertParagraphBeforeSelf("\n");
                    pTopLeft.InsertParagraphBeforeSelf("\n");
                    pTopLeft.InsertParagraphAfterSelf(TxaEmail.Text);
                    pTopLeft.InsertParagraphAfterSelf(TxtTel.Text);
                    pTopLeft.InsertParagraphAfterSelf(TxtCpVille.Text);
                    pTopLeft.InsertParagraphAfterSelf(TxtAdresseEtablissement.Text);
                    pTopLeft.InsertParagraphAfterSelf(TxtEtablissement.Text);
                    /*
                    * BLOC DROITE
                    * A l’attention de { 0 }
                    * Nom de l'établissement
                    * Ville
                    */
                    Paragraph pTopRight= doc.InsertParagraph("\t\t\t\t\t\t" + lblAttention.Text + TxaAlAttention.Text);
                    pTopRight.InsertParagraphAfterSelf("\t\t\t\t\t\t" + TxtVille.Text);
                    pTopRight.InsertParagraphAfterSelf("\t\t\t\t\t\t"+ TxtEtablissement.Text);
                    /*
                    * BLOC MAIN
                    */
                    Paragraph pMain = doc.InsertParagraph(lblObjet.Text).Bold();
                    pMain.InsertParagraphBeforeSelf("\n");
                    pMain.InsertParagraphAfterSelf("\n");
                    pMain.InsertParagraphAfterSelf("\n");
                    pMain.InsertParagraphAfterSelf("\n");
                    pMain.InsertParagraphAfterSelf("\n");
                    pMain.InsertParagraphAfterSelf("\n");
                    pMain.InsertParagraphBeforeSelf(lblMainQuatre.Text); // 4
                    pMain.InsertParagraphBeforeSelf(lblMainTrois.Text); // 3
                    pMain.InsertParagraphBeforeSelf(lblMaindeux.Text + CbxExcuses.GetItemText(this.CbxExcuses.SelectedItem)); // 2
                    pMain.InsertParagraphBeforeSelf(CbxSexe.GetItemText(this.CbxSexe.SelectedItem) + lblMainUn.Text + DateTimeMain.ToString()) ; // 1
                    ///FIXME Remettre les paragraphes dans le bon Ordre

                    /*111
                    * BLOC BOT RIGHT : 
                    * {ville} le :  + Date
                    */
                    Paragraph pBot = doc.InsertParagraph("Toulon le : 04/04/0444");
                    pBot.Alignment = Alignment.right;

                doc.Save();
            
            }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ///FIXME Save Doc
            Main_Load(sender,e);
            doc.Save();
        }

        private void btnSaveInfos_Click(object sender, EventArgs e)
        {
            ///FIXME Save Inputs modifications en temps réel
            ///

        }

        public void updateNom(String message)
        {
            this.TxtPrenomNOm.Name = message;
        }
    }
}
