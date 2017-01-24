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
                Console.WriteLine("############################################################");

                Console.WriteLine("Please enter a choice from the above menu.");
                try
                {
                    string userChoice = Console.ReadLine();

                    if (userChoice.ToLower().Equals("start"))
                    {
                        Console.Clear();
                        Console.WriteLine("You picked start.");
                    }
                    else if (userChoice.ToLower().Equals("random"))
                    {
                        Console.Clear();
                        Console.WriteLine("You picked random.");
                    }
                    else if (userChoice.ToLower().Equals("save"))
                    {
                        Console.Clear();
                        Console.WriteLine("You picked save.");
                    }
                    else if (userChoice.ToLower().Equals("test"))
                    {
                        Console.Clear();
                        Console.WriteLine("You picked test.");
                        TestScript.Run();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid argument. Please try again.");
                    }
                }
                catch (Exception e)
                {
                    Console.Clear();
                    Console.Error.WriteLine(e);
                }


            }
        }

    }
}
