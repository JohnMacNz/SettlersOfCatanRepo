/**
Settlers of Catan Game
Author: John R. McLaren
Student ID: 21500529
Date Created: 16/09/2017
Date Modified: 16/09/2017
**/

namespace SettlersOfCatanGame
{
    class Board
    {
        static Board board;

        //method to access singleton
        public static Board accessBoard()
        {
            if (board == null)
                board = new Board();
            return board;
        }
    }
}
