using System;
using System.Collections.Generic;
using System.Text;

namespace ChessSystem.Tabuleiro
{
    class TabuleiroException : Exception
    {
        public TabuleiroException(string msg) : base(msg) 
        { 
        }
    }
}
