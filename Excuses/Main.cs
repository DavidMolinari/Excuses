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
        public Main()
        {
            InitializeComponent();
            this.Theme = MetroFramework.MetroThemeStyle.Light;
        }

        public static object Properties { get; private set; }

        private void Main_Load(object sender, EventArgs e)
        {
            using (DocX doc = DocX.Create(@"C:\Users\davv\Documents\DocXExample2.docx"))
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
                    Paragraph pTopLeft = doc.InsertParagraph("David MOLINARI");
                    pTopLeft.InsertParagraphBeforeSelf("\n");
                    pTopLeft.InsertParagraphBeforeSelf("\n");
                    pTopLeft.InsertParagraphAfterSelf("david@rmolinari.net");
                    pTopLeft.InsertParagraphAfterSelf("06 666 666 66");
                    pTopLeft.InsertParagraphAfterSelf("83 000 Toulon");
                    pTopLeft.InsertParagraphAfterSelf("Avenue Winston Churchill");
                    pTopLeft.InsertParagraphAfterSelf("Lycée Bonaparte");


                    /*
                    * BLOC DROITE
                    * A l’attention de { 0 }
                    * Nom de l'établissement
                    * Ville
                    */
                    Paragraph pTopRight= doc.InsertParagraph("\t\t\t\t\t\tÀ l'attention de monsieur X ");
                    pTopRight.InsertParagraphAfterSelf("\t\t\t\t\t\tToulon");
                    pTopRight.InsertParagraphAfterSelf("\t\t\t\t\t\tLycée Bonaparte");


                    /*
                    * BLOC MAIN
                    */
                    Paragraph pMain = doc.InsertParagraph("Objet : Lettre d'absence.").Bold();
                    pMain.InsertParagraphBeforeSelf("\n");

                    pMain.InsertParagraphAfterSelf("\n");
                    pMain.InsertParagraphAfterSelf("\n");

                    pMain.InsertParagraphAfterSelf("\n");

                    pMain.InsertParagraphAfterSelf("\n");

                    pMain.InsertParagraphAfterSelf("\n");

                    pMain.InsertParagraphAfterSelf("Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.");


                    /*
                    * BLOC BOT RIGHT : 
                    * {ville} le :  + Date
                    */
                    Paragraph pBot = doc.InsertParagraph("Toulon le : 04/04/0444");
                    pBot.Alignment = Alignment.right;

                }


                doc.Save();
            }
            }
    }
}
