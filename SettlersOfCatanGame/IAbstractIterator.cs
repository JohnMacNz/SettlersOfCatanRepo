using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettlersOfCatanGame
{
    interface IAbstractIterator
    {
        Tile First();

        Tile Next();

        bool IsDone { get; }

        Tile CurrentItem { get; }
    }
}
