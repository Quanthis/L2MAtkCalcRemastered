using System;
using System.Windows.Forms;
using System.Threading;
using static System.Convert;
using System.Threading.Tasks;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Linq;
using System.Diagnostics;


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
        private async Task<bool> IsBlessed(CheckBox isChecked, string wName)        //why placing this in return Task.Run()=> freezes UI?
        {                                                                           //because that awaits also UI thred
            if (isChecked.Name.Contains(wName))                                     //funny, wasn't it completely backwards in console apps?
            {                                                                       //so this is deadlock I guess
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

        private async Task Sender(decimal weaponAttack, Label whereToSend, string weapName, CheckBox Blessed)
        {
            string OwnAtak = OwnMAttack.Text;
            var wp = new Weapon(weaponAttack, weapName, OwnAtak, HaveSigil(), IsBlessed(Blessed, weapName).Result, GetActiveBuffs());
            whereToSend.Text = wp.ConvertToSendableForm();
            wp.Dispose();
        }

        private async Task Sender(string weaponAttack, Label whereToSend, string weapName)
        {
            string OwnAtak = OwnMAttack.Text;
            var wp = new Weapon(weaponAttack, OwnAtak, GetActiveBuffs());
            whereToSend.Text = wp.ConvertToSendableForm();
            wp.Dispose();
        }

        private async Task RefreshCalculations()
        {
            ApoCaster.PerformClick();
            ApoRettributer.PerformClick();
            SpCaster.PerformClick();
            SpRettriButer.PerformClick();
            AmaCaster.PerformClick();
            AmaRettributer.PerformClick();
            MCaster.PerformClick();
        }



        #endregion


        #region Sigils

        private void HavingSigil_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void NotHavingSigil_CheckedChanged(object sender, EventArgs e)
        {

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
                    lock (fs)
                    {
                        using (StreamReader sr = new StreamReader(fs, Encoding.Unicode))
                        {
                            string s = "";
                            s = sr.ReadToEnd();
                            OwnMAttack.Text = s;
                        }
                    }
                }
            }
            catch
            {
                using (FileStream fs = new FileStream(@"ConfigurationFiles\OwnMAttack.txt", FileMode.Create))
                {
                    lock (fs)
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

        public async Task<int> CalculateButtons()
        {
            int result = 0;
            foreach (Button b in Controls.OfType<Button>())
            {
                result++;
            }
            return result;

        }

        public async Task<int> CalculateResultLabels()
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

        private async Task<string[]> GetWeaponNames()
        {
            string[] result = new string[CalculateResultLabels().Result];
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

        private async Task<string[]> GetResultsLabels()
        {
            int i = 0;
            string[] result = new string[CalculateResultLabels().Result];
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

        private async Task<decimal[]> GetResults(string[] weaponNames)                        //returns pairs result and their name
        {
            try
            {
                string[] resultFieldsNames = new string[CalculateResultLabels().Result];

                for (int i = 0; i < CalculateResultLabels().Result; i++)
                {
                    resultFieldsNames[i] = GetResultsLabels().Result[i];
                }                

                decimal[] result = new decimal[CalculateResultLabels().Result];

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
                decimal[] result = new decimal[CalculateResultLabels().Result];

                for (int i = 0; i < result.Length; i++)
                {
                    result[i] = 0;
                }

                RefreshCalculations();

                var s = new Saving(CalculateButtons().Result, CalculateResultLabels().Result, GetWeaponNames().Result, GetResults(GetWeaponNames().Result).Result, GetBuffNames(),AreWeaponsBlessed().Result);
                s.SaveToHtml();

                return result;                
            }
        }

        private async Task<string[]> AreWeaponsBlessed()
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

        private async void Save_Click(object sender, EventArgs e)
        {
            RunBackgroundWorker();

            int buttonNo = CalculateButtons().Result;
            int resultsNo = CalculateResultLabels().Result;
            string[] weapNames = GetWeaponNames().Result;
            decimal[] results = GetResults(weapNames).Result;
            string[] buffNames = GetBuffNames();
            string[] bles = AreWeaponsBlessed().Result;

            var s = new Saving(buttonNo, resultsNo, weapNames, results, buffNames, bles);
            s.SaveToHtml();            
        }


        private async void CalcucalteAll_Click(object sender, EventArgs e)
        {
            RunBackgroundWorker();
            RefreshCalculations();
        }


        private void CopyrightInfo_Click(object sender, EventArgs e)  
        {
            MessageBox.Show("Although code is open source project, all the images belong to NCSoft.", "Copyright Info", MessageBoxButtons.OK, MessageBoxIcon.Information); 
        }

        private async void Contributors_Click(object sender, EventArgs e)                 //add yourself here if you also contributted to this project!
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

        #region BackgroundWorker

        private void T2_DoWork(object sender, DoWorkEventArgs e)
        {
            using (BackgroundWorker bw = sender as BackgroundWorker)
            {

                for (int i = 1; i < 5; i++)
                {
                    if (bw.CancellationPending)
                    {
                        e.Cancel = true;
                        break;
                    }
                    else
                    {
                        Thread.Sleep(100);
                        bw.ReportProgress(i * 20);
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

        private async void RunBackgroundWorker()
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

        private async void ResetProgressBar()
        {
            ProgressBar1.Visible = false;
            ProgressBar1.Value = 0;
            ProgressBar1.Update();
            UseWaitCursor = false;
        }
        #endregion

        #region Clear
        private async void ClearAll_Click(object sender, EventArgs e)
        {
            RunBackgroundWorker();
            foreach(CheckBox c in Controls.OfType<CheckBox>())
            {
                c.Checked = false;
            }

            foreach (Label l in Controls.OfType<Label>())
            {
                if(l.Name.Contains("Result"))
                {
                    l.Text = null;
                }
            }

            foreach(TextBox t in Controls.OfType<TextBox>())
            {
                t.Text = null;
            }

            NotHavingSigil.Checked = true;

            for (int i = 0; i < Buffs.Items.Count; i++)
            {
                Buffs.SetItemCheckState(i, CheckState.Unchecked);
            }

            try
            {
                File.Delete(@"ConfigurationFiles\OwnMAttack.txt");                
            }
            catch(Exception)
            {
                MessageBox.Show("File 'OwnMAttack.txt' could not be deleted.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion
    }
}
