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
                Console.WriteLine("#                      \u0489--- LRDL2 ---\u0489                      #");
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
                Console.WriteLine("#                                                          #");
                Console.WriteLine("#                                                          #");
                Console.WriteLine("############################################################");

                Console.WriteLine("Please enter a choice from the above menu.");
                try
                {
                    string userChoice = Console.ReadLine();

                    if (userChoice.ToLower().Equals("start"))
                    {
                        Console.WriteLine("You picked sart.");
                    }
                    else if (userChoice.ToLower().Equals("random"))
                    {
                        Console.WriteLine("You picked random.");
                    }
                    else if (userChoice.ToLower().Equals("save"))
                    {
                        Console.WriteLine("You picked save.");
                    }
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(e);
                }

                Console.Clear();
            }
        }

    }
}
