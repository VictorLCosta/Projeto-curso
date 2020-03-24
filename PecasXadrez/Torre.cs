using ChessSystem.Tabuleiro;

namespace ChessSystem.PecasXadrez
{
    class Torre : Peca
    {
        public Torre(Table tab, Cor cor)
            : base(tab, cor)
        {

        }

        public override string ToString()
        {
            return "T";
        }
    }
}