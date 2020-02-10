using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Convert;
using System.Threading;

namespace L2MAtkCalcRemastered
{
    class Weapon : IDisposable
    {
        #region ClassPreparations

        private bool disposed = false;

        decimal factor = 31.4735M;
        readonly decimal sigilFactor = 1.04M;
        readonly decimal blessedFactor = 1.29M;

        decimal weaponAttack;
        string weaponName;
        string OwnMAttack2;
        bool sigilOn;
        bool isBlessed;
        bool[] buffs;
        decimal essenceOfManaFactor = 0.49M;

        internal Weapon(decimal weapAttack, string weapName, string OwnAttack, bool sigil, bool blessed, bool[] bufs)
        {
            weaponAttack = weapAttack;
            weaponName = weapName;
            OwnMAttack2 = OwnAttack;
            sigilOn = sigil;
            isBlessed = blessed;
            buffs = bufs;

            if (buffs[0])
            {
                factor = 39.4513M;
            }
            if(buffs[1])
            {
                factor = factor + (factor * essenceOfManaFactor);
            }
            if(buffs[2])
            {
                factor *= 2;
            }
            if(buffs[3])
            {
                factor *= 1.45M;
            }
            if(buffs[4])
            {
                factor *= 2;
            }
            if(buffs[5])
            {
                factor *= 1.2M;
            }
            if(buffs[6])
            {
                factor *= 1.33M;
            }
        }

        internal Weapon(string weapAttack, string OwnAttack, bool[] bufs)
        {
            try
            {
                weaponAttack = ToDecimal(weapAttack);
            }
            catch(Exception)
            {
                MessageBox.Show($"Field 'OwnMAttack' can only contain numbers!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            OwnMAttack2 = OwnAttack;
            buffs = bufs;

            if(buffs[0])
            {
                factor = 39.4513M;
            }
            if (buffs[1])
            {
                factor = factor + (factor * essenceOfManaFactor);
            }
            if (buffs[2])
            {
                factor *= 2;
            }
            if (buffs[3])
            {
                factor *= 1.45M;
            }
            if (buffs[4])
            {
                factor *= 2;
            }
            if (buffs[5])
            {
                factor *= 1.2M;
            }
            if (buffs[6])
            {
                factor *= 1.33M;
            }
        }
        #endregion

        #region ClassMethods

        private bool DoesSigilMatter(string weaponName)
        {
            if (sigilOn)
            {
                if (weaponName.Contains("Rettributer"))
                {
                    return false;
                }
                else
                {
                    return true;
                }
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
                    MessageBox.Show("I don't think you attack is so low, try inserting it again :)", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return result;
            }
            catch (FormatException)
            {
                MessageBox.Show($"Field 'OwnMAttack' cannot be empty and can only contain numbers!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            catch (OverflowException)
            {
                MessageBox.Show("Have you really become a god among races?", "Error - unexpectedly high value", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (isBlessed)
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
                    return (OwnAttack + (weaponAttack * factor));
                }
            }
        }

        private decimal CalculateMAtk(decimal OwnAttack, decimal weaponAttack)
        {
            return (OwnAttack + weaponAttack * factor);
        }
        #endregion

        #region ReturningValues

        public string ConvertToSendableForm()
        {
            if (weaponName != null)
            {
                decimal sentValue = CalculateMAtk(ConvertOwnAttack(), weaponAttack, weaponName);
                string result = sentValue.ToString();
                return result;
            }
            else
            {
                decimal sentValue = CalculateMAtk(ConvertOwnAttack(), weaponAttack);
                string result = sentValue.ToString();
                return result;
            }
        }

        #endregion

        #region Cleaning

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if(!this.disposed)
            {
                if(disposing)
                {
                                    //dispose external objects here (there are no external objects here atm)
                }

                disposed = true;
            }
        }

        ~Weapon()
        {
            Dispose(false);
        }

        #endregion
    }
}
