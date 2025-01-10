using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_BasedAdventure
{
    /// <summary>
    /// Represents a monster in the game that implements the <see cref="ICharacter"/> interface.
    /// </summary>
    public class Monster : ICharacter
    {
        /// <summary>
        /// Gets or sets the name of the monster.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Gets the current health of the monster.
        /// </summary>
        public int Health { get;  set; }

        /// <summary>
        /// Gets the attack power of the monster, used when attacking other characters.
        /// </summary>
        public int AttackPower { get;  set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Monster"/> class with specified health and attack power.
        /// </summary>
        /// <param name="health">The initial health of the monster. Default is 50.</param>
        /// <param name="attackPower">The attack power of the monster. Default is 10.</param>
        public Monster(int health = 50, int attackPower = 10)
        {
            Health = health;
            AttackPower = attackPower;
            Name = "Unnamed Monster";
        }

        /// <summary>
        /// Attacks the specified target character.
        /// </summary>
        /// <param name="target">The target character to attack.</param>
        public void Attack(ICharacter target)
        {
            target.TakeDamage(AttackPower);
        }

        /// <summary>
        /// Reduces the monster's health by the specified amount and checks if it has been defeated.
        /// </summary>
        /// <param name="amount">The amount of damage to take.</param>
        public void TakeDamage(int amount)
        {
            Health -= amount;
            if (Health <= 0)
            {
                Console.WriteLine("The monster has been defeated!");
            }
        }
    }
}