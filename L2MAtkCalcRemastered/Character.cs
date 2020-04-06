using System;
using System.Threading.Tasks;

namespace L2MAtkCalcRemastered
{
    public class Character 
    {
        private readonly static decimal intelligenceFactor = 163.7612166428M;
        
        private uint INT = 115;


        public Character(uint intelligence)
        {
            INT = intelligence;
        }

        public async Task <decimal> AddInteligence(decimal totalMagicalAttack)
        {
            return await Task.Run(() =>
            {
                return totalMagicalAttack * intelligenceFactor;
            });
        }
    }
}
