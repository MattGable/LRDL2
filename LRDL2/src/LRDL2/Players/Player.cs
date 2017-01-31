using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LRDL2.Players
{
    public class Player
    {
        public int MyX { get; set; }
        public int MyY { get; set; }

        public Player (int startingX, int startingY)
        {
            //Tesst starting values
            MyX = startingX;
            MyY = startingY;
        }
    }
}
