using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_BasedAdventure
{
    /// <summary>
    /// Represents a maze where the player navigates through tiles, encounters monsters, and finds items.
    /// </summary>
    public class Maze
    {  
        public Tile[,] grid;
        public int width;
        public int height;
        public (int, int) exitPosition;
        public List<Item> Items { get; private set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="Maze"/> class with the specified width and height.
        /// </summary>
        /// <param name="width">The width of the maze in tiles.</param>
        /// <param name="height">The height of the maze in tiles.</param>
        public Maze(int width, int height)
        {
            this.width = width;
            this.height = height;
            grid = new Tile[width, height];
            Items = new List<Item>();
        }

        /// <summary>
        /// Generates a random maze by placing walls, monsters, and items.
        /// </summary>
        public void GenerateMaze()
        {
            Random rand = new Random();
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    grid[i, j] = new Tile();
                    if (rand.Next(100) < 20) grid[i, j].IsWall = true;
                    else if (rand.Next(100) < 10) grid[i, j].PlaceMonster(new Monster());
                    else if (rand.Next(100) < 10)
                        // You need to provide the image URL when creating a new Weapon
                        grid[i, j].PlaceItem(new Weapon("Sword", 5, "path-to-sword-image.jpg"));
                    else if (rand.Next(100) < 5)
                        // You need to provide the image URL when creating a new Potion
                        grid[i, j].PlaceItem(new Potion("Health Potion", 20, "path-to-potion-image.jpg"));
                }
            }
            // Sets a random exit position in the maze.
            exitPosition = (rand.Next(width), rand.Next(height));
            grid[exitPosition.Item1, exitPosition.Item2].IsExit = true;
        }

        /// <summary>
        /// Displays the current state of the maze to the console, indicating the player's position, walls, monsters, items, and the exit.
        /// </summary>
        /// <param name="player">The player currently navigating the maze.</param>
        public void DisplayMaze(Player player)
        {
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (player.Position == (i, j))
                    {
                        Console.Write("P ");
                    }
                    else if (grid[i, j].IsWall)
                    {
                        Console.Write("# ");
                    }
                    else if (grid[i, j].HasMonster)
                    {
                        Console.Write("M ");
                    }
                    else if (grid[i, j].HasItem)
                    {
                        Console.Write("I ");
                    }
                    else if (grid[i, j].IsExit)
                    {
                        Console.Write("E ");
                    }
                    else
                    {
                        Console.Write("_ ");
                    }
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Checks if the player can move to the specified coordinates within the maze.
        /// </summary>
        /// <param name="x">The x-coordinate in the maze.</param>
        /// <param name="y">The y-coordinate in the maze.</param>
        /// <returns>Returns true if the position is valid and not a wall, otherwise false.</returns>
        public bool CanMoveTo(int x, int y)
        {
            if (x < 0 || y < 0 || x >= width || y >= height) return false;
            return !grid[x, y].IsWall;
        }

        /// <summary>
        /// Checks the player's current position for interactions such as encountering a monster or picking up an item.
        /// </summary>
        /// <param name="player">The player navigating the maze.</param>
        public void CheckForInteractions(Player player)
        {
            var (x, y) = player.Position;
            if (grid[x, y].HasMonster)
            {
                Battle(player, grid[x, y].Monster);
            }
            else if (grid[x, y].HasItem)
            {
                player.PickUp(grid[x, y].Item);
                grid[x, y].RemoveItem();
            }
        }

        /// <summary>
        /// Checks if the player has reached the exit position.
        /// </summary>
        /// <param name="player">The player navigating the maze.</param>
        /// <returns>Returns true if the player is at the exit, otherwise false.</returns>
        public bool CheckForExit(Player player)
        {
            return player.Position == exitPosition;
        }

        /// <summary>
        /// Simulates a battle between the player and a monster until one is defeated.
        /// </summary>
        /// <param name="player">The player in the battle.</param>
        /// <param name="monster">The monster the player is battling.</param>
        public void Battle(Player player, Monster monster)
        {
            while (player.Health > 0 && monster.Health > 0)
            {
                player.Attack(monster);
                if (monster.Health > 0)
                {
                    monster.Attack(player);
                }
            }
        }
    }
}
