using LRDL2.Start;
using LRDL2.TileMaps;
using LRDL2.Tiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LRDL2.Tests
{
    /// <summary>
    /// A container for testing modules.
    /// </summary>
    public class TestScript
    {
        /// <summary>
        /// Creates test objects (Tile, TileMap) and displays them for testing.
        /// </summary>
        public static void Run ()
        {
            Console.Clear();

            //Creating a FloorTile and printing its default symbol.
            FloorTile testFloorTile = new FloorTile();
            Console.WriteLine("FloorTile's symbol: " + testFloorTile.MySymbol);

            //Creating a TileMap of FloorTiles.
            TileMap testTileMap = new TileMap();

            //Printing a tile from testTileMap.
            Console.WriteLine("Symbol of Map[1,1]'s FloorTile: " + testTileMap.Map[1, 1].MySymbol);

            //Print the entire Map.
            testTileMap.PrintMap();

            //Manually adding a few WallTiles.
            testTileMap.Map[10, 10] = new WallTile();

            testTileMap.PrintMap();
        }
    }
}
