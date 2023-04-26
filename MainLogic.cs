using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfSea
{
    internal class MainLogic
    {
        static char[,] _playerField = new char[10, 10];
        static char[,] _computerField = new char[10, 10];

        static void GameCycle()
        {
            FillField(_playerField);
            FillField(_computerField);
        }

        internal static void FillField(char[,] field)
        {
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    field[i, j] = '.';
                }
            }
        }





        internal void GenerateShip(char[,] field)
        {
            (int fourDeck, int threeDeck, int doubleDeck, int singleDeck) ships = (1, 2, 3, 4);

            for (int i = 0; i < ships.fourDeck; i++)
            {

            }
        }
    }
}
