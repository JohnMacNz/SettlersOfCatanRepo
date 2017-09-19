/**
Settlers of Catan Game
Author: John R. McLaren
Student ID: 21500529
Date Created: 16/09/2017
Date Modified: 16/09/2017
**/

namespace SettlersOfCatanGame
{
    class Land : Tile
    {
        string _name;
        string _type;
        string _resource;
        int _roads;
        int _settlements;

        public Land(string name, string type, string resource)
        {
            _name = name;
            _type = type;
            _resource = resource;
            _roads = 0;
            _settlements = 0;
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

        public void addRoad()
        {
            _roads++;
        }

        public void addSettlement()
        {
            _settlements++;
        }
    }
}
