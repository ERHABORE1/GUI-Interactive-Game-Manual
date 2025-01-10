using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_BasedAdventure
{
    /// <summary>
    /// Represents a weapon in the game, which is a type of item that increases the player's attack power.
    /// </summary>
    public class Weapon : Item
    {
        /// <summary>
        /// Gets the attack modifier that this weapon provides.
        /// </summary>
        public int AttackModifier { get; private set; }
        public string ImageUrl { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Weapon"/> class with the specified name and attack modifier.
        /// </summary>
        /// <param name="name">The name of the weapon.</param>
        /// <param name="attackModifier">The attack modifier provided by the weapon.</param>
        public Weapon(string name, int attackModifier,  string imageUrl)
        {
            Name = name;
            AttackModifier = attackModifier;
            ImageUrl = imageUrl;
            Message = $"You have picked up a {name} that gives +{attackModifier} attack!";
        }

        /// <summary>
        /// Uses the weapon, applying its effects to the player and displaying a message.
        /// </summary>
        /// <param name="player">The player using the weapon.</param>
        public override void Use(Player player)
        {
            Console.WriteLine(Message);
        }
    }
}
