/**
Settlers of Catan Game
Author: John R. McLaren
Student ID: 21500529
Date Created: 16/09/2017
Date Modified: 16/09/2017
**/
using System.Collections;

namespace SettlersOfCatanGame
{
    class Player
    {
        string playerName;
        bool isActive = false;

        ArrayList cards;
        ArrayList buildings;

        Dice dice1 = new Dice();
        Dice dice2 = new Dice();

        public Player(string name)
        {
            playerName = name;
        }

        // property to check if its a player's turn
        public bool IsActive
        {
            get
            {
                return isActive;
            }
            set
            {
                isActive = value;
            }
        }

        public ArrayList Cards
        {
            get
            {
                return cards;
            }
            set
            {
                // add a new card to list
            }
        }

        public ArrayList Buildings
        {
            get
            {
                return buildings;
            }
            set
            {
                // add new building to list
            }
        }

    }
}
