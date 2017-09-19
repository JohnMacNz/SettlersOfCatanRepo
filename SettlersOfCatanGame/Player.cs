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
        int victoryPoints;

        ArrayList resources;
        ArrayList cards;
        ArrayList buildings;

        Dice dice1 = new Dice();
        Dice dice2 = new Dice();

        public string Name { get; set; }

        public Player(string name)
        {
            Name = name;
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
