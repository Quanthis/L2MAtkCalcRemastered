using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Convert;

namespace L2MAtkCalcRemastered
{
    class Weapon : Form1
    {
        #region ClassPreparations
        readonly decimal factor = 1.29M;
        readonly decimal sigilFactor = 1.04M;
        readonly decimal blessedFactor = 1.29M;

        decimal weaponAttack;
        string weaponName;
        string OwnMAttack2;

        internal Weapon(decimal weapAttack, string weapName, string OwnAttack)
        {
            weaponAttack = weapAttack;
            weaponName = weapName;
            OwnMAttack2 = OwnAttack;
        }
        #endregion

        #region ClassMethods
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


        private decimal ConvertOwnAttack()
        {
            decimal result;

            try
            {
                result = ToDecimal(OwnMAttack2);
                if (result == 0)
                {
                    MessageBox.Show("I don't think you attack is so low, try inserting it again :)", "Warning");
                }
                Debug.WriteLine(result);
                return result;
            }
            catch (FormatException)
            {
                MessageBox.Show($"Field {nameof(OwnMAttack)} cannot be empty and can only contain numbers!", "Error!");
                return 0;
            }
            catch (OverflowException)
            {
                MessageBox.Show("Have you really become a god among races?", "Error - unexpectedly high value");
                return 0;
            }
            catch (Exception)
            {
                MessageBox.Show(@"Unexpected exception! Please report that issue on github: https://github.com/issues. My nickname is: Quanthis, repository: 'L2MAtkCalcRemastered'", "Error!");
                return 0;
            }
        }


        private decimal CalculateMAtk(decimal OwnAttack, decimal weaponAttack, string weaponName)
        {

            if (IsBlessed())
            {
                if (DoesSigilMatter(weaponName))
                {
                    return (OwnAttack + (weaponAttack * blessedFactor) * factor) * sigilFactor;
                }
                else
                {
                    return (OwnAttack + (weaponAttack * blessedFactor) * factor);
                }
            }
            else
            {
                if (DoesSigilMatter(weaponName))
                {
                    return (OwnAttack + weaponAttack * factor) * sigilFactor;
                }
                else
                {
                    return (OwnAttack + weaponAttack * factor);
                }
            }
        }
        #endregion

        #region ReturningValues

        public string ConvertToSendableForm()
        {
            decimal sentValue = CalculateMAtk(ConvertOwnAttack(), weaponAttack, weaponName);
            string result = sentValue.ToString();
            return result;
        }




        #endregion
    }
}
