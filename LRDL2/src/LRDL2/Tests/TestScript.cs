using LRDL2.Tiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LRDL2.Tests
{
    public class TestScript
    {
        public static void Run ()
        {
            //Creating a FloorTile and printing its default symbol.
            FloorTile testFloorTile = new FloorTile();
            Console.WriteLine("FloorTile's symbol: " + testFloorTile.MySymbol);
        }
    }
}
