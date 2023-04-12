namespace CamadaTabuleiro
{
     class PecasTabuleiro
    {
        public Posicao PosicaoPeca { get; set; }
        public CoresPecas Cor { get; protected set; }
        public int QuantidadeMovimentos { get; protected set; }
        public TabuleiroXadrez Tabuleiro { get; protected set; }

        public PecasTabuleiro(Posicao posicaoPeca, CoresPecas cor, TabuleiroXadrez tabuleiro)
        {
            PosicaoPeca = posicaoPeca;
            Cor = cor;
            Tabuleiro = tabuleiro;
            QuantidadeMovimentos = 0;
        }
    }
}
