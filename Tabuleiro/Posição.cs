namespace ChessSystem.Tabuleiro
{
    class Posiçao
    {
        public int Linha { get; private set; }
        public int Coluna { get; private set; }

        public Posiçao()
        {
        }

        public Posiçao(int linha, int coluna)
        {
            Linha = linha;
            Coluna = coluna;
        }

        public override string ToString()
        {
            return ($"{Linha}, {Coluna}");
        }
    }
}
