using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Windows.Forms;


namespace L2MAtkCalcRemastered
{
    class Saving
    {
        #region Constructor

        private int buttons;
        private int labels;
        private string[] weaponNames;
        private decimal[] results;
        private string[] buffs;
        private string[] Blesseds;

        public Saving(int Buttons, int Labels, string[] WNames, decimal[] Results, string[] bufs, string[]bless)
        {
            buttons = Buttons;
            labels = Labels;
            weaponNames = WNames;
            results = Results;
            buffs = bufs;
            Blesseds = bless;
        }
        #endregion


        #region CSS
        public static void CopyCSS()
        {
            Thread thread = new Thread(() =>
            {
                StringBuilder CssBuilder = new StringBuilder("");
                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Style.css";

                try
                {

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
                catch(FileNotFoundException)
                {
                    MessageBox.Show("CSS configuration file is missing!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch(Exception)
                {
                    MessageBox.Show("CSS file could not be copied!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });

            thread.Start();
        }
        #endregion

        #region HTML
        public void SaveToHtml()
        {
            Thread t1 = new Thread(() =>
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\MyMAttack.html";

                using (FileStream fs = new FileStream(path, FileMode.Create))
                {
                    using (StreamWriter sw = new StreamWriter(fs, Encoding.Unicode))
                        lock (sw)
                        {
                            {
                                sw.WriteLine(@"<!DOCTYPE html>");
                                sw.WriteLine("<html>\n<head>");
                                sw.WriteLine(@"<meta charset=utf-8/>");
                                sw.WriteLine(@"<link rel =""stylesheet"" type=""text/css"" href=""Style.css"">");
                                sw.WriteLine("<title>MyMagicStats</title> \n</head> \n<body>");
                                sw.WriteLine("\t <table>");
                                sw.WriteLine("\t <tr>");
                                sw.WriteLine("\t <th> No. </th> \n \t <th> Weapon Name </th> \n \t <th> Magical Attack</th> \n \t <th> Active Buffs </th>");
                                sw.WriteLine("\t </tr>");

                                for (int i = 0; i < buttons; i++)
                                {
                                    sw.WriteLine($"\t<TR> \n \t <TD>{i + 1}. </TD>");

                                    sw.WriteLine($"\t <TD>{Blesseds[i]} {MakeItPretty()[i]}</TD>");
                                    sw.WriteLine($"\t <TD>{results[i]}</TD>");
                                    WriteStringTableToHTML(buffs, sw);
                                    sw.WriteLine("\t </TR> ");
                                }

                                sw.WriteLine("\t </table>");
                                sw.WriteLine("</body>\n</html>");
                            }
                        }
                }
            });
            Parallel.Invoke(() => t1.Start(), ()=> OpenFile());
                      //yeah, I know this is dangerous            
        }

        private void OpenFile()
        {
            Thread thread = new Thread(() =>
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\MyMAttack.html";
                System.Diagnostics.Process.Start(path);
            });
            thread.Start();
        }

        #endregion

        #region OtherClassMethods

        private string[] MakeItPretty()
        {
            {
                string[] modifiedWeaponNames = new string[weaponNames.Length];
                for (int i = 0; i < weaponNames.Length; i++)
                {
                    foreach (char c in weaponNames[i])
                    {
                        if (char.IsUpper(c))
                        {
                            int b = weaponNames[i].IndexOf(c);
                            modifiedWeaponNames[i] = weaponNames[i].Substring(0, b) + " " + weaponNames[i].Substring(b);
                        }
                    }
                }
                return modifiedWeaponNames;
            }
        }
        private void WriteStringTableToHTML(string[] table, StreamWriter sw2)
        {
            sw2.WriteLine("\t <td>");
            for (int i = 0; i < table.Length; i++)
            {
                if (i == table.Length - 1)
                {
                    sw2.Write(table[i]);
                }
                else
                {
                    sw2.Write(table[i] + ", ");
                }
            }
            sw2.WriteLine("\n \t </td>");
        }
        #endregion
    }
}
