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
        DocX doc = DocX.Create(@"C:\Users\davv\Documents\DocXExample2.docx");

        public Main()
        {

            InitializeComponent();
            this.Theme = MetroFramework.MetroThemeStyle.Light;
        }

        public static object Properties { get; private set; }

        private void Main_Load(object sender, EventArgs e)
        {


        doc.AddHeaders();

                using (MemoryStream mS = new MemoryStream())
                {

                    System.Drawing.Image myImg = Excuses.Properties.Resources.header;

                    myImg.Save(mS, myImg.RawFormat);  // Save dans le flux mémoire
                    mS.Seek(0, SeekOrigin.Begin);
                    Novacode.Image imgHeader = doc.AddImage(mS); // Create 
                    Picture picHeader = imgHeader.CreatePicture(); picHeader.Width = 600;
                    // HEADER : Incrustation d'une image dans l'entête de page
                    Header header_default = doc.Headers.odd;
                    Paragraph pHeader = header_default.InsertParagraph();
                    pHeader.InsertPicture(picHeader, 0);
                    pHeader.Alignment = Alignment.center;
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
                    Paragraph pTopLeft = doc.InsertParagraph(txtPrenomNOm.Text);
                    pTopLeft.InsertParagraphBeforeSelf("\n");
                    pTopLeft.InsertParagraphBeforeSelf("\n");
                    pTopLeft.InsertParagraphAfterSelf(txaEmail.Text);
                    pTopLeft.InsertParagraphAfterSelf(txtTel.Text);
                    pTopLeft.InsertParagraphAfterSelf(txtCpVille.Text);
                    pTopLeft.InsertParagraphAfterSelf(txtAdresseEtablissement.Text);
                    pTopLeft.InsertParagraphAfterSelf(txtEtablissement.Text);
                    /*
                    * BLOC DROITE
                    * A l’attention de { 0 }
                    * Nom de l'établissement
                    * Ville
                    */
                    Paragraph pTopRight= doc.InsertParagraph("\t\t\t\t\t\t" + lblAttention.Text + txaAlAttention.Text);
                    pTopRight.InsertParagraphAfterSelf("\t\t\t\t\t\t" + txtVille.Text);
                    pTopRight.InsertParagraphAfterSelf("\t\t\t\t\t\t"+ txtEtablissement.Text);
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
                    pMain.InsertParagraphBeforeSelf(lblMaindeux.Text + cbxExcuses.GetItemText(this.cbxExcuses.SelectedItem)); // 2
                    pMain.InsertParagraphBeforeSelf(cbxSexe.GetItemText(this.cbxSexe.SelectedItem) + lblMainUn.Text + dateTimeMain.ToString()) ; // 1
                    ///FIXME Remettre les paragraphes dans le bon Ordre


                    /*111
                    * BLOC BOT RIGHT : 
                    * {ville} le :  + Date
                    */
                    Paragraph pBot = doc.InsertParagraph("Toulon le : 04/04/0444");
                    pBot.Alignment = Alignment.right;

                


                //doc.Save();
            }
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

            this.txtPrenomNOm.Text = txtPrenomNOm.Text;
        }
    }
}
