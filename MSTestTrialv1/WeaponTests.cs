using Microsoft.VisualStudio.TestTools.UnitTesting;
using L2MAtkCalcRemastered;
using static System.Convert;

namespace Tests
{
    [TestClass]
    public class WeaponTests
    {
        private decimal weapFactor = 31.4735M;

        private readonly static decimal sigilFactor = 1.04M;
        private readonly static decimal blessedFactor = 1.29M;
        private readonly static decimal essenceOfManaFactor = 0.49M;

        private readonly static string ownAttack = "2930";                            //I use 2390 number because it was actual value of my character attack in game while I was experimenting
        private readonly static decimal apoCasterAttack = 293M;
        private readonly static decimal apoRettriAttack = 322M;
        private readonly static string apoCasterName = "ApocalypseCaster";
        private readonly static string apoRettributerName = "ApocalypseRettributer";

        #region TestedMethods
        #region No Buffs
        [TestMethod]
        public void CalculateMAtkOverloadClean()            //no buffs, no blessed, no sigil, 'Clean Case'
        {
            bool[] buffs = InitializeEmptyBuffs();

            var programDataItem = new Weapon(apoCasterAttack.ToString(), ownAttack, buffs);

            var programResult = ToDecimal(programDataItem.ConvertToSendableForm());

            decimal correctProgramResult = CalculateMAtkTest_Clean(ToDecimal(ownAttack), ToDecimal(apoCasterAttack));

            Assert.AreEqual(programResult, correctProgramResult);
        }

        [TestMethod]
        public void CalculateMAtkOverloadBlessed()
        {
            bool[] buffs = InitializeEmptyBuffs();
                               
            bool sigil = false;
            bool blessed = true;

            var programDataItem = new Weapon(apoRettriAttack, apoRettributerName, ownAttack, sigil, blessed, buffs);

            var programDataResult = ToDecimal(programDataItem.ConvertToSendableForm());

            decimal correctResult = CalculateMAtkTests_Blessed(ToDecimal(ownAttack), apoRettriAttack);

            Assert.AreEqual(programDataResult, correctResult);
        }

        [TestMethod]
        public void CalculateMAtkOverloadBlessedV2()
        {
            bool[] buffs = InitializeEmptyBuffs();
                                
            bool sigil = false;
            bool blessed = true;

            var programDataItem = new Weapon(apoCasterAttack, apoCasterName, ownAttack, sigil, blessed, buffs);

            var programDataResult = ToDecimal(programDataItem.ConvertToSendableForm());

            decimal correctResult = CalculateMAtkTests_Blessed(ToDecimal(ownAttack), apoCasterAttack);

            Assert.AreEqual(programDataResult, correctResult);
        }

        [TestMethod]
        public void CalculateMAtkOverloadSigil()
        {
            bool[] buffs = InitializeEmptyBuffs();

            bool sigil = true;
            bool blessed = false;

            var programDataItem = new Weapon(apoCasterAttack, apoCasterName, ownAttack, sigil, blessed, buffs);

            var programDataResult = ToDecimal(programDataItem.ConvertToSendableForm());

            decimal correctResult = CalculateMAtkTests_Sigil(ToDecimal(ownAttack), apoCasterAttack);

            Assert.AreEqual(programDataResult, correctResult);
        }

        [TestMethod]
        public void CalculateMAtkOverloadSigilV2()              //other weapon type than caster must be checked, because sigil only applies to caster
        {
            bool[] buffs = InitializeEmptyBuffs();

            bool sigil = true;
            bool blessed = false;

            var programDataItem = new Weapon(apoRettriAttack, apoRettributerName, ownAttack, sigil, blessed, buffs);

            var programDataResult = ToDecimal(programDataItem.ConvertToSendableForm());

            decimal correctResult = CalculateMAtkTests_Sigil(ToDecimal(ownAttack), apoRettriAttack);
            
            Assert.AreNotEqual(programDataResult, correctResult);
        }

        [TestMethod]
        public void CalculateMAtkOverloadSigilAndBlessed()
        {
            bool[] buffs = InitializeEmptyBuffs();

            bool sigil = true;
            bool blessed = true;

            var programDataItem = new Weapon(apoCasterAttack, apoCasterName, ownAttack, sigil, blessed, buffs);

            var programDataResult = ToDecimal(programDataItem.ConvertToSendableForm());

            decimal correctResult = CalculateMAtkTests_Sigil_Blessed(ToDecimal(ownAttack), apoCasterAttack);

            Assert.AreEqual(programDataResult, correctResult);
        }

        [TestMethod]
        public void CalculateMAtkOverloadSigilAndBlessedV2()
        {
            bool[] buffs = InitializeEmptyBuffs();

            bool sigil = true;
            bool blessed = true;

            var programDataItem = new Weapon(apoRettriAttack, apoRettributerName, ownAttack, sigil, blessed, buffs);

            var programDataResult = ToDecimal(programDataItem.ConvertToSendableForm());

            decimal correctResult = CalculateMAtkTests_Sigil_Blessed(ToDecimal(ownAttack), apoRettriAttack);

            Assert.AreNotEqual(programDataResult, correctResult);
        }
        #endregion
        #endregion


        #region TestMethods
        private bool[] InitializeEmptyBuffs()
        {
            bool[] buffs = new bool[7];

            int i = 0;
            foreach (var item in buffs)
            {
                buffs[i] = false;
                ++i;
            }
            return buffs;
        }

        private decimal CalculateMAtkTest_Clean(decimal OwnAttack, decimal weaponAttack)
        {
            return OwnAttack + (weaponAttack * weapFactor);
        }

        private decimal CalculateMAtkTests_Blessed(decimal ownAttack, decimal weaponAttack)
        {
            return ownAttack + (weaponAttack * weapFactor * blessedFactor);
        }

        private decimal CalculateMAtkTests_Sigil(decimal ownAttack, decimal weapAttack)
        {
            return (ownAttack + (weapAttack * weapFactor)) * sigilFactor;
        }

        private decimal CalculateMAtkTests_Sigil_Blessed(decimal ownAttack, decimal weapAttack)
        {
            return (ownAttack + (weapAttack * weapFactor * blessedFactor)) * sigilFactor;
        }

        #endregion
    }
}
