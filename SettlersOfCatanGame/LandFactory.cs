using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettlersOfCatanGame
{
    class LandFactory : TileFactory
    {
        public Tile Create(string name, string type, string resource, int value, int number)
        {
            return new Land(name, type, resource, value, number);
        }

        public override Tile Create(string name, string type)
        {
            throw new NotImplementedException();
        }

        public string DetermineTileType(int number)
        {
            switch (number)
            {
                case 1:
                    return "Field";
                case 2:
                    return "Forest";
                case 3:
                    return "Farm";
                case 4:
                    return "Hill";
                case 5:                  
                    return "Mountain";
                case 6:
                    return "Desert";
                default:
                    return null;
            }
        }
    }
}
