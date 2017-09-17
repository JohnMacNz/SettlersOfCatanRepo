/**
Settlers of Catan Game
Author: John R. McLaren
Student ID: 21500529
Date Created: 16/09/2017
Date Modified: 16/09/2017
**/

namespace SettlersOfCatanGame
{
    public abstract class Card
    {
        public abstract string Type
        {
            get;
            set;
        }
        public abstract string Name
        {
            get;
            set;
        }
    }
}
