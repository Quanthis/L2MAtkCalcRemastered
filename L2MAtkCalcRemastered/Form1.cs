using System;
using System.Windows.Forms;
using System.Threading;
using static System.Convert;
using System.Threading.Tasks;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Linq;

namespace L2MAtkCalcRemastered
{
    public partial class Form1 : Form, IDisposable                               //remember to add database binding possibility soon, best in another branch (windows 7 compability problems)
    {
        #region Initialization

        public Form1()
        {
            InitializeComponent();
        }

        #endregion
                
        #region Blessed
        private bool IsBlessed(CheckBox isChecked, string wName)
        {
            if (isChecked.Name.Contains(wName))
            {
                if (isChecked.Checked)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else return false;            
        }

        #endregion

        #region MakeButtonsWork

        private void Sender(decimal weaponAttack, Label whereToSend, string weapName, CheckBox Blessed)
        {
            string OwnAtak = OwnMAttack.Text;
            var wp = new Weapon(weaponAttack, weapName, OwnAtak, HaveSigil(), IsBlessed(Blessed, weapName), GetActiveBuffs());
            whereToSend.Text = wp.ConvertToSendableForm();
            wp.Dispose();
        }

        private void Sender(string weaponAttack, Label whereToSend, string weapName)
        {
            string OwnAtak = OwnMAttack.Text;
            var wp = new Weapon(weaponAttack, OwnAtak, GetActiveBuffs());
            whereToSend.Text = wp.ConvertToSendableForm();
            wp.Dispose();
        }

        private void RefreshCalculations()
        {
            ApoCaster.PerformClick();
            ApoRettributer.PerformClick();
            SpCaster.PerformClick();
            SpRettriButer.PerformClick();
            AmaCaster.PerformClick();
            AmaRettributer.PerformClick();
            MCaster.PerformClick();

            #region NiceTry

            //statements below throw some unpleasant exceptions

            //Parallel.Invoke(() => ApoCaster.PerformClick(), ()=> ApoRettributer.PerformClick(), ()=> SpCaster.PerformClick(), ()=> SpRettriButer.PerformClick());*/

            /*Parallel.Invoke(() => t1.Start(), () => t2.Start(), () => t3.Start(), () => t4.Start());
            Parallel.Invoke(() => t1.Join(), () => t2.Join(), () => t3.Join(), () => t4.Join());*/

            /*t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();
            t1.Join();
            t2.Join();
            t3.Join();
            t4.Join();*/
            #endregion
        }



        #endregion


        #region Sigils

        private void HavingSigil_CheckedChanged(object sender, EventArgs e)
        {
            RunBackgroundWorker();
            RefreshCalculations();
        }

        private void NotHavingSigil_CheckedChanged(object sender, EventArgs e)
        {
            RunBackgroundWorker();
            RefreshCalculations();
        }

        private bool HaveSigil()
        {
            if (HavingSigil.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Initializev2

        private void Form1_Load(object sender, EventArgs e)
        {
            Saving.CopyCSS();

            try
            {
                using (FileStream fs = new FileStream(@"ConfigurationFiles\OwnMAttack.txt", FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs, Encoding.Unicode))
                    {
                        string s = "";
                        s = sr.ReadToEnd();
                        OwnMAttack.Text = s;
                    }
                }
            }
            catch
            {
                using (FileStream fs = new FileStream(@"ConfigurationFiles\OwnMAttack.txt", FileMode.Create))
                {
                    using (StreamWriter sw = new StreamWriter(fs, Encoding.Unicode))
                    {
                        string toSave = OwnMAttack.Text = Microsoft.VisualBasic.Interaction.InputBox("What's your magic attack?", "Need informations from user to proceed...");
                        sw.WriteLine(toSave);

                        while (OwnMAttack.Text.Length == 0)
                        {                            
                            sw.WriteLine(OwnMAttack.Text = Microsoft.VisualBasic.Interaction.InputBox("What's your magic attack?", "This field cannot be empty!"));
                        }
                    }
                }
                RefreshCalculations();
            }
        }

        #endregion

        #region Weapons

        #region ApoCaster

        private void ApoCaster_Click(object sender, EventArgs e)
        {
            decimal weaponAttack = 293M;
            Sender(weaponAttack, ApocalypseCasterResult, ApocalypseCaster.Name, IsApocalypseCasterBlessed);
        }

        private void IsApoCasterBlessed_CheckedChanged(object sender, EventArgs e)
        {
            decimal weaponAttack = 293M;
            Sender(weaponAttack, ApocalypseCasterResult, ApocalypseCaster.Name, IsApocalypseCasterBlessed);
        }
        #endregion

        #region ApoRetri

        private void ApoRettributer_Click(object sender, EventArgs e)
        {
            decimal weaponAttack = 322M;
            Sender(weaponAttack, ApocalypseRettributerResult, ApocalypseRettributer.Name, IsApocalypseRettributerBlessed);
        }

               
        private void IsApocalypseRettributerBlessed_CheckedChanged(object sender, EventArgs e)
        {
            decimal weaponAttack = 322M;
            Sender(weaponAttack, ApocalypseRettributerResult, ApocalypseRettributer.Name, IsApocalypseRettributerBlessed);
        }

        #endregion


        #region SpecterCaster
        private void SpCaster_Click(object sender, EventArgs e)
        {
            decimal weaponAttack = 339M;
            Sender(weaponAttack, SpecterCasterResult, SpecterCaster.Name, IsSpecterCasterBlessed);
        }

        private void IsSpecterCasterBlessed_CheckedChanged(object sender, EventArgs e)
        {
            decimal weaponAttack = 339M;
            Sender(weaponAttack, SpecterCasterResult, SpecterCaster.Name, IsSpecterCasterBlessed);
        }

        #endregion

        #region SpecterRettributer

        private void button1_Click_1(object sender, EventArgs e)
        {
            decimal weaponAttack = 373M;
            Sender(weaponAttack, SpecterRettributerResult, SpecterRettributer.Name, IsSpecterRettributerBlessed);
        }

        private void IsSpecterRettributerBlessed_CheckedChanged(object sender, EventArgs e)
        {
            decimal weaponAttack = 373M;
            Sender(weaponAttack, SpecterRettributerResult, SpecterRettributer.Name, IsSpecterRettributerBlessed);
        }

        #endregion

        #region AmaranthineCaster

        private void AmaCaster_Click(object sender, EventArgs e)
        {
            decimal weaponAttack = 371M;
            Sender(weaponAttack, AmaranthineCasterResult, AmaranthineCaster.Name, IsAmaranthineCasterBlessed);
        }

        private void IsAmaranthineCasterBlessed_CheckedChanged(object sender, EventArgs e)
        {
            decimal weaponAttack = 371M;
            Sender(weaponAttack, AmaranthineCasterResult, AmaranthineCaster.Name, IsAmaranthineCasterBlessed);
        }

        #endregion

        #region AmaranthineRettributer

        private void AmaRettributer_Click(object sender, EventArgs e)
        {
            decimal weaponAttack = 408;
            Sender(weaponAttack, AmaranthineRettributerResult, AmaranthineRettributer.Name, IsAmaranthineRettributerBlessed);
        }

        private void IsAmaranthineRettributerBlessed_CheckedChanged(object sender, EventArgs e)
        {
            decimal weaponAttack = 408;
            Sender(weaponAttack, AmaranthineRettributerResult, AmaranthineRettributer.Name, IsAmaranthineRettributerBlessed);
        }
        #endregion

        #region MyCaster

        private void MCaster_Click(object sender, EventArgs e)
        {
            string weaponAttack = (OwnWeaponAttack.Text);
            Sender(weaponAttack, MyCasterResult, MCaster.Name);
        }
        #endregion

        #endregion


        #region MakeToolStripsButtonsWork               

        public int CalculateButtons()
        {
            int result = 0;
            foreach (Button b in Controls.OfType<Button>())
            {
                result++;
            }
            return result;
        }

        private int CalculateResultLabels()
        {
            int result = 0;
            foreach(Label l in Controls.OfType<Label>())
            {
                if(l.Name.Contains("Result"))
                {
                    result++;
                }
            }
            return result;
        }

        private string[] GetWeaponNames()
        {
            string[] result = new string[CalculateResultLabels()];
            int i = 0;

            foreach (Label l in Controls.OfType<Label>())
            {
                if ((l.Name.Contains("Rettributer") || (l.Name.Contains("Caster"))) && (!l.Name.Contains("Result")))
                {
                    result[i] = l.Name;
                    i++;
                }
            }
            return result;
        }

        private string[] GetResultsLabels()
        {
            int i = 0;
            string[] result = new string[CalculateResultLabels()];
            foreach (Label l in Controls.OfType<Label>())
            {
                if (l.Name.Contains("Result"))
                {
                    result[i] = l.Name;
                    i++;
                }
            }
            return result;
        }

        private decimal[] GetResults(string[] weaponNames)                        //returns pairs result and their name
        {
            try
            {
                string[] resultFieldsNames = new string[CalculateResultLabels()];

                for (int i = 0; i < CalculateResultLabels(); i++)
                {
                    resultFieldsNames[i] = GetResultsLabels()[i];
                }                

                decimal[] result = new decimal[CalculateResultLabels()];

                for (int i = 0; i < result.Length; i++)
                {
                    if (resultFieldsNames[i].Contains(weaponNames[i]))
                    {
                        foreach (Label l in Controls.OfType<Label>())
                        {
                            if (l.Name == resultFieldsNames[i])
                            {
                                result[i] = ToDecimal(l.Text);
                            }
                        }
                    }
                }
                return result;
            }
            catch(Exception)
            {
                decimal[] result = new decimal[CalculateResultLabels()];

                for (int i = 0; i < result.Length; i++)
                {
                    result[i] = 0;
                }

                RefreshCalculations();

                var s = new Saving(CalculateButtons(), CalculateResultLabels(), GetWeaponNames(), GetResults(GetWeaponNames()), GetBuffNames(),AreWeaponsBlessed());
                s.SaveToHtml();

                return result;                
            }
        }

        private string[] AreWeaponsBlessed()
        {
            int j = 0;
            foreach(CheckBox c in Controls.OfType<CheckBox>())
            {
                ++j;
            }

            string[] result = new string[j+1];

            int i = 1;
            foreach (CheckBox cb in Controls.OfType<CheckBox>())
            {
                if (cb.Name.Contains("Blessed"))
                {
                    if(cb.Checked)
                    {
                        result[i] = cb.Text;
                    }
                    else
                    {
                        result[i] = "";
                    }
                    ++i;
                }
            }
            //result[result.Length - 1] = "";
            return result;
        }

        #endregion

        #region ToolStripButtons

        private void Save_Click(object sender, EventArgs e)
        {
            RunBackgroundWorker();

            int buttonNo = CalculateButtons();
            int resultsNo = CalculateResultLabels();
            string[] weapNames = GetWeaponNames();
            decimal[] results = GetResults(weapNames);
            string[] buffNames = GetBuffNames();
            string[] bles = AreWeaponsBlessed();

            var s = new Saving(buttonNo, resultsNo, weapNames, results, buffNames, bles);
            s.SaveToHtml();
            
        }


        private void CalcucalteAll_Click(object sender, EventArgs e)
        {
            RunBackgroundWorker();
            RefreshCalculations();
        }



        private void CopyrightInfo_Click(object sender, EventArgs e)  
        {
            MessageBox.Show("Although code is open source project, all the images belong to NCSoft.", "Copyright Info", MessageBoxButtons.OK, MessageBoxIcon.Information); 
        }

        private void Contributors_Click(object sender, EventArgs e)                 //add yourself here if you also contributted to this project!
        {
            System.Diagnostics.Process.Start("https://github.com/Quanthis");
        }

        #endregion



        #region Buffs

        private bool[] GetActiveBuffs()
        {
            bool[] result = new bool[Buffs.Items.Count];
            for (int i = 0; i < result.Length; i++)
            {
                if (Buffs.GetItemCheckState(i) == CheckState.Checked)
                {
                    result[i] = true;
                }
                else
                {
                    result[i] = false;
                }
            }

            return result;
        }

        private string[] GetBuffNames()
        {
            int i = 0;
            foreach(object item in Buffs.CheckedItems)
            {
                ++i;
            }

            string[] result = new string[i];

            i = 0;

            foreach(object item in Buffs.CheckedItems)
            {
                result[i] = (string)item;
                ++i;
            }
            return result;
        }

        private void Buffs_SelectedIndexChanged(object sender, EventArgs e)
        {
            //RefreshCalculations();
        }

        #endregion

        #region BackGroundWorker

        private void T2_DoWork(object sender, DoWorkEventArgs e)
        {
            using (BackgroundWorker bw = sender as BackgroundWorker)
            {

                for (int i = 0; i <= 10; i++)
                {
                    if (bw.CancellationPending)
                    {
                        e.Cancel = true;
                        break;
                    }
                    else
                    {
                        Thread.Sleep(100);
                        bw.ReportProgress(i * 10);
                    }
                }
                
            }
        }

        private void T2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ProgressBar1.Increment(10);
            ProgressBar1.Update();
        }

        private void T2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                ResetProgressBar();
                T2.CancelAsync();
            }
            else
            {
                ResetProgressBar();
                T2.CancelAsync();
            }
        }

        private void RunBackgroundWorker()
        {
            ProgressBar1.Visible = true;
            UseWaitCursor = true;
            if(T2.IsBusy)
            {
                T2.CancelAsync();                
            }
            else if(!T2.IsBusy)
            {
                T2.RunWorkerAsync();
            }
        }

        private void ResetProgressBar()
        {
            ProgressBar1.Visible = false;
            ProgressBar1.Value = 0;
            ProgressBar1.Update();
            UseWaitCursor = false;
        }
        #endregion
    }
}
