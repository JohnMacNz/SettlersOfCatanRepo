/**
Settlers of Catan Game
Author: John R. McLaren
Student ID: 21500529
Date Created: 16/09/2017
Date Modified: 16/09/2017
**/

namespace SettlersOfCatanGame
{
    class Robber
    {
        static Robber robber;

        //method to access singleton
        public static Robber accessRobber()
        {
            if (robber == null)
                robber = new Robber();
            return robber;
        }
    }
}
