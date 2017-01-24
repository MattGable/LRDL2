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
        /// Declare the array of FloorTiles for the game floor.
        /// </summary>
        /// <remarks>
        /// TODO: Probably hide this behind a private visibility.
        /// </remarks>
        public FloorTile[,] map = new FloorTile[Configuration.MapWidth, Configuration.MapHeight];


        /// <summary>
        /// Creates a tile map of the specified dimensions.
        /// </summary>
        public TileMap ()
        {
            //Initialize the map for this TileMap.
            for (int width = 0; width < Configuration.MapWidth; width++)
            {
                for (int height = 0; height < Configuration.MapHeight; height++)
                {
                    map[width, height] = new FloorTile();
                }
            }
        }
    }
}
