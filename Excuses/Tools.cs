using Novacode;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Excuses
{
    public abstract class Tools
    {
        /// <summary>
        /// Crée un fichier Word avec un nom et un Chemin à Définir 
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static DocX initDoc(String fileName, String filePath)
        {
            String documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            String PATH = filePath + fileName + ".docx";
            DocX doc = DocX.Create(@PATH + ".doc");




            return doc;
        }

        /// <summary>
        /// Crée un fichier Word dans mes Documents avec le nom choisi
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static DocX initDoc(String fileName)
        {
            String documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            String DefaultPath = documentsPath + "\\" + fileName + ".docx";
            DocX doc = DocX.Create(DefaultPath);
            return doc;
        }

        public static DocX initDoc2(String fileName)
        {
            return DocX.Create(@"C:\Users\davv\Documents\" + fileName + ".docx");
        }

        public static void addHeader(DocX doc)
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
            }
        }

        public static void generationCore(DocX doc)
        {
        }
    }
}
