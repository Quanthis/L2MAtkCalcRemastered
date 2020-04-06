using System;
using System.Threading.Tasks;
using System.Threading;
using static System.Convert;


namespace L2MAtkCalcRemastered
{
    public class Weapon : IDisposable
    {
        #region ClassPreparations

        private bool disposed = false;

        protected decimal weaponFactor = 31.4735M;

        protected readonly static decimal sigilFactor = 1.04M;
        protected readonly static decimal blessedFactor = 1.29M;
        protected readonly static decimal essenceOfManaFactor = 0.49M;

        private decimal weaponAttack;
        private string weaponName;
        private string OwnMAttack2;
        private bool sigilOn;
        private bool isBlessed;
        private bool[] buffs;

        public static ushort ErrorCode = 0;

        public Weapon(decimal weapAttack, string weapName, string OwnAttack, bool sigil, bool blessed, bool[] bufs)
        {
            weaponAttack = weapAttack;
            weaponName = weapName;
            OwnMAttack2 = OwnAttack;
            sigilOn = sigil;
            isBlessed = blessed;
            buffs = bufs;

            CheckBuffs();
        }

        public Weapon(string weapAttack, string OwnAttack, bool[] bufs)
        {
            try
            {
                weaponAttack = ToDecimal(weapAttack);
            }
            catch(Exception)
            {
                ErrorCode = 1;                
            }
            OwnMAttack2 = OwnAttack;
            buffs = bufs;

            CheckBuffs();
        }

        private void CheckBuffs()
        {
            if (buffs[0])
            {
                weaponFactor *= 1.2534767343956026498482850652136M;
            }
            if (buffs[1])
            {
                weaponFactor = weaponFactor + (weaponFactor * essenceOfManaFactor);
            }
            if (buffs[2])
            {
                weaponFactor *= 2;
            }
            if (buffs[3])
            {
                weaponFactor *= 1.45M;
            }
            if (buffs[4])
            {
                weaponFactor *= 2;
            }
            if (buffs[5])
            {
                weaponFactor *= 1.2M;
            }
            if (buffs[6])
            {
                weaponFactor *= 1.33M;
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
                    ErrorCode = 2;
                }
                return result;
            }
            catch (FormatException)
            {
                ErrorCode = 3;
                return 0;
            }
            catch (OverflowException)
            {
                ErrorCode = 4;
                return 0;
            }
            catch (Exception)
            {
                ErrorCode = 5;
                return 0;
            }
        }


        private decimal CalculateMAtk(decimal OwnAttack, decimal weaponAttack, string weaponName)
        {
            if (isBlessed)
            {
                if (DoesSigilMatter(weaponName))
                {
                    return (OwnAttack + (weaponAttack * blessedFactor) * weaponFactor) * sigilFactor;
                }
                else
                {
                    return (OwnAttack + (weaponAttack * blessedFactor) * weaponFactor);
                }
            }
            else
            {
                if (DoesSigilMatter(weaponName))
                {
                    return (OwnAttack + weaponAttack * weaponFactor) * sigilFactor;
                }
                else
                {
                    return (OwnAttack + (weaponAttack * weaponFactor));
                }
            }
        }

        private decimal CalculateMAtk(decimal OwnAttack, decimal weaponAttack)
        {
            return (OwnAttack + weaponAttack * weaponFactor);
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