using System;
using ChessSystem.Tabuleiro;

namespace ChessSystem
{
    class Screen
    {
        public static void PrintTable(Table table) 
        { 
            for(int i = 0; i<table.Linhas; i++) 
            {
                for (int j = 0; j<table.Colunas; j++) 
                {
                    if (table.peca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else 
                    {
                        Console.Write(table.peca(i, j) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
