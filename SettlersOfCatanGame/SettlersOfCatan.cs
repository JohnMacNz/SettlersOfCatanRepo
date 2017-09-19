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
        string playerName;
        int turn;
        public override void initialiseGame()
        {
            turn = 1;
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
            Console.ReadKey();
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
                        createNewGame();
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
            catch(FormatException)
            {
                Console.WriteLine("Must be a number between 1-3.");
            }
            catch(ApplicationException e)
            {
                Console.WriteLine(e);
            }
        }

        // Create a new Settlers Game with board, players
        void createNewGame()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t\t==================================================");
            Console.WriteLine("\t\t\t\t\t\tCreate New Game");
            setUpPlayers();
            setUpBoard();
            Console.Read();
            //startGame();
        }

        void startGame()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t\tSettlers of Catan is a game about resource management.");
            Console.WriteLine("\t\t\t\tThe goal is to be the first player to reach 10 victory points.");
            Console.WriteLine("\t\t\t\tGood luck!\n\n\n");
            Console.WriteLine("\t\t\t\t\t\tPress any key to continue...");
            Console.ReadKey();

            // each player rolls dice, whoever gets highest starts

            for (int i = 0; i < Board.accessBoard().getPlayerCount(); i++)
            {
                Console.Clear();
                
            }
        }

        void displayTurn()
        {
            Console.WriteLine("Turn {0}", turn);
        }

        void beginPlayerTurn(int playerIndex)
        {
            Board.accessBoard().CurrentPlayer = playerIndex;

            Player player = Board.accessBoard().getPlayer(playerIndex);



        }

        void beginPhaseOne()
        {

        }
        void beginPhaseTwo()
        {

        }
        void beginPhaseThree()
        {

        }

        void setUpBoard()
        {
            Board.accessBoard().setupTileArray();
        }

        void setUpPlayers()
        {
            //Add players to the board
            Console.WriteLine("\t\t\t\t---------------------------------------------------");
            Console.WriteLine("\t\t\t\tHow many players are playing?");
            Console.Write("\t\t\t\t(3-4):");
            int playerCount = inputInteger();

            //if it is out of range then display msg and redo this method
            if ((playerCount < 3) || (playerCount > 4))
            {
                Console.WriteLine("\t\t\t\t----------------------------------------------------------------");
                Console.WriteLine("\t\t\t\tThat is an invalid amount. Please try again.");
                setUpPlayers();
            }

            //Ask for players names
            for (int i = 0; i < playerCount; i++)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Please enter the name for Player {0}:", i + 1);
                Console.Write("==>");
                playerName = Console.ReadLine();
                Player player = new Player(playerName);

                //add player 
                if (Board.accessBoard().addPlayer(player) == true)
                    Console.WriteLine("{0} has been added to the game.", Board.accessBoard().getPlayer(i).Name);
                else
                    i--;
            }
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
            Console.WriteLine("\t\t\t\t\t   Thanks for Playing!");
            Console.WriteLine("\t\t\t\t=========================================");
            Console.ReadLine();
            Environment.Exit(0);
        }
    }
}
