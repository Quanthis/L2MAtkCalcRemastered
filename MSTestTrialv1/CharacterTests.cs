using Microsoft.VisualStudio.TestTools.UnitTesting;
using L2MAtkCalcRemastered;
using System.Threading.Tasks;
using System;


namespace Tests
{
    [TestClass]
    public class CharacterTests
    {
        private readonly static decimal intelligenceFactor = 163.7612166428M;
        private readonly static decimal sampleTotalMagicalAttack = 11611.7355M;

        #region TestingMethods
        [TestMethod]
        public async Task CheckIntIF115()
        {
            var programItem = new Character();
            var programResult = await programItem.AddInteligence(sampleTotalMagicalAttack);

            var correctResult = await TestingMethod(115);

            Assert.AreEqual(correctResult, programResult);
        }

        [TestMethod]
        public async Task CheckIntIFLessThan115()
        {
            var programItem = new Character(100);
            var programResult = await programItem.AddInteligence(sampleTotalMagicalAttack);

            var correctResult = await TestingMethod(100);

            Assert.AreEqual(correctResult, programResult);
        }

        [TestMethod]
        public async Task CheckIntIFGreater115()
        {
            var programItem = new Character(135);
            var programResult = await programItem.AddInteligence(sampleTotalMagicalAttack);

            var correctResult = await TestingMethod(135);

            Assert.AreEqual(correctResult, programResult);
        }

        [TestMethod]
        public async Task FailIFGreater115()
        {
            var programItem = new Character(115);
            var programResult = await programItem.AddInteligence(sampleTotalMagicalAttack);

            var correctResult = await TestingMethod(131);

            Assert.AreNotEqual(correctResult, programResult);
        }

        [TestMethod]
        public async Task FaolIFLessThan115()
        {
            var programItem = new Character(115);
            var programResult = await programItem.AddInteligence(sampleTotalMagicalAttack);

            var correctResult = await TestingMethod(99);

            Assert.AreNotEqual(correctResult, programResult);
        }

        [TestMethod]
        public async Task FailButBackwards()
        {
            var programItem = new Character(99);
            var programResult = await programItem.AddInteligence(sampleTotalMagicalAttack);

            var correctResult = await TestingMethod(135);

            Assert.AreNotEqual(correctResult, programResult);
        }

        #endregion


        private async Task<decimal> TestingMethod(int inteligence)
        {
            return await Task.Run(() =>
            {
                if (inteligence == 115)
                {
                    return sampleTotalMagicalAttack;
                }
                else
                {
                    return (sampleTotalMagicalAttack / (115 * intelligenceFactor)) * inteligence * intelligenceFactor;
                }
            });
        }
    }
}
