using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettlersOfCatanGame
{
    class LandFactory
    {
        public Tile Create(string name, string type, string resource, int value, int number)
        {
            return new Land(name, type, resource, value, number);
        }

        public override Tile Create(string name, string type)
        {
            throw new NotImplementedException();
        }


    }
}
