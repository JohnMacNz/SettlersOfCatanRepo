/**
Settlers of Catan Game
Author: John R. McLaren
Student ID: 21500529
Date Created: 16/09/2017
Date Modified: 19/09/2017
**/

using System;
using System.Collections;

namespace SettlersOfCatanGame
{
    sealed class Board
    {
        static Board board;

        ArrayList players;
        ArrayList tiles;

        // grid variables
        ushort width; // how wide the board is
        ushort height; // how tall the board is
        int[,] tileExists; // 2D array representing tile or non tile

        public int CurrentPlayer { get; set; }

        // board constructor
        public Board()
        {
            players = new ArrayList();
            width = 9;
            height = 5;
            tileExists = new int[width, height];
        }

        //method to access singleton
        public static Board accessBoard()
        {
            if (board == null)
                board = new Board();
            return board;
        }

        public int getPlayerCount()
        {
            return players.Count;
        }

        public void getPlayerNames()
        {
            foreach(Player p in players)
            {
                Console.WriteLine(p.Name);
            }
        }

        public void addTiles()
        {

        }

        public void setupTileArray()
        {
            // binary matrix representing location of valid tile coordinates
            // populate array with 0 for no tile, 1 for tile

            // once locations tiles have been set, replace with Tile objects over 1's
            // can refer back to these coordinates to get tile details

            for(int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    if(x % 2 == 0) //if x is even
                    {
                        if(y % 2 == 0) // if y is even
                        {
                            // make all corners 0
                            if(x == 0 && y == 0)
                                tileExists[x, y] = 0;
                            else if (x == 8 && y == 0)
                                tileExists[x, y] = 0;
                            else if (x == 0 && y == 4)
                                tileExists[x, y] = 0;
                            else if(x == 8 && y == 4)
                                tileExists[x, y] = 0;
                            else
                                tileExists[x, y] = 1;
                        }
                    }
                    else if (x % 2 == 1) // if x is odd
                    {
                        if (y % 2 == 1) // if y is odd
                        {
                            tileExists[x, y] = 1;
                        }
                    }
                }
            }

            //showTileExistsArray();
        }

        //show array on console -- debugging purposes only
        void showTileExistsArray()
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Console.Write(tileExists[x, y]);
                    if (x == width - 1)
                        Console.WriteLine();
                }
            }
        }

        void designateBuildZones()
        {
            // binary matrix representing location of possible building sites
            // each tile contains 6 possible settlements, 6 possible roads
        }

        public bool addPlayer(Player player)
        {
            foreach (Player p in players)
            {
                if (p.Name == player.Name)
                {
                    Console.WriteLine($"Player with the name [{player.Name}] already exists.");
                    return false;
                }
            }
            players.Add(player);
            return true;
        }

        public Player getPlayer(int playerIndex)
        {
            return (Player)players[playerIndex];
        }
    }
}
