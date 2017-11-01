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
    // this class contains objects and logic associated with the game board
    sealed class Board
    {
        const ushort width = 9; // how wide the board is
        const ushort height = 5; // how tall the board is
        int[,] tileExists = new int[width, height]; // 2D array representing tile or non tile

        static Board board;
        TileCollection<Land> landArray = new TileCollection<Land>(19); // generics
        TileCollection<Water> waterArray = new TileCollection<Water>(18); // generics
        // use factories to populate the arrays

        //method to access singleton
        public static Board Access()
        {
            if (board == null)
                board = new Board();
            return board;
        }

        public void SetUpTileArray()
        {
            // binary matrix representing location of valid tile coordinates
            // populate array with 0 for no tile, 1 for tile

            // once locations tiles have been set, replace with Tile objects over 1's
            // can refer back to these coordinates to get tile details

            // used for graphical representation of tiles

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    if (x % 2 == 0) //if x is even
                    {
                        if (y % 2 == 0) // if y is even
                        {
                            // make all corners 0
                            if (x == 0 && y == 0)
                                tileExists[x, y] = 0;
                            else if (x == 8 && y == 0)
                                tileExists[x, y] = 0;
                            else if (x == 0 && y == 4)
                                tileExists[x, y] = 0;
                            else if (x == 8 && y == 4)
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
        void ShowTileExistsArray()
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

    }
}
