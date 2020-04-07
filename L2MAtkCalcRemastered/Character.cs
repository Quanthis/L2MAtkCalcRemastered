using System;
using System.Threading.Tasks;

namespace L2MAtkCalcRemastered
{
    public class Character 
    {
        private readonly static decimal intelligenceFactor = 163.7612166428M;
        
        private int INT = 115;                                                              //115 is value I used to have while experimenting


        public Character(int intelligence)
        {
            INT = intelligence;
        }

        public Character()
        {
        }


        public async Task <decimal> AddInteligence(decimal totalMagicalAttack)
        {
            return await Task.Run(() =>
            {
                if (INT != 115)
                {
                    return (totalMagicalAttack / (115 * intelligenceFactor)) * (intelligenceFactor * INT);
                }
                else
                {
                    return totalMagicalAttack;
                }
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
