﻿using LRDL2.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LRDL2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Start.Configuration.ApplyStartingSettings();
            MainMenu.WriteMenu();
        }
    }
}
