using Novacode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excuses
{
    public abstract class Tools
    {
        public static DocX initWorld(String fileName, String filePath)
        { 
            DocX doc = DocX.Create(@"C:\Users\davv\Documents\DocXExample2.docx");




            return doc;
        }
    }
}
