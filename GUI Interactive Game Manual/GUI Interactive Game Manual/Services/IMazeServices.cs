using Text_BasedAdventure;
namespace GUIInteractiveGameManual.Services
{
    /// <summary>
    /// Interface for managing the services related to the Maze in the game, 
    /// including Players, Monsters, and Items.
    /// </summary>
    public interface IMazeServices
    {
        /// <summary>
        /// Gets or sets the Maze object, which represents the game's maze layout and properties.
        /// </summary>
        Maze Maze { get; set; }

        /// <summary>
        /// Gets or sets the list of Player characters in the game.
        /// </summary>
        List<Player> Players { get; set; }

        /// <summary>
        /// Gets or sets the list of Monsters that the player encounters in the maze.
        /// </summary>
        List<Monster> Monsters { get; set; }

        /// <summary>
        /// Gets or sets the list of Items (such as weapons and potions) available in the game.
        /// </summary>
        List<Item> Items { get; set; }
    }

}
