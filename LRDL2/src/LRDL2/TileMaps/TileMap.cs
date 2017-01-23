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
        private int _mapWidth;
        private int _mapHeight;

        //The array holding the Tiles.
        FloorTile[,] _map;

        /// <summary>
        /// Creates a tile map of the specified dimensions.
        /// </summary>
        /// <param name="mapWidth">Width of the map to be created.</param>
        /// <param name="mapHeight">Height of the map to be created.</param>
        public TileMap (int mapWidth, int mapHeight)
        {
            //Initialize the dimensions of the TileMap.
            _mapWidth = mapWidth;
            _mapHeight = mapHeight;

            //Initialize the map for this TileMap.
            _map = new FloorTile[_mapWidth, _mapHeight];
        }
    }
}
