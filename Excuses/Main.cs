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
using System.Windows.Forms;

namespace Excuses
{
    public partial class Main : Form
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

                using (MemoryStream ms = new MemoryStream())
                {

                    System.Drawing.Image myImg = Excuses.Properties.Resources.header;

                    myImg.Save(ms, myImg.RawFormat);  // Save dans le flux mémoire
                    ms.Seek(0, SeekOrigin.Begin);
                    Novacode.Image img = doc.AddImage(ms); // Create 
                    Picture pic1 = img.CreatePicture(); pic1.Width = 600;
                    // HEADER : Incrustation d'une image dans l'entête de page
                    Header header_default = doc.Headers.odd;
                    Paragraph p1 = header_default.InsertParagraph();
                    p1.InsertPicture(pic1, 0);
                    p1.Alignment = Alignment.center;


                }


                doc.Save();
            }
            }
    }
}
