using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettlersOfCatanGame
{
    // This singleton class holds game properties
    internal class Settings
    {
        // variables
        static Settings settings;
        ArrayList players;
        int numOfPlayers;

        public Settings()
        {
            numOfPlayers = 0;
            players = new ArrayList();
        }
        

        // methods
        internal static Settings Access()
        {
            if (settings == null)
                settings= new Settings();
            return settings;
        }

        public ArrayList GetPlayers()
        {
            return players;
        }

        public int GetPlayerCount()
        {
            return players.Count;
        }

        public void GetPlayerNames()
        {
            foreach (Player p in players)
            {
                Console.WriteLine(p.Name);
            }
        }

        public bool AddPlayer(Player player)
        {
            foreach (Player p in players)
            {
                if (p.Name == player.Name)
                {
                    Console.WriteLine($"Player with the name [{player.Name}] already exists.");
                    return false;
                }
            }
            players.Add(player);
            return true;
        }

        public Player GetPlayer(int playerIndex)
        {
            return (Player)players[playerIndex];
        }
    }
}

