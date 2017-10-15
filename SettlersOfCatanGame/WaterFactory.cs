using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettlersOfCatanGame
{
    class WaterFactory : TileFactory
    {
        public override Tile Create(string name, string type)
        {
            return new Water(name, type);
        }
    }
}
