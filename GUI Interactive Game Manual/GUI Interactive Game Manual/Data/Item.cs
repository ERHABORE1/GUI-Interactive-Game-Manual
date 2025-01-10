using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_BasedAdventure
{
    /// <summary>
    /// Represents a base class for all items in the game.
    /// </summary>
    public abstract class Item
    {
        /// <summary>
        /// Gets or sets the name of the item.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the message associated with the item, typically used for player feedback.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the image URL of the item.
        /// </summary>
        public string ImageUrl { get; set; }

        /// <summary>
        /// Defines how the item is used by the player.
        /// </summary>
        /// <param name="player">The player using the item.</param>
        public abstract void Use(Player player);
    }
}