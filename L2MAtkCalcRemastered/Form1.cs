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
using System.Numerics;


namespace L2MAtkCalcRemastered
{
    public partial class Form1 : Form                               //remember to add database binding possibility soon, best in another branch (windows 7 compability problems)
    {
        #region Initialization

        public Form1()
        {
            InitializeComponent();
        }

        #endregion

        
        #region Blessed
        private async Task<bool> IsBlessed(CheckBox isChecked, string wName)        
        {
            return await Task.Run(() =>
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
            });
        }

        #endregion


        #region MakeButtonsWork

        private async Task Sender(decimal weaponAttack, Label whereToSend, string weapName, CheckBox Blessed)
        {
            string OwnAtak = OwnMAttack.Text;
            var wp = new Weapon
                (weaponAttack, weapName, OwnAtak, await HaveSigil(), await IsBlessed(Blessed, weapName), await GetActiveBuffs());   
            
            whereToSend.Text = await wp.ConvertToSendableForm();
            //wp.Dispose();

            //wp = null;                //this instruction doesn't pay off - it takes up to 300kB of memory more
        }

        private async Task Sender(string weaponAttack, Label whereToSend, string weapName)
        {
            string OwnAtak = OwnMAttack.Text;
            var wp = new Weapon
                (weaponAttack, OwnAtak, await GetActiveBuffs());

            whereToSend.Text = await wp.ConvertToSendableForm();
            //wp.Dispose();

            //wp = null;
        }

        private async Task RefreshCalculations()
        {
            #region notWorking
            /*Task t1 = Task.Run( async () => ApoCaster.PerformClick());
            Task t2 = Task.Run( async () => ApoRettributer.PerformClick());
            Task t3 = Task.Run( async () => SpCaster.PerformClick());
            Task t4 = Task.Run( async () => SpRettriButer.PerformClick());
            Task t5 = Task.Run( async () => AmaCaster.PerformClick());
            Task t6 = Task.Run( async () => AmaRettributer.PerformClick());
            Task t7 = Task.Run( async () => MCaster.PerformClick());*/
            #endregion

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

        private async Task<bool> HaveSigil()
        {
            return await Task.Run(() =>
            {
                if (HavingSigil.Checked)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            });
        }
        #endregion

        #region Initializev2

        #region CheckForErrors
        private async Task CheckIfErrorOccured()
        {
            await Task.Run(() =>
            {
                while (true)
                {
                    ushort flag = Weapon.GetErrorCode();
                    Weapon.ResetErrorCode();

                    switch (flag)
                    {
                        case 0:
                            break;
                        case 1:
                            MessageBox.Show($"Field 'OwnMAttack' can only contain numbers!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        case 2:
                            MessageBox.Show("I don't think you attack is so low, try inserting it again :)", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        case 3:
                            MessageBox.Show($"Field 'OwnMAttack' cannot be empty and can only contain numbers!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        case 4:
                            MessageBox.Show("Have you really become a god among races?", "Error - unexpectedly high value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        case 5:
                            MessageBox.Show(@"Unexpected exception! Please report that issue on github: https://github.com/issues. My nickname is: Quanthis, repository: 'L2MAtkCalcRemastered'", "Error!");
                            break;
                        default:
                            break;
                    }

                    Thread.Sleep(300);
                }
            });
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckIfErrorOccured();
            TestButton.Dispose();

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
            return await Task.Run(() =>                                 //why did this method work before adding this? Because it only reads from UI thread?
            {
                int result = 0;
                foreach (Button b in Controls.OfType<Button>())
                {
                    result++;
                }
                return result;
            });
        }

        public async Task<int> CalculateResultLabels()
        {
            return await Task.Run(() =>
            {
                int result = 0;
                foreach (Label l in Controls.OfType<Label>())
                {
                    if (l.Name.Contains("Result"))
                    {
                        result++;
                    }
                }
                return result;
            });
        }
        private async Task<string[]> GetWeaponNames()
        {
            return await Task.Run(async() =>
            {
                string[] result = new string[await CalculateResultLabels()];
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
            });
        }

        private async Task<string[]> GetResultsLabels()
        {
            return await Task.Run(async() =>
            {
                int i = 0;
                string[] result = new string[await CalculateResultLabels()];
                foreach (Label l in Controls.OfType<Label>())
                {
                    if (l.Name.Contains("Result"))
                    {
                        result[i] = l.Name;
                        i++;
                    }
                }
                return result;
            });
        }

        private async Task<decimal[]> GetResults(string[] weaponNames)                        //returns pairs result and their name
        {
            return await Task.Run(async () =>                                           
            {
                try
                {
                    string[] resultFieldsNames = new string[await CalculateResultLabels()];

                    resultFieldsNames = await GetResultsLabels();

                    decimal[] result = new decimal[await CalculateResultLabels()];

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
                catch (Exception)
                {
                    decimal[] result = new decimal[await CalculateResultLabels()];

                    for (int i = 0; i < result.Length; i++)
                    {
                        result[i] = 0;
                    }

                    await RefreshCalculations();

                    var s = new Saving
                        (await CalculateButtons(), await CalculateResultLabels(), await GetWeaponNames(), await GetResults(await GetWeaponNames()), await GetBuffNames(), await AreWeaponsBlessed());
                    s.SaveToHtml();

                    return result;
                }
            });
        }

        private async Task<string[]> AreWeaponsBlessed()
        {
            return await Task.Run(() =>
            {
                int j = 0;
                foreach (CheckBox c in Controls.OfType<CheckBox>())
                {
                    ++j;
                }

                string[] result = new string[j + 1];

                int i = 1;
                foreach (CheckBox cb in Controls.OfType<CheckBox>())
                {
                    if (cb.Name.Contains("Blessed"))
                    {
                        if (cb.Checked)
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
            });
        }

        #endregion

        #region ToolStripButtons

        private async void Save_Click(object sender, EventArgs e)
        {
            RunBackgroundWorker();

            int buttonNo = await CalculateButtons();
            int resultsNo = await CalculateResultLabels();
            string[] weapNames = await GetWeaponNames();
            decimal[] results = await GetResults(weapNames);
            string[] buffNames = await GetBuffNames();
            string[] bles = await AreWeaponsBlessed();

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

        private async Task<bool[]> GetActiveBuffs()
        {
            return await Task.Run(() =>
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
            });
        }

        private async Task<string[]> GetBuffNames()
        {
            return await Task.Run(() =>
            {
                int i = 0;
                foreach (object item in Buffs.CheckedItems)
                {
                    ++i;
                }

                string[] result = new string[i];

                i = 0;

                foreach (object item in Buffs.CheckedItems)
                {
                    result[i] = (string)item;
                    ++i;
                }
                return result;
            });
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

        #region TestingTools
        
        public static async Task TestForResponsivenessV1()
        {
            for(int i = 0; i <= 10; i++)
            {
                Thread.Sleep(1000);
            }

            Debug.WriteLine("Work finished. ");
        }

        public static async Task TestForResponsivenessV2()
        {
            await Task.Run(() =>
            {
                  for (int i = 0; i <= 10; i++)
                  {
                        Thread.Sleep(1000);
                  }

              Debug.WriteLine("Work finished. ");
            });
        }

        public static async Task<Task> TypedTestForResponsivenessV1()
        {
            return Task.Run(() =>
            {
                for (int i = 0; i <= 10; i++)
                {
                    Thread.Sleep(1000);
                }

                Debug.WriteLine("Work finished. ");
            });
        }

        public static async Task<Task> TypedTestForResponsivenessV2()
        {
            return Task.Run(() =>
            {
                for (int i = 0; i <= 10; i++)
                {
                    Thread.Sleep(1000);
                }

                Debug.WriteLine("Work finished. ");
                int r = 0;
                return r;
            });
        }

        public static async Task<int> TypedTestForResponsivenessV3()
        {
            return await Task.Run(() =>
            {
                for (int i = 0; i <= 10; i++)
                {
                    Thread.Sleep(1000);
                }

                Debug.WriteLine("Work finished.");

                return 0;
            });
        }

        public static async Task<int> TypedTestForResponsivenessV4()
        {
            for (int i = 0; i <= 10; i++)
            {
                Thread.Sleep(1000);
            }

            Debug.WriteLine("Work finished.");

            return 0;
        }


        public static async Task<int> TypedTestForReponsivenessV5()
        {
            return await Task.Run(async () =>
            {
                for (int i = 0; i <= 10; i++)
                {
                    Thread.Sleep(1000);
                }

                Debug.WriteLine("Work finished. ");

                return 0;
            });
        }


        private async void TestButton_Click(object sender, EventArgs e)
        {
            //await Task.Run(async () =>
            //{
            //TestForResponsivenessV1();              //freezes app for period of time but remembers inputs                                //1
            //TestForResponsivenessV2();                 //doesn't freeze app                                                              //2

            //await TypedTestForResponsivenessV1();             //doesn't freeze app, no matter with awaiter or w/o                        //3
            /*var r = TypedTestForResponsivenessV2().Result;
            Debug.WriteLine(r);*/                        //doesn't freeze app, however returns used library instead of intended value      //4
                                                         //additionaly, result is gained before method has run to end

            //await TypedTestForResponsivenessV3();                 //doesn't freeze app although uselesness of this instruction at all    //5
            /*int r = TypedTestForResponsivenessV3().Result;
            Debug.WriteLine(r);    */                       //freezes app permanently                                                      //6

            //Debug.WriteLine(await TypedTestForResponsivenessV4());                 //freezes app periodically                              //7
            /*var r = TypedTestForResponsivenessV4().Result;
            Debug.WriteLine(r);*/                               //freezes app periodically, returns expected result                        //8

            /* When method body was moved into awaiter, most methods started behaving differently:
             * 
             * Method 8. stopped freezing app, result was still gained. 
             * Method 7. also stopped freezing app.
             * Method 6. also stopped freezing app, although it freezed it permanently.                 
             * Method 6. also stopped freezing app, although it freezed it permanently.
             * Method 5. - no changes.
             * Method 4. - no changes.
             * Method 3. - no changes.
             * Method 2. - no changes.
             * Method 1. stopped freezing app.
             * 
             * Additionaly, when we try to await task that doesn't return result async keyword must be declared at beggining.
             * 
             * */

            //});

            await TypedTestForResponsivenessV3();
            //await TypedTestForReponsivenessV5();
        }

        #endregion
    }
}