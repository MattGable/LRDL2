using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LRDL2.Tiles
{
    public class WallTile : Tile
    {
        public WallTile()
        {
            MySymbol = '#';
            MyColor = ConsoleColor.Gray;
        }
    }
}
