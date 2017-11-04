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
    // this class contains objects and methods associated with the game board
    sealed class Board
    {
        static Board board;

        public void PopulateBoard()
        {
            // create a new collection of land tiles
            TileCollection landTiles = new TileCollection();
            landTiles[0] = new Land("forest", "wood", 7, 1);
        }

        //method to access singleton
        public static Board Access()
        {
            if (board == null)
                board = new Board();
            return board;
        }

    }
}
