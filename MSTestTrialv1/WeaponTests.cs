using Microsoft.VisualStudio.TestTools.UnitTesting;
using L2MAtkCalcRemastered;

namespace Tests
{
    [TestClass]
    public class WeaponTests
    {
        decimal factor = 31.4735M;

        [TestMethod]
        public void CalculateMAtkOverload2()            //no buffs, no blessed, no sigil, 'Clean Case'
        {
            bool[] buffs = new bool[7];

            int i = 0;
            foreach(var item in buffs)
            {
                buffs[i] = false;
                ++i;
            }

            string weapAttackRes = "293";
            string ownAttackRes = "2390";
            //var researchDataItem = new Weapon(weapAttackRes, ownAttackRes, buffs);

            decimal weapAttackPro = 293M;
            decimal ownAttackPro = 2390M;

            //var programDataItem = new Weapon(weapAttackPro, ownAttackPro, buffs);

            var programResult = CalculateMAtk(ownAttackPro, weapAttackPro);
            var correctProgramResult = CalculateMAtkTest(ownAttackPro, weapAttackPro);

            Assert.AreEqual(programResult, correctProgramResult);
        }

        private decimal CalculateMAtkTest(decimal OwnAttack, decimal weaponAttack)
        {
            return (OwnAttack + weaponAttack) * factor;
        }

        private decimal CalculateMAtk(decimal OwnAttack, decimal weaponAttack)
        {
            return (OwnAttack + weaponAttack * factor);
        }
    }
}
