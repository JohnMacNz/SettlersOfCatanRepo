/**
Settlers of Catan Game
Author: John R. McLaren
Student ID: 21500529
Date Created: 16/09/2017
Date Modified: 16/09/2017
**/
using System;

namespace SettlersOfCatanGame 
{
    public class SettlersOfCatan : Game
    {
        public override void initialiseGame()
        {
            displayIntro();
            displayStartMenu();
        }
        // some flavor for when the user first starts application
        void displayIntro()
        {
            Console.WriteLine("\t\t\t\t===================Settlers of Catan===================\n");
            Console.WriteLine("\t\t\t\t\t\tCreated by John R. McLaren\n");
            Console.WriteLine("\t\t\t\t=======================================================\n\n\n\n");
            Console.WriteLine("\t\t\t\t\t\tPress any key to continue...");
            Console.ReadLine();
            Console.Clear();
        }
        // After intro game prompts user to either start load or quit game
        void displayStartMenu()
        {
            int response = 0;

            Console.WriteLine("\t\t\t\t========================================");
            Console.WriteLine("\t\t\t\tChoose an Option:\n");
            Console.WriteLine("\t\t\t\t---------------------------------------");
            Console.WriteLine("\t\t\t\t1. Start New Game");
            Console.WriteLine("\t\t\t\t2. Load Game");
            Console.WriteLine("\t\t\t\t3. Quit Game");
            Console.WriteLine("\t\t\t\t========================================");
            Console.Write("\t\t\t\t(1-3): ");

            try
            {
                response = int.Parse(Console.ReadLine());

                switch (response)
                {
                    case 1:
                        startGame();
                        break;
                    case 2:
                        loadGame();
                        break;
                    case 3:
                        quitGame();
                        break;
                    default:
                        Console.WriteLine("Invalid Input. Input a number between 1 and 3.\n");
                        displayStartMenu();
                        break;
                }
            }
            catch(ApplicationException e)
            {
                Console.WriteLine(e);
            }

        }
        // Create a new Settlers Game with board, players
        void startGame()
        {
            setupGame();
        }

        void setupGame()
        {
            // Create the board
            // Create the players
            setupPlayers();
        }
        void setupPlayers()
        {
            //Add players to the board
            Console.WriteLine("-----------------------------");
            Console.WriteLine("How many players are playing?");
            Console.Write("(3-4):");
            int playerCount = inputInteger();

            //if it is out of range then display msg and redo this method
            if ((playerCount < 3) || (playerCount > 4))
            {
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine(">>>>>>>>>>That is an invalid amount. Please try again.<<<<<<<<<<");
                setupPlayers();
            }

            //Ask for players names
            for (int i = 0; i < playerCount; i++)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Please enter the name for Player {0}:", i + 1);
                Console.Write("==>");
                string playerName = Console.ReadLine();
                Player player = new Player(playerName);
                //subscribe to events
                player.playerBankrupt += playerBankruptHandler;
                player.playerPassGo += playerPassGoHandler;
                player.playerLandOnChance += playerLandOnChanceHandler;
                player.playerGoJail += playerGoJailHandler;

                //add player 
                Board.access().addPlayer(player);
                Console.WriteLine("{0} has been added to the game.", Board.access().getPlayer(i).getName());
            }
        }

        void setupBoard()
        {
            // The board consists of 19 Land
            // 9 Ocean 9 Harbor Surrounds it
            // 2D Array/Generic to hold the tiles
        }

        void displayBoard()
        {

        }

        public int inputInteger() // 0 is invalid input
        {
            try
            {
                return int.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine(e);
                Console.WriteLine(">>>>>>>>>>Please enter a number such as 1 or 2. Please try again.<<<<<<<<<<");
                return 0;
            }
        }
        // specifies a file path and tries to load save game file
        void loadGame()
        {

        }
        //exit the game
        void quitGame()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t\t=========================================");
            Console.WriteLine("\t\t\t\t\t\tThanks for Playing!");
            Console.WriteLine("\t\t\t\t=========================================");
            Console.ReadLine();
            Environment.Exit(0);
        }
    }
}
