using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LRDL2.Players
{
    public class Player
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char MySymbol { get; set; }

        public Player (int startingX, int startingY)
        {
            //Test starting values
            MySymbol = '@';
            X = startingX;
            Y = startingY;
        }
    }
}
