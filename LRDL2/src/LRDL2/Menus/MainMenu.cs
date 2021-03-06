﻿using LRDL2.Controllers;
using LRDL2.Services;
using LRDL2.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LRDL2.Menu
{
    public static class MainMenu
    {
       public static void WriteMenu ()
       {
            while (true)
            {
                Console.WriteLine("############################################################");
                Console.WriteLine("#                      \u00A4--- LRDL2 ---\u00A4                     #");
                Console.WriteLine("#                                                          #");
                Console.WriteLine("# 'start' starts a new game                                #");
                Console.WriteLine("#                                                          #");
                Console.WriteLine("# 'random' generates a random decimal number.              #");
                Console.WriteLine("#                                                          #");
                Console.WriteLine("# 'save' writes the content of your workspace.             #");
                Console.WriteLine("#                                                          #");
                Console.WriteLine("#                                                          #");
                Console.WriteLine("#                                                          #");
                Console.WriteLine("#                                                          #");
                Console.WriteLine("#                                                          #");
                Console.WriteLine("# 'test' runs the current test script.                     #");
                Console.WriteLine("#                                                          #");
                Console.WriteLine("# 'exit' closes LRDL2.                                     #");
                Console.WriteLine("#                                                          #");
                Console.WriteLine("############################################################");

                Console.WriteLine("Please enter a choice from the above menu.");

                try
                {
                    string userChoice = Console.ReadLine();

                    Console.Clear();

                    if (userChoice.ToLower().Equals("start"))
                    {
                        Console.WriteLine("You picked start.");

                        //TODO: For now, this is implemented here.
                        //Create the services needed
                        MainService MyServices = new MainService();
                        MainMapController MyController = new MainMapController(MyServices);
                        MyController.ControllerService.ServiceMainMapView.Render();
                    }
                    else if (userChoice.ToLower().Equals("random"))
                    {
                        Console.WriteLine("You picked random.");
                    }
                    else if (userChoice.ToLower().Equals("save"))
                    {
                        Console.WriteLine("You picked save.");
                    }
                    else if (userChoice.ToLower().Equals("test"))
                    {
                        Console.WriteLine("You picked test.");
                        TestScript.Run();
                    }
                    else if (userChoice.ToLower().Equals("exit"))
                    {
                        Console.WriteLine("You picked exit.");
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Invalid argument. Please try again.");
                    }
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(e);
                }
            }
        }
    }
}
