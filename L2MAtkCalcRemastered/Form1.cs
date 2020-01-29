using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            MessageBox.Show("Please be sure to first insert your own magic attack at bottom of app screen.", "Information");            
        }

        readonly decimal factor = 31.47M;

        private decimal CalculateMAtk(decimal OwnAttack, decimal weaponAttack, string weaponName)
        {
            decimal blessed_factor = 1.29M;

            if (IsBlessed())
            {
                if (DoesSigilMatter(weaponName))
                {
                    return (OwnAttack + (weaponAttack * blessed_factor) * factor) * 1.04M;
                }
                else
                {
                    return (OwnAttack + (weaponAttack * blessed_factor) * factor);
                }
            }
            else
            {
                if (DoesSigilMatter(weaponName))
                {
                    return (OwnAttack + weaponAttack * factor) * 1.04M;
                }
                else
                {
                    return (OwnAttack + weaponAttack * factor);
                }
            }
        }

        private decimal ConvertOwnAttack()
        {
            decimal result;

            try
            {
                result = ToDecimal(OwnMAttack.Text);
                if (result == 0)
                {
                    MessageBox.Show("I don't think you attack is so low, try inserting it again :)", "Warning");
                }
                return result;
            }
            catch(FormatException)
            {
                MessageBox.Show($"Field {nameof(OwnMAttack)} cannot be empty and can only contain numbers!", "Error!");
                return 0;
            }
            catch(OverflowException)
            {
                MessageBox.Show("Have you really become a god among races?", "Error - unexpectedly high value");
                return 0;
            }
            catch(Exception)
            {
                MessageBox.Show(@"Unexpected exception! Please report that issue on github: https://github.com/issues . My nickname is: Quanthis", "Error!");
                return 0;
            }
        }

        private string ConvertToSendableForm(decimal sentValue)
        {
            string result = sentValue.ToString();
            return result;
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
            whereToSend.Text = ConvertToSendableForm(CalculateMAtk(ConvertOwnAttack(), weaponAttack, weapName));
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

        private bool DoesSigilMatter(string weaponName)
        {
            if (HaveSigil())
            {
                if (weaponName.Contains("Rettributer"))
                {
                    return false;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
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
    }
}
