namespace ChessSystem.Tabuleiro
{
    class Peca
    {
        public Posiçao Posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public Table tab { get; protected set; }

        public Peca()
        {
        }

        public Peca(Table tab, Cor cor)
        {
            Posicao = null;
            this.cor = cor;
            this.qteMovimentos = 0;
            this.tab = tab;
        }
    }
}
