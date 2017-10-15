using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettlersOfCatanGame
{
    // holds a collection of land and water tiles
    class TileCollection<T>
    {
        private T[] tiles;

        public TileCollection(int size)
        {
            tiles = new T[size];
        }

        public T GetTile(int index)
        {
            return tiles[index]; // return selected item
        }

        // set the specified tile to the index
        public void SetTile(int index, T tile)
        {
            tiles[index] = tile;
        }
    }
}
