using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfSea
{

    internal class Ship
    {
        int _x = 999;
        int _y = 999;
        static Random random = new Random();
        public int X { get { return _x; } }
        public int Y { get { return _y; } }
        public int VolumeOccupiedCells { get { return 0; } }

        internal List<(int x, int y)> Decks = new List<(int x, int y)>();


        internal static bool CheckBoundaryOfDeck(char[,] field, (int x, int y) coords)
        {
            for (int i = coords.x - 1; i <= coords.x + 1; i++)
            {
                for (int j = coords.y - 1; j <= coords.y + 1; j++)
                {
                    if (i >= 0 && j >= 0 && i < field.GetLength(0) && j < field.GetLength(1))
                    {
                        if (field[i, j] == field[coords.x, coords.y])
                            continue;
                        if (field[i, j] == '*')
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        internal bool CheckBoundaryOfShip(char[,] field, Ship ship)
        {
            foreach (var deck in ship.Decks)
            {
                if (!CheckBoundaryOfDeck(field, deck))
                {
                    return false;
                }

            }
            return true;
        }
        internal Ship(char[,] field,int numOfDecks)
        {
           
            do
            {
                _x = random.Next(0, 10);
                _y = random.Next(0, 10);
            } while (CheckBoundaryOfShip(field, ship));
        }
    }
}
