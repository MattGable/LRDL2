using LRDL2.ViewModels;
using LRDL2.Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LRDL2.Views
{
    public class MainMapView : View
    {
        MainMapViewModel myMainMapView;

        public MainMapView (MainMapViewModel inputMainMapViewModel)
        {
            myMainMapView = inputMainMapViewModel;
        }

        public void Render ()
        {
            //TODO: For testing only. 
            Console.WriteLine("WRITING FROM VIEW!");
            //Manually printing the TileMap
            for (int height = 0; height < Configuration.MapHeight - 1; height++)
            {
                for (int width = 0; width < Configuration.MapWidth - 1; width++)
                {

                    Console.ForegroundColor = myMainMapView.ModelMap.Map[width, height].MyColor;
                    Console.Write(myMainMapView.ModelMap.Map[width, height].MySymbol);

                    if (width == Configuration.MapWidth - 2)
                    {
                        Console.WriteLine();
                    }
                }
            }
            //TODO: Keep as bright white?
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
