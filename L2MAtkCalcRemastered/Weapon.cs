using System;
using System.Threading.Tasks;
using System.Threading;
using static System.Convert;


namespace L2MAtkCalcRemastered
{
    public class Weapon : IDisposable, SendableAsync
    {
        #region ClassPreparations

        private bool disposed = false;
               
        protected readonly static decimal sigilFactor = 1.04M;
        protected readonly static decimal blessedFactor = 1.29M;

        private readonly static decimal echoFactor = 1.2534767343956026498482850652136M;
        private readonly static decimal essenceOfManaFactor = 0.49M;
        private readonly static decimal battleRhapsodyFactor = 2M;
        private readonly static decimal hornMelodyFactor = 1.45M;
        private readonly static decimal fantasiaHarmonyFactor = 2M;
        private readonly static decimal prophecyOfMightFactor = 1.2M;
        private readonly static decimal prevailingSonataFactor = 1.33M;

        private static ushort ErrorCode = 0;

        protected decimal weaponFactor = 31.4735M;
        protected decimal ownAttackFactor = 1M;

        private decimal weaponAttack;
        private string weaponName;
        private string OwnMAttack2;
        private bool sigilOn;
        private bool isBlessed;
        private bool[] buffs;

        private Character character;


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

        public Weapon(decimal weapAttack, string weapName, string OwnAttack, bool sigil, bool blessed, bool[] bufs, int intelligence)
        {
            weaponAttack = weapAttack;
            weaponName = weapName;
            OwnMAttack2 = OwnAttack;
            sigilOn = sigil;
            isBlessed = blessed;
            buffs = bufs;

            CheckBuffs();

            character = new Character(intelligence);
        }

        private void CheckBuffs()
        {
            if (buffs[0])               
            {
                weaponFactor *= echoFactor;
                ownAttackFactor *= echoFactor;
            }
            if (buffs[1])               
            {
                weaponFactor *= essenceOfManaFactor;
                ownAttackFactor *= essenceOfManaFactor;
            }
            if (buffs[2])
            {
                weaponFactor *= battleRhapsodyFactor;
                ownAttackFactor *= battleRhapsodyFactor;
            }
            if (buffs[3])
            {
                weaponFactor *= hornMelodyFactor;
                ownAttackFactor *= hornMelodyFactor;
            }
            if (buffs[4])
            {
                weaponFactor *= fantasiaHarmonyFactor;
                ownAttackFactor *= fantasiaHarmonyFactor;
            }
            if (buffs[5])
            {
                weaponFactor *= prophecyOfMightFactor;
                ownAttackFactor *= prophecyOfMightFactor;
            }
            if (buffs[6])
            {
                weaponFactor *= prevailingSonataFactor;
                ownAttackFactor *= prevailingSonataFactor;
            }
        }

        #endregion

        #region ClassMethods

        private async Task<bool> DoesSigilMatter(string weaponName)
        {
            return await Task.Run(() =>
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
            });
        }

        private async Task<decimal> ConvertOwnAttack()
        {
            return await Task.Run(() =>
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
            });
        }


        private async Task<decimal> CalculateMAtk(decimal OwnAttack, string weaponName)
        {
            return await Task.Run(async() =>
            {
                if (isBlessed)
                {
                    if (await DoesSigilMatter(weaponName))
                    {
                        return (OwnAttack * ownAttackFactor + (weaponAttack * blessedFactor) * weaponFactor) * sigilFactor;
                    }
                    else
                    {
                        return (OwnAttack * ownAttackFactor + (weaponAttack * blessedFactor) * weaponFactor);
                    }
                }
                else
                {
                    if (await DoesSigilMatter(weaponName))
                    {
                        return (OwnAttack * ownAttackFactor + weaponAttack * weaponFactor) * sigilFactor;
                    }
                    else
                    {
                        return (OwnAttack * ownAttackFactor + (weaponAttack * weaponFactor));
                    }
                }
            });
        }

        private async Task<decimal> CalculateMAtk(decimal OwnAttack)
        {
            return await Task.Run(() =>
            {
                return (OwnAttack * ownAttackFactor + weaponAttack * weaponFactor);
            });
        }
        #endregion

        #region ReturningValues

        public async Task <string> ConvertToSendableForm()
        {
            return await Task.Run(async () =>
            {
                if (weaponName != null)
                {
                    decimal sentValue = await CalculateMAtk(await ConvertOwnAttack(), weaponName);
                    string result = sentValue.ToString();
                    return result;
                }
                else
                {
                    decimal sentValue = await CalculateMAtk(await ConvertOwnAttack());
                    string result = sentValue.ToString();
                    return result;
                }
            });
        }

        public static ushort GetErrorCode()
        {
            return ErrorCode;
        }

        public static void ResetErrorCode()
        {
            ErrorCode = 0;
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
                    character = null;           
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