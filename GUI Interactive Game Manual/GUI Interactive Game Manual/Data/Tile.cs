using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_BasedAdventure
{
    /// <summary>
    /// Represents a single tile in the maze, which can contain walls, monsters, items, or be an exit.
    /// </summary>
    public class Tile
    {
        /// <summary>
        /// Gets or sets a value indicating whether the tile is a wall.
        /// </summary>
        public bool IsWall { get; set; }

        /// <summary>
        /// Gets a value indicating whether the tile contains a monster.
        /// </summary>
        public bool HasMonster { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the tile contains an item.
        /// </summary>
        public bool HasItem { get; private set; }

        /// <summary>
        /// Gets or sets a value indicating whether the tile is the exit.
        /// </summary>
        public bool IsExit { get; set; }

        /// <summary>
        /// Gets the monster located on the tile, if any.
        /// </summary>
        public Monster Monster { get; private set; }

        /// <summary>
        /// Gets the item located on the tile, if any.
        /// </summary>
        public Item Item { get; private set; }

        /// <summary>
        /// Places a monster on the tile and marks it as containing a monster.
        /// </summary>
        /// <param name="monster">The monster to be placed on the tile.</param>
        public void PlaceMonster(Monster monster)
        {
            Monster = monster;
            HasMonster = true;
        }

        /// <summary>
        /// Places an item on the tile and marks it as containing an item.
        /// </summary>
        /// <param name="item">The item to be placed on the tile.</param>
        public void PlaceItem(Item item)
        {
            Item = item;
            HasItem = true;
        }

        /// <summary>
        /// Removes the item from the tile and marks it as no longer containing an item.
        /// </summary>
        public void RemoveItem()
        {
            Item = null;
            HasItem = false;
        }
    }
}
