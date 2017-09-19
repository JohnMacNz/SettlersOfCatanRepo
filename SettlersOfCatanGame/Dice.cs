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
    class Dice
    {
        private static Random randomNumber = new Random();
        private int numberRolled;

        public int Number { get; set; }


        public int roll()
        {
            numberRolled = randomNumber.Next(1, 7); // from 1 to 6
            Number = numberRolled;
            return numberRolled;
            
        }
    }
}
