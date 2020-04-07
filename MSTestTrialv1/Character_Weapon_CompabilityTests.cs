using Microsoft.VisualStudio.TestTools.UnitTesting;
using L2MAtkCalcRemastered;
using static System.Convert;
using System.Threading.Tasks;
using System;

namespace Tests
{
    [TestClass]
    public class Character_Weapon_CompabilityTests
    {
        [TestMethod]
        public async Task AddInteligenceVSConvertToSendableForm()
        {
            bool[] buffs = InitializeEmptyBuffs();

            var weaponObject = new Weapon("293", "2390", buffs, "115");

            var weaponMethodResult = ToDecimal(await weaponObject.ConvertToSendableForm());

            var characterObject = new Character(115);

            var characterResult = await characterObject.AddInteligence(weaponMethodResult);

            Assert.AreEqual(weaponMethodResult, characterResult);
        }


        [TestMethod]
        public async Task AddInteligenceVSConvertToSendableFormV2()
        {
            bool[] buffs = InitializeEmptyBuffs();

            var weaponObject = new Weapon("293", "2390", buffs, "115");

            var weaponMethodResult = ToDecimal(await weaponObject.ConvertToSendableForm());

            var characterObject = new Character(120);

            var characterResult = await characterObject.AddInteligence(weaponMethodResult);

            Assert.AreNotEqual(weaponMethodResult, characterResult);
        }

        #region TestingMethods
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
        #endregion
    }
}
