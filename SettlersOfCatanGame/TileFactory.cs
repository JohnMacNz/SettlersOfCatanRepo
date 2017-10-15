using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettlersOfCatanGame
{
    abstract class TileFactory
    {
        public abstract Tile Create(string name, string type);
    }
}
