﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LRDL2.Start
{
    public static class Configuration
    {
        /// <summary>
        /// Global constants for universal attributes, such as map dimensions.
        /// </summary>
        public static int MapWidth = 80;
        public static int MapHeight = 30;
        public static int PlayerStartX = 10;
        public static int PlayerStartY = 10;
        /// <summary>
        /// Applies necessary encodings.
        /// </summary>
        /// <remarks>
        /// More settings planned, such as console resizing and default coloring.
        /// </remarks>
        public static void ApplyStartingSettings ()
        {
            Console.OutputEncoding = Encoding.UTF8;
        }
    }
}
