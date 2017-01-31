using LRDL2.Players;
using LRDL2.Start;
using LRDL2.TileMaps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LRDL2.ViewModels
{
    /// <summary>
    /// Assembles the player and map layers into a single viewable layer.
    /// </summary>
    public class MainMapViewModel : ViewModel
    {
        private TileMap baseMap;
        private Player player;
        public TileMap ModelMap { get; set; }

        public MainMapViewModel(TileMap inputBaseMap, Player inputPlayer)
        {
            baseMap = inputBaseMap;
            player = inputPlayer;
            //Best place to initialize?
            ModelMap = new TileMap();
        }

        public void CreateModel ()
        {
            //Iterating over the base map
            for (int height = 0; height < Configuration.MapHeight - 1; height++)
            {
                for (int width = 0; width < Configuration.MapWidth - 1; width++)
                {
                    //Fill the model's map with the contents of the input base map.
                    ModelMap.Map[width, height] = baseMap.Map[width, height];
                }
            }
        }
    }
}
