using ChessSystem.Tabuleiro;

namespace ChessSystem.PecasXadrez
{
    class Rei : Peca
    {
        public Rei(Table tab, Cor cor)
            : base(tab, cor) 
        { 

        }

        public override string ToString()
        {
            return "R";
        }
    }
}
