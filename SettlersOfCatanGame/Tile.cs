using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettlersOfCatanGame
{
    public abstract class Tile
    {
        string _name;

        public Tile()
        {

        }

        public abstract string Name
        {
            get;
        }



    }
}
