using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettlersOfCatanGame
{
    class WaterFactory
    {
        public Tile Create(string name, string type)
        {
            return new Water(name, type); // ocean // harbor
        }
    }
}
