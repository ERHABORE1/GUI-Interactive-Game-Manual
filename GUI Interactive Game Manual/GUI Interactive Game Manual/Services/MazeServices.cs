using Text_BasedAdventure;
namespace GUIInteractiveGameManual.Services
{
    /// <summary>
    /// Provides services for managing the Maze, including Players, Monsters, and Items.
    /// </summary>
    public class MazeServices : IMazeServices
    {
        /// <summary>
        /// Gets or sets the Maze object, representing the grid structure of the maze.
        /// </summary>
        public Maze Maze { get; set; }

        /// <summary>
        /// Gets or sets the list of players in the game.
        /// </summary>
        public List<Player> Players { get; set; }

        /// <summary>
        /// Gets or sets the list of monsters present in the maze.
        /// </summary>
        public List<Monster> Monsters { get; set; }

        /// <summary>
        /// Gets or sets the list of items (weapons, potions, etc.) available in the game.
        /// </summary>
        public List<Item> Items { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MazeServices"/> class, 
        /// generating a 10x10 maze and populating it with items, players, and monsters.
        /// </summary>
        public MazeServices()
        {
            // Initializes a 10x10 maze.
            Maze = new Maze(10, 10);

            // Adds predefined items (weapons and potions) to the maze.
            Items = new List<Item>
        {
            new Weapon("Sword of Destiny", 10, "path-to-sword-image.jpg"),
            new Potion("Mega Health Potion", 50, "path-to-mega-potion-image.jpg")
        };

            // Generates the maze layout.
            Maze.GenerateMaze();

            // Adds a default player to the maze.
            Players = new List<Player>
        {
            new Player(0, 0) { Name = "Hero", Health = 100, AttackPower = 20 }
        };

            // Adds a default monster to the maze.
            Monsters = new List<Monster>
        {
            new Monster(50, 10) { Name = "Goblin", Health = 50, AttackPower = 10 }
        };
        }
    }
}
