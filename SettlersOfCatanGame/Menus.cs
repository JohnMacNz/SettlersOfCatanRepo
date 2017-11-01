using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettlersOfCatanGame
{
    class Menus
    {
        // some flavor for when the user first starts application
        internal void DisplayIntro()
        {
            Console.WriteLine("\t\t\t\t===================Settlers of Catan===================\n");
            Console.WriteLine("\t\t\t\t\t\tCreated by John R. McLaren\n");
            Console.WriteLine("\t\t\t\t=======================================================\n\n\n\n");
            Console.WriteLine("\t\t\t\t\t\tPress any key to continue...");
            Console.ReadKey();
        }

        internal void DisplayPlayerMenu()
        {
            Console.Clear();
            // get the player
            // display their roll this turn
            // display their resource pool
            Console.WriteLine("========================================");
            Console.WriteLine("Choose an Option:\n");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("1. Build Road");
            Console.WriteLine("2. Build Settlements");
            Console.WriteLine("3. Trade");
            Console.WriteLine("4. See Roads");
            Console.WriteLine("5. See Settlements");
            Console.WriteLine("6. End Turn");
            Console.WriteLine("========================================");
            Console.Write("(1-3): ");
            Console.ReadKey();
            // handle user input
        }

        //exit the game
        internal void QuitGame()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t\t=========================================");
            Console.WriteLine("\t\t\t\t\t   Thanks for Playing!");
            Console.WriteLine("\t\t\t\t=========================================");
            Console.ReadLine();
            Environment.Exit(0);
        }
    }
}
