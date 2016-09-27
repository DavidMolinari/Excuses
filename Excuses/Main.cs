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

namespace Excuses 
{
    public partial class Main : MetroForm
    {
        public Main()
        {
            InitializeComponent();
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
                    pTopLeft.InsertParagraphAfterSelf("david@rmolinari.net");
                    pTopLeft.InsertParagraphAfterSelf("06 666 666 66");
                    pTopLeft.InsertParagraphAfterSelf("83 000 Toulon");
                    pTopLeft.InsertParagraphAfterSelf("Avenue Winston Churchill");
                    pTopLeft.InsertParagraphAfterSelf("Lycée Bonaparte");




                    //doc.InsertParagraph(pTopLeft);


                    /*
                    * BLOC DROITE
                    * A l’attention de { 0 }
                    * Nom de l'établissement
                    * Ville
                    */


                    /*
                    * BLOC MAIN
                    */


                    /*
                    * BLOC BOT RIGHT : 
                    * {ville} le :  + Date
                    */

                }


                doc.Save();
            }
            }
    }
}
