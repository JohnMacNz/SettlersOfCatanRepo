using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettlersOfCatanGame
{
    class Iterator : IAbstractIterator
    {
        private TileCollection _collection;
        private int _current = 0;
        private int _step = 1;

        // Constructor
        public Iterator(TileCollection collection)
        {
            _collection = collection;
        }

        // Gets first item
        public Tile First()
        {
            _current = 0;
            return _collection[_current] as Tile;
        }

        // Gets next item
        public Tile Next()
        {
            _current += _step;

            if (!IsDone)
                return _collection[_current] as Tile;
            else
                return null;
        }



        // Gets or sets stepsize
        public int Step
        {
            get { return _step; }
            set { _step = value; }
        }

        // Gets current iterator item
        public Tile CurrentItem
        {
            get { return _collection[_current] as Tile; }
        }

        // Gets whether iteration is complete
        public bool IsDone
        {
            get { return _current >= _collection.Count; }
        }
    }
}
