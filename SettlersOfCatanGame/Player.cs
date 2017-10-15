/**
Settlers of Catan Game
Author: John R. McLaren
Student ID: 21500529
Date Created: 16/09/2017
Date Modified: 15/10/2017
**/
using System.Collections;

namespace SettlersOfCatanGame
{
    class Player
    {
        private string playerName;
        private int victoryPoints;
        private int playerRoll;
        private bool turnToPlay;

        ArrayList cards;
        ArrayList buildings;

        Dice dice1 = new Dice();
        Dice dice2 = new Dice();

        public int Food { get; set; }
        public int Wool { get; set; }
        public int Wood { get; set; }
        public int Bricks { get; set; }
        public int Ore { get; set; }

        public string Name { get; }

        public int NumLastRolled
        {
            get
            {
                return playerRoll;
            }
            set
            {
                playerRoll = value;
            }
        }

        public Player(string name)
        {
            Name = name;
        }

        public int RollDice()
        {
            return dice1.Roll() + dice2.Roll();
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
