/**
Settlers of Catan Game
Author: John R. McLaren
Student ID: 21500529
Date Created: 16/09/2017
Date Modified: 15/10/2017
**/

namespace SettlersOfCatanGame
{
    class Land : Tile
    {
        string _name;
        string _type;
        string _resource;
        int _value; // what does a player need to roll to get this resource
        int _number; // each tile has a sequential number assigned to it (1,2,3...) so we can reference it
        int _numOfRoads; // how many roads exist on this tile
        bool _settlementExists; // does a settlement exist

        public Land(string name, string type, string resource, int value, int number)
        {
            _name = name;
            _type = type;
            _resource = resource;
            _value = value;
            _number = number;
            _numOfRoads = 0;
            _settlementExists = false;
        }

        public int Number
        {
            get
            {
                return _number;
            }
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

        public void AddRoad()
        {
            _numOfRoads++;
        }

        public void AddSettlement()
        {
            _settlementExists = true;
        }


    }
}
