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
        //The dimensions of the TileMap;
        private int mapWidth;
        private int mapHeight;

        //The array holding the Tiles.
        FloorTile[,] map;

        /// <summary>
        /// Creates a tile map of the specified dimensions.
        /// </summary>
        /// <param name="mapWidthInput">Width of the map to be created.</param>
        /// <param name="mapHeightInput">Height of the map to be created.</param>
        public TileMap (int mapWidthInput, int mapHeightInput)
        {
            //Initialize the dimensions of the TileMap.
            mapWidth = mapWidthInput;
            mapHeight = mapHeightInput;

            //Initialize the map for this TileMap.
            map = new FloorTile[mapWidth, mapHeight];
        }
    }
}
