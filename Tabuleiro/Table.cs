namespace ChessSystem.Tabuleiro
{
    class Table
    {
        private Peca[,] pecas;
        public int Linhas { get; private set; }
        public int Colunas { get; private set; }

        public Table(int linhas, int colunas)
        {
            this.pecas = new Peca[linhas, colunas];
            Linhas = linhas;
            Colunas = colunas;
        }
        
        public Peca peca(int linha, int coluna) 
        {
            return pecas[linha, coluna];
        }

        public void InputPeca(Peca p, Posiçao pos) 
        {
            pecas[pos.Linha, pos.Coluna] = p;
            p.Posicao = pos;
        }

        public bool PosicaoValida(Posiçao posicao) 
        {
            if (posicao.Linha < 0 || posicao.Linha>=Linhas || posicao.Coluna < 0 || posicao.Coluna>=Colunas) 
            {
                return false;
            }
            return true;
        }
        public void ValidarPosicao(Posiçao pos) 
        {
            if (!PosicaoValida(pos)) 
            {
                throw new TabuleiroException("Posição inválida");
            }
        }
    }
}
