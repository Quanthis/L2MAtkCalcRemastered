using Microsoft.VisualStudio.TestTools.UnitTesting;
using L2MAtkCalcRemastered;
using static System.Convert;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass]
    public class WeaponTests
    {
        private decimal weapFactor = 31.4735M;

        private readonly static decimal sigilFactor = 1.04M;
        private readonly static decimal blessedFactor = 1.29M;

        private readonly static decimal echoFactor = 1.2534767343956026498482850652136M;
        private readonly static decimal essenceOfManaFactor = 0.49M;
        private readonly static decimal battleRhapsodyFactor = 2M;
        private readonly static decimal hornMelodyFactor = 1.45M;
        private readonly static decimal fantasiaHarmonyFactor = 2M;
        private readonly static decimal prophecyOfMightFactor = 1.2M;
        private readonly static decimal prevailingSonataFactor = 1.33M;

        private readonly static string ownAttack = "2930";                            //I use 2390 number because it was actual value of my character attack in game while I was experimenting
        private readonly static decimal ownAttackDecimal = 2930M;                       //to descrease number of arguments taken by testing methods
        private readonly static decimal apoCasterAttack = 293M;
        private readonly static decimal apoRettriAttack = 322M;
        private readonly static string apoCasterName = "ApocalypseCaster";
        private readonly static string apoRettributerName = "ApocalypseRettributer";

        #region TestedMethods
        #region NoBuffs
        [TestMethod]
        public async Task CalculateMAtkOverloadClean()            //no buffs, no blessed, no sigil, 'Clean Case'
        {
            bool[] buffs = InitializeEmptyBuffs();

            var programDataItem = new Weapon(apoCasterAttack.ToString(), ownAttack, buffs);

            var programDataResult = ToDecimal(await programDataItem.ConvertToSendableForm());

            decimal correctResult = CalculateMAtkTest_Clean(ToDecimal(ownAttack), ToDecimal(apoCasterAttack));

            Assert.AreEqual(correctResult, programDataResult);
        }

        [TestMethod]
        public async Task CalculateMAtkOverloadBlessed()
        {
            bool[] buffs = InitializeEmptyBuffs();
                               
            bool sigil = false;
            bool blessed = true;

            var programDataItem = new Weapon(apoRettriAttack, apoRettributerName, ownAttack, sigil, blessed, buffs);

            var programDataResult = ToDecimal(await programDataItem.ConvertToSendableForm());

            decimal correctResult = CalculateMAtkTests_Blessed(ToDecimal(ownAttack), apoRettriAttack);

            Assert.AreEqual(correctResult, programDataResult);
        }

        [TestMethod]
        public async Task CalculateMAtkOverloadBlessedV2()
        {
            bool[] buffs = InitializeEmptyBuffs();
                                
            bool sigil = false;
            bool blessed = true;

            var programDataItem = new Weapon(apoCasterAttack, apoCasterName, ownAttack, sigil, blessed, buffs);

            var programDataResult = ToDecimal(await programDataItem.ConvertToSendableForm());

            decimal correctResult = CalculateMAtkTests_Blessed(ToDecimal(ownAttack), apoCasterAttack);

            Assert.AreEqual(correctResult, programDataResult);
        }

        [TestMethod]
        public async Task CalculateMAtkOverloadSigil()
        {
            bool[] buffs = InitializeEmptyBuffs();

            bool sigil = true;
            bool blessed = false;

            var programDataItem = new Weapon(apoCasterAttack, apoCasterName, ownAttack, sigil, blessed, buffs);

            var programDataResult = ToDecimal(await programDataItem.ConvertToSendableForm());

            decimal correctResult = CalculateMAtkTests_Sigil(ToDecimal(ownAttack), apoCasterAttack);

            Assert.AreEqual(correctResult, programDataResult);
        }

        [TestMethod]
        public async Task CalculateMAtkOverloadSigilV2()              //other weapon type than caster must be checked, because sigil only applies to caster
        {
            bool[] buffs = InitializeEmptyBuffs();

            bool sigil = true;
            bool blessed = false;

            var programDataItem = new Weapon(apoRettriAttack, apoRettributerName, ownAttack, sigil, blessed, buffs);

            var programDataResult = ToDecimal(await programDataItem.ConvertToSendableForm());

            decimal correctResult = CalculateMAtkTests_Sigil(ToDecimal(ownAttack), apoRettriAttack);

            Assert.AreNotEqual(correctResult, programDataResult);
        }

        [TestMethod]
        public async Task CalculateMAtkOverloadSigilAndBlessed()
        {
            bool[] buffs = InitializeEmptyBuffs();

            bool sigil = true;
            bool blessed = true;

            var programDataItem = new Weapon(apoCasterAttack, apoCasterName, ownAttack, sigil, blessed, buffs);

            var programDataResult = ToDecimal(await programDataItem.ConvertToSendableForm());

            decimal correctResult = CalculateMAtkTests_Sigil_Blessed(ToDecimal(ownAttack), apoCasterAttack);

            Assert.AreEqual(correctResult, programDataResult);
        }

        [TestMethod]
        public async Task CalculateMAtkOverloadSigilAndBlessedV2()
        {
            bool[] buffs = InitializeEmptyBuffs();

            bool sigil = true;
            bool blessed = true;

            var programDataItem = new Weapon(apoRettriAttack, apoRettributerName, ownAttack, sigil, blessed, buffs);

            var programDataResult = ToDecimal(await programDataItem.ConvertToSendableForm());

            decimal correctResult = CalculateMAtkTests_Sigil_Blessed(ToDecimal(ownAttack), apoRettriAttack);

            Assert.AreNotEqual(correctResult, programDataResult);
        }
        #endregion

        #region Buffs+
        [TestMethod]
        public async Task TestEcho()
        {
            bool[] buffs = { true, false, false, false, false, false, false };
            bool sigil = true;
            bool blessed = true;

            var programDataItem = new Weapon(apoCasterAttack, apoCasterName, ownAttack, sigil, blessed, buffs);

            var programDataResult = ToDecimal(await programDataItem.ConvertToSendableForm());

            decimal correctResult = B_CalculateMAtkTests_Echo(ToDecimal(ownAttack), apoCasterAttack);

            Assert.AreEqual(correctResult, programDataResult);
        }

        [TestMethod]
        public async Task TestEssenceOfMana()
        {
            bool[] buffs = { false, true, false, false, false, false, false };
            bool sigil = true;
            bool blessed = true;

            var programDataItem = new Weapon(apoCasterAttack, apoCasterName, ownAttack, sigil, blessed, buffs);

            var programDataResult = ToDecimal(await programDataItem.ConvertToSendableForm());

            decimal correctResult = B_CalculateMAtkTests_EssenceOfMana(apoCasterAttack);

            Assert.AreEqual(correctResult, programDataResult);
        }

        [TestMethod]
        public async Task TestBattleRhapsody()
        {
            bool[] buffs = { false, false, true, false, false, false, false };
            bool sigil = true;
            bool blessed = true;

            var programDataItem = new Weapon(apoCasterAttack, apoCasterName, ownAttack, sigil, blessed, buffs);

            var programDataResult = ToDecimal(await programDataItem.ConvertToSendableForm());

            decimal correctResult = B_CalculateMAtkTests_BattleRhapsody(apoCasterAttack);

            Assert.AreEqual(correctResult, programDataResult);
        }

        [TestMethod]
        public async Task TestHornMelody()
        {
            bool[] buffs = { false, false, false, true, false, false, false };
            bool sigil = true;
            bool blessed = true;

            var programDataItem = new Weapon(apoCasterAttack, apoCasterName, ownAttack, sigil, blessed, buffs);

            var programDataResult = ToDecimal(await programDataItem.ConvertToSendableForm());

            decimal correctResult = B_CalculateMAtkTests_HornMelody(apoCasterAttack);

            Assert.AreEqual(correctResult, programDataResult);
        }

        [TestMethod]
        public async Task TestFantasiaHarmony()
        {
            bool[] buffs = { false, false, false, false, true, false, false };
            bool sigil = true;
            bool blessed = true;

            var programDataItem = new Weapon(apoCasterAttack, apoCasterName, ownAttack, sigil, blessed, buffs);

            var programDataResult = ToDecimal(await programDataItem.ConvertToSendableForm());

            decimal correctResult = B_CalculateMAtkTests_FantasiaHarmony(apoCasterAttack);

            Assert.AreEqual(correctResult, programDataResult);
        }

        [TestMethod]
        public async Task TestProphecyOfMight()
        {
            bool[] buffs = { false, false, false, false, false, true, false };
            bool sigil = true;
            bool blessed = true;

            var programDataItem = new Weapon(apoCasterAttack, apoCasterName, ownAttack, sigil, blessed, buffs);

            var programDataResult = ToDecimal(await programDataItem.ConvertToSendableForm());

            decimal correctResult = B_CalculateMAtkTests_ProphecyOfMight(apoCasterAttack);

            Assert.AreEqual(correctResult, programDataResult);
        }

        [TestMethod]
        public async Task TestPrevailingSonata()
        {
            bool[] buffs = { false, false, false, false, false, false, true };
            bool sigil = true;
            bool blessed = true;

            var programDataItem = new Weapon(apoCasterAttack, apoCasterName, ownAttack, sigil, blessed, buffs);

            var programDataResult = ToDecimal(await programDataItem.ConvertToSendableForm());

            decimal correctResult = B_CalculateMAtkTests_PrevailingSonata(apoCasterAttack);

            Assert.AreEqual(correctResult, programDataResult);
        }

        #endregion
        #endregion
        
        #region TestMethods
        #region noBuffsAgain
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

        #region Buffs
        //Sigil and blessed properties have already been checked, so from now on only one test per buff will be performed with these marked as true
        //All methods start with be which is shortcut for 'Buffs'

        private decimal B_CalculateMAtkTests_Echo(decimal ownAttack, decimal weapAttack)
        {
            return ((ownAttack + (weapAttack * weapFactor * blessedFactor)) * sigilFactor) * echoFactor;
        }

        private decimal B_CalculateMAtkTests_EssenceOfMana(decimal weapAttack)
        {
            return ((ownAttackDecimal + (weapAttack * weapFactor * blessedFactor)) * sigilFactor) * essenceOfManaFactor;
        }

        private decimal B_CalculateMAtkTests_BattleRhapsody(decimal weapAttack)
        {
            return ((ownAttackDecimal + (weapAttack * weapFactor * blessedFactor)) * sigilFactor) * battleRhapsodyFactor;
        }

        private decimal B_CalculateMAtkTests_HornMelody(decimal weapAttack)
        {
            return ((ownAttackDecimal + (weapAttack * weapFactor * blessedFactor)) * sigilFactor) * hornMelodyFactor;
        }

        private decimal B_CalculateMAtkTests_FantasiaHarmony(decimal weapAttack)
        {
            return ((ownAttackDecimal + (weapAttack * weapFactor * blessedFactor)) * sigilFactor) * fantasiaHarmonyFactor;
        }

        private decimal B_CalculateMAtkTests_ProphecyOfMight(decimal weapAttack)
        {
            return ((ownAttackDecimal + (weapAttack * weapFactor * blessedFactor)) * sigilFactor) * prophecyOfMightFactor;
        }

        private decimal B_CalculateMAtkTests_PrevailingSonata(decimal weapAttack)
        {
            return ((ownAttackDecimal + (weapAttack * weapFactor * blessedFactor)) * sigilFactor) * prevailingSonataFactor;
        }

        #endregion
        #endregion
    }
}
