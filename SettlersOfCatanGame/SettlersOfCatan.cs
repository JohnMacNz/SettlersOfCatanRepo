﻿/**
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
        int playerCount;

        public override void initialiseGame()
        {
            DisplayIntro();
            DisplayStartMenu();
        }
        // some flavor for when the user first starts application
        void DisplayIntro()
        {
            Console.WriteLine("\t\t\t\t===================Settlers of Catan===================\n");
            Console.WriteLine("\t\t\t\t\t\tCreated by John R. McLaren\n");
            Console.WriteLine("\t\t\t\t=======================================================\n\n\n\n");
            Console.WriteLine("\t\t\t\t\t\tPress any key to continue...");
            Console.ReadKey();
        }

        void DisplayPlayerMenu()
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
        }

        // After intro game prompts user to either start load or quit game
        void DisplayStartMenu()
        {
            
            int response = 0;
            bool moveOn = false;
            while (!moveOn)
            {
                Console.Clear();
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
                            moveOn = true;
                            CreateNewGame();
                            break;
                        case 2:
                            moveOn = true;
                            LoadGame();
                            break;
                        case 3:
                            moveOn = true;
                            QuitGame();
                            break;
                        default:
                            Console.WriteLine("Invalid Input. Input a number between 1 and 3.\n");
                            Console.ReadKey();
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Must be a number between 1-3.");
                }
                catch (ApplicationException e)
                {
                    Console.WriteLine(e);
                }
            }
            
        }

        // Create a new Settlers Game with board, players
        void CreateNewGame()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t\t==================================================");
            Console.WriteLine("\t\t\t\t\t\tCreate New Game");
            SetUpPlayers();
            SetUpBoard();
            StartGame();
            Console.ReadKey();
        }


        void StartGame()
        {
            Console.Clear();
            RollDiceForAllPlayers();
            SortPlayerRolls();
            // set up the board
            // 



        }

        void RollDiceForAllPlayers()
        {
            // dice roll begins
            for (int i = 0; i < Settings.Access().GetPlayerCount(); i++)
            {
                Player player = Settings.Access().GetPlayer(i);
                player.NumLastRolled = player.RollDice();
                Console.WriteLine("{0} rolled: {1}", player.Name, player.NumLastRolled);
            }
        }

        void SortPlayerRolls()
        {
            // sort player rolls into an array
            int[] playerRolls = new int[playerCount];
            for (int i = 0; i < Settings.Access().GetPlayerCount(); i++)
            {
                Player player = Settings.Access().GetPlayer(i);
                playerRolls[i] = player.NumLastRolled;
            }
            Array.Sort(playerRolls);

            // last number is who starts
            foreach (Player p in Settings.Access().GetPlayers())
            {
                if(playerRolls[playerRolls.Length - 1] == p.NumLastRolled)
                    Console.WriteLine("\n{0} Starts!", p.Name);
            }
            Console.WriteLine("Press Any Key To Continue...");
            Console.ReadKey();
        }

        void SetUpBoard()
        {
        }

        void SetUpPlayers()
        {
            try
            {
                //Add players to the board
                Console.WriteLine("\t\t\t\t---------------------------------------------------");
                Console.WriteLine("\t\t\t\tHow many players are playing?");
                Console.Write("\t\t\t\t(3-4):");
                playerCount = InputInteger();

                //if it is out of range then display msg and redo this method
                if ((playerCount < 3) || (playerCount > 4))
                {
                    Console.WriteLine("\t\t\t\t----------------------------------------------------------------");
                    Console.WriteLine("\t\t\t\tThat is an invalid amount. Please try again.");
                    SetUpPlayers();
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
                    if (Settings.Access().AddPlayer(player) == true)
                    {
                        Console.WriteLine("{0} has been added to the game.", Settings.Access().GetPlayer(i).Name);
                    }

                    else// redo 
                        i--;
                }

            }
            catch (FormatException)
            {
                Console.WriteLine();
            }
        }

        public int InputInteger() // 0 is invalid input
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
        void LoadGame()
        {

        }
        //exit the game
        void QuitGame()
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
