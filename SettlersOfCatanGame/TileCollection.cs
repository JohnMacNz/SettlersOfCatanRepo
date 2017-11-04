using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettlersOfCatanGame
{
    class TileCollection
    {
        private ArrayList _tiles = new ArrayList();

        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }

        // Gets item count
        public int Count
        {
            get { return _tiles.Count; }
        }

        // Indexer
        public object this[int index]
        {
            get { return _tiles[index]; }
            set { _tiles.Add(value); }
        }
    }
}
