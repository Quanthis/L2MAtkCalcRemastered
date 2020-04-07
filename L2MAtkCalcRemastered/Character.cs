using System;
using System.Threading.Tasks;

namespace L2MAtkCalcRemastered
{
    public class Character 
    {
        private readonly static decimal intelligenceFactor = 163.7612166428M;
        
        private int INT = 115;


        public Character(int intelligence)
        {
            INT = intelligence;
        }

        public async Task <decimal> AddInteligence(decimal totalMagicalAttack)
        {
            return await Task.Run(() =>
            {
                return (totalMagicalAttack / (115 * intelligenceFactor) )  * (intelligenceFactor * INT);
            });
        }

        private decimal BalanceIntelligence(decimal totalMagicalAttack)
        {
            return totalMagicalAttack + intelligenceFactor * GetINTDifference();
        }

        private int GetINTDifference()
        {
            return 115 - INT;
        }
    }
}
