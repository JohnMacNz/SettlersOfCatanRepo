/**
Settlers of Catan Game
Author: John R. McLaren
Student ID: 21500529
Date Created: 16/09/2017
Date Modified: 16/09/2017
**/

namespace SettlersOfCatanGame
{
    class Ocean : Tile
    {
        string _name;
        string _type;

        public Ocean(string name, string type)
        {
            _name = name;
            _type = type;
        }
        public override string Name
        {
            get
            {
                return _name;
            }
        }
        public override string Type
        {
            get
            {
                return _type;
            }
        }
    }
}
