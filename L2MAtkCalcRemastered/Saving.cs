using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace L2MAtkCalcRemastered
{
    class Saving
    {
        private int buttons;
        private int labels;
        private string[] weaponNames;

        public Saving(int Buttons, int Labels, string[] WNames)
        {
            buttons = Buttons;
            labels = Labels;
            weaponNames = WNames;
        }


        public static void CopyCSS()
        {
            StringBuilder CssBuilder = new StringBuilder("");
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Style.css";

            using (FileStream fs = new FileStream(@"ConfigurationFiles\Style.css", FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(fs, Encoding.Unicode))
                {
                    CssBuilder.Append(sr.ReadToEnd());
                }
            }

            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fs, Encoding.Unicode))
                {
                    sw.WriteLine(CssBuilder);
                }
            }
        }

        public void SaveToHtml()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\MyMAttack.html";

            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fs, Encoding.Unicode))
                {
                    sw.WriteLine(@"<!DOCTYPE html>");
                    sw.WriteLine("<html>\n<head>");
                    sw.WriteLine(@"<meta charset=utf-8/>");
                    sw.WriteLine(@"<link rel =""stylesheet"" type=""text/css"" href=""Style.css"">");
                    sw.WriteLine("<title>MyMagicStats</title> \n</head> \n<body>");
                    sw.WriteLine("\t<table>");
                    sw.WriteLine("\t<tr>");                            //this is for headline later

                    for (int i = 0; i < buttons; i++)
                    {
                        sw.WriteLine($"\t<TR> \n \t <TH>{i + 1}. </TH>");
                        

                        for (int j = 0; j < labels; j++)
                        {
                            
                        }
                        sw.WriteLine($"\t<TD>{weaponNames[i]}</TD>");
                        //sw.WriteLine($"\t<TD>");
                        sw.WriteLine("\t</TR> ");
                    }
                }
            }
        }
    }
}
