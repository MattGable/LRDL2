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
        public FloorTile[,] Map { get; set; }

        /// <summary>
        /// Creates a tile map of the specified dimensions.
        /// </summary>
        public TileMap ()
        {
            //Initialize "blank" floor of tiles of the preset dimensions.
            Map = new FloorTile[Configuration.MapWidth, Configuration.MapHeight];

            //Instantiate each Tile for this TileMap.
            for (int width = 0; width < Configuration.MapWidth; width++)
            {
                for (int height = 0; height < Configuration.MapHeight; height++)
                {
                    Map[width, height] = new FloorTile();
                }
            }
        }
    }
}
