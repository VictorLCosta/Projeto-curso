using System;
using ChessSystem.Tabuleiro;

namespace ChessSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Table tab = new Table(8, 8);

            Screen.PrintTable(tab);

            new Table(9, 9);
        }
    }
}
