using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LRDL2.Tiles
{
    public abstract class Tile
    {
        public char MySymbol { get; set; }
        public ConsoleColor MyColor { get; set; }
    }
}
