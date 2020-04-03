using Microsoft.VisualStudio.TestTools.UnitTesting;
using L2MAtkCalcRemastered;
using static System.Convert;

namespace Tests
{
    [TestClass]
    public class WeaponTests
    {
        decimal weapFactor = 31.4735M;

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

            string weapAttack = "293";
            string ownAttack = "2390";

            var programDataItem = new Weapon(weapAttack, ownAttack, buffs);

            var programResult = ToDecimal(programDataItem.ConvertToSendableForm());

            //decimal correctProgramResult = 11611.7355M;
            decimal correctProgramResult = CalculateMAtkTest(ToDecimal(ownAttack), ToDecimal(weapAttack));

            Assert.AreEqual(programResult, correctProgramResult);
        }

        private decimal CalculateMAtkTest(decimal OwnAttack, decimal weaponAttack)
        {
            return OwnAttack + (weaponAttack * weapFactor);
        }
    }
}
