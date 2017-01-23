using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LRDL2.TileMaps
{
    public class TileMap
    {
        private int _mapWidth;
        private int _mapHeight;

        //private Tile _myTile;
        //Tile[,] _map;

        public TileMap (int MapWidth, int MapHeight)
        {
            _mapWidth = MapWidth;
            _mapHeight = MapHeight;
        }
    }
}
