using LRDL2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LRDL2.Controllers
{
    public class MainMapController
    {
        public MainService ControllerService { get; set; }

        public MainMapController (MainService inputMainService)
        {
            ControllerService = inputMainService;
        }
    }
}
