using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_BasedAdventure
{
    /// <summary>
    /// Represents a potion item that heals the player when used.
    /// Inherits from the <see cref="Item"/> class.
    /// </summary>
    public class Potion : Item
    {
        private int healthBoost;
        public int HealAmount => healthBoost;
        public string ImageUrl { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Potion"/> class with a name and a specified health boost value.
        /// </summary>
        /// <param name="name">The name of the potion.</param>
        /// <param name="healthBoost">The amount of health the potion restores.</param>
        public Potion(string name, int healthBoost, string imageUrl)
        {
            Name = name;
            this.healthBoost = healthBoost;
            Message = $"You have picked up a {name} and healed {healthBoost} health!";
            ImageUrl = imageUrl;
        }

        /// <summary>
        /// Uses the potion, healing the player by the specified health boost value.
        /// </summary>
        /// <param name="player">The player who is using the potion.</param>
        public override void Use(Player player)
        {
            player.TakeDamage(-healthBoost);  // Negative damage to restore health.
            Console.WriteLine(Message);
        }
    }
}
