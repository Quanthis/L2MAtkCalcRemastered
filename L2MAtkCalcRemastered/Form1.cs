using System;
using System.Windows.Forms;
using System.Threading;
using static System.Convert;

namespace L2MAtkCalcRemastered
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private bool IsBlessed()
        {
            if (IsApoCasterBlessed.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Sender(decimal weaponAttack, Label whereToSend, string weapName)
        {
            string OwnAtak = OwnMAttack.Text;
            var wp = new Weapon(weaponAttack, weapName, OwnAtak, HaveSigil(), IsBlessed());
            whereToSend.Text = wp.ConvertToSendableForm();
            wp.Dispose();
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


        private void RefreshCalculations()
        {
            ApoCaster.PerformClick();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal weaponAttack = 293;
            Sender(weaponAttack, ApoCasterResult, ApocalypseCaster.Name);
        }

        private void IsApoCasterBlessed_CheckedChanged(object sender, EventArgs e)
        {
            decimal weaponAttack = 293;
            Sender(weaponAttack, ApoCasterResult, ApocalypseCaster.Name);
        }

        private void HavingSigil_CheckedChanged(object sender, EventArgs e)
        {
            RefreshCalculations();
        }

        private void NotHavingSigil_CheckedChanged(object sender, EventArgs e)
        {
            RefreshCalculations();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Please be sure to first insert your own magic attack at bottom of app screen.", "Information");  
        }
    }
}
