using LRDL2.Start;
using LRDL2.Tiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/// <summary>
/// Holds various TileMap objects.
/// </summary>
namespace LRDL2.TileMaps
{
    /// <summary>
    /// A 2D map holding floor tiles. 
    /// </summary>
    public class TileMap
    {
        /// <summary>
        /// Creates the floor tiles for the engine.
        /// </summary>
        /// 
        public Tile[,] Map { get; set; }

        /// <summary>
        /// Creates a tile map of the specified dimensions.
        /// </summary>
        public TileMap ()
        {
            //Initialize "blank" floor of tiles of the preset dimensions.
            Map = new Tile[Configuration.MapWidth, Configuration.MapHeight];

            //Instantiate each Tile for this TileMap with a FloorTile as default.
            for (int width = 0; width < Configuration.MapWidth; width++)
            {
                for (int height = 0; height < Configuration.MapHeight; height++)
                {
                    Map[width, height] = new FloorTile();
                }
            }
        }

        /// <summary>
        /// Prints the contents of Map directly to console.
        /// </summary>
        /// <remarks>
        /// TODO: Consider moving this to a view.
        /// </remarks>
        public void printMap ()
        {
            //Manually printing the TileMap
            for (int height = 0; height < Configuration.MapHeight - 1; height++)
            {
                for (int width = 0; width < Configuration.MapWidth - 1; width++)
                {
                    Console.Write(Map[width, height].MySymbol);

                    if (width == Configuration.MapWidth - 2)
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
