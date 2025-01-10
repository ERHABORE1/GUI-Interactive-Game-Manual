using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_BasedAdventure
{
    /// <summary>
    /// Represents a character in the game with abilities to attack and take damage
    /// </summary>
    public interface ICharacter
    {
        /// <summary>
        /// Attacks the specified target character.
        /// </summary>
        /// <param name="Target">The target character to attack.</param>
        void Attack(ICharacter Target);

        /// <summary>
        /// Takes damage based on the given attack power.
        /// </summary>
        /// <param name="attackPower">The amount of damage to be taken.</param>
        void TakeDamage(int attackPower);
    }
}
