using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettlersOfCatanGame
{
    // handles resource dealing logic
    class Resources
    {
        delegate int ResourceHandler(int method);

        public int Add(Player name, int type, int amount)
        {
            switch (type)
            {
                case 1:
                    return name.Food + amount;
                case 2:
                    return name.Wood + amount;
                case 3:
                    return name.Wool + amount;
                case 4:
                    return name.Bricks + amount;
                case 5:
                    return name.Ore + amount;
            }
            return 0;
        }

        public void Subtract(int amount, Player name)
        {

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
