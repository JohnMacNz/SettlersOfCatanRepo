using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettlersOfCatanGame
{
    class LandFactory
    {
        public Land Create(string name, string resource, int value, int number)
        {
            return new Land(name, resource, value, number);
        }


    }
}
