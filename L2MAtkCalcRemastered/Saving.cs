using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace L2MAtkCalcRemastered
{
    class Saving
    {
        #region Constructor

        private int buttons;
        private int labels;
        private string[] weaponNames;
        private decimal[] results;

        public Saving(int Buttons, int Labels, string[] WNames, decimal[] Results)
        {
            buttons = Buttons;
            labels = Labels;
            weaponNames = WNames;
            results = Results;
        }
        #endregion


        #region CSS
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
        #endregion

        #region HTML
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
                    sw.WriteLine("\t <table>");
                    sw.WriteLine("\t <tr>");                            
                    sw.WriteLine("\t <th> No. </th> \n \t <th> Weapon Name </th> \n \t <th> Magical Attack</th>");
                    sw.WriteLine("\t </tr>");

                    for (int i = 0; i < buttons; i++)
                    {
                        sw.WriteLine($"\t<TR> \n \t <TD>{i + 1}. </TD>");

                        sw.WriteLine($"\t <TD>{MakeItPretty()[i]}</TD>");
                        sw.WriteLine($"\t <TD>{results[i]}</TD>");

                        sw.WriteLine("\t </TR> ");
                    }

                    sw.WriteLine("\t </table>");
                    sw.WriteLine("</body>\n</html>");
                }
            }
        }
        #endregion

        #region OtherClassMethods

        private string[] MakeItPretty()
        {
            string[] modifiedWeaponNames = new string[weaponNames.Length];
            for (int i = 0; i < weaponNames.Length; i++)
            {
                foreach (char c in weaponNames[i])
                {
                    if(char.IsUpper(c))
                    {
                        int b = weaponNames[i].IndexOf(c);
                        modifiedWeaponNames[i] = weaponNames[i].Substring(0, b) + " " + weaponNames[i].Substring(b);
                    }
                }
            }
            return modifiedWeaponNames;
        }
        #endregion
    }
}
