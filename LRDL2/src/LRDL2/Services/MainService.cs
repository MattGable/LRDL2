using LRDL2.Players;
using LRDL2.Start;
using LRDL2.TileMaps;
using LRDL2.ViewModels;
using LRDL2.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LRDL2.Services
{
    /// <summary>
    /// Holds the instantiation logic for map layers and other engine necessities.
    /// </summary>
    public class MainService
    {
        public TileMap ServiceTileBaseMap { get; set; }
        public Player ServicePlayer { get; set; }
        public MainMapViewModel ServiceMainMapViewModel { get; set; }
        public MainMapView ServiceMainMapView { get; set; }

        public MainService ()
        {
            ServiceTileBaseMap = new TileMap();
            ServicePlayer = new Player(Configuration.PlayerStartX, Configuration.PlayerStartY);
            ServiceMainMapViewModel = new MainMapViewModel(ServiceTileBaseMap, ServicePlayer);
            ServiceMainMapView = new MainMapView(ServiceMainMapViewModel);
        }
    }
}
