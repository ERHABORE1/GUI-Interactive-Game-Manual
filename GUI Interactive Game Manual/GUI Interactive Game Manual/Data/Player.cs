using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_BasedAdventure
{
    /// <summary>
    /// Represents a player character in the game that implements the <see cref="ICharacter"/> interface.
    /// </summary>
    public class Player : ICharacter
    {
        /// <summary>
        /// Gets or sets the player's name.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the player's current health.
        /// </summary>
        public int Health { get; set; }

        /// <summary>
        /// Gets or sets the player's base attack power.
        /// </summary>
        public int AttackPower { get; set; }

        /// <summary>
        /// Gets or sets the player's current position in the maze as coordinates (x, y).
        /// </summary>
        public (int, int) Position { get; set; }

        public List<Weapon> inventory;

        /// <summary>
        /// Initializes a new instance of the <see cref="Player"/> class with a starting position.
        /// </summary>
        /// <param name="startX">The starting x-coordinate of the player in the maze.</param>
        /// <param name="startY">The starting y-coordinate of the player in the maze.</param>
        public Player(int startX, int startY)
        {
            Name = "Unnamed Player";
            Health = 100;
            AttackPower = 10;
            Position = (startX, startY);
            inventory = new List<Weapon>();
        }

        /// <summary>
        /// Moves the player in the specified direction if the move is valid within the maze.
        /// </summary>
        /// <param name="direction">The direction to move ("up", "down", "left", or "right").</param>
        /// <param name="maze">The maze the player is navigating.</param>
        public void Move(string direction, Maze maze)
        {
            var (x, y) = Position;
            switch (direction)
            {
                case "up":
                    if (maze.CanMoveTo(x - 1, y)) Position = (x - 1, y);
                    break;
                case "down":
                    if (maze.CanMoveTo(x + 1, y)) Position = (x + 1, y);
                    break;
                case "left":
                    if (maze.CanMoveTo(x, y - 1)) Position = (x, y - 1);
                    break;
                case "right":
                    if (maze.CanMoveTo(x, y + 1)) Position = (x, y + 1);
                    break;
            }
        }

        /// <summary>
        /// Attacks the specified target character using the player's best weapon or base attack power.
        /// </summary>
        /// <param name="target">The target character to attack.</param>
        public void Attack(ICharacter target)
        {
            int attackPower = GetBestWeapon()?.AttackModifier ?? AttackPower;
            target.TakeDamage(attackPower);
        }

        /// <summary>
        /// Reduces the player's health by the specified amount and checks if the player has died.
        /// </summary>
        /// <param name="Amount">The amount of damage to take.</param>
        public void TakeDamage(int Amount)
        {
            Health -= Amount;
            if (Health <= 0)
            {
                Console.WriteLine("You have died!");
                Environment.Exit(0);
            }
        }

        /// <summary>
        /// Picks up an item and adds it to the player's inventory if it is a weapon.
        /// </summary>
        /// <param name="item">The item to be picked up.</param>
        public void PickUp(Item item)
        {
            item.Use(this);
            if (item is Weapon weapon)
            {
                inventory.Add(weapon);
            }
        }

        /// <summary>
        /// Retrieves the best weapon in the player's inventory based on attack power.
        /// </summary>
        /// <returns>Returns the weapon with the highest attack modifier, or null if no weapons are available.</returns>
        public Weapon GetBestWeapon()
        {
            Weapon bestWeapon = null;
            foreach (var weapon in inventory)
            {
                if (bestWeapon == null || weapon.AttackModifier > bestWeapon.AttackModifier)
                {
                    bestWeapon = weapon;
                }
            }
            return bestWeapon;
        }
    }

}

