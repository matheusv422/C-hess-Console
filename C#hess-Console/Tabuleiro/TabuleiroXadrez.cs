namespace CamadaTabuleiro
{
    class TabuleiroXadrez
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private PecasTabuleiro[,] Pecas { get; set; }

        public TabuleiroXadrez(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            Pecas = new PecasTabuleiro[linhas, colunas];
        }

        public PecasTabuleiro RetornaPecas(int linhas, int colunas)
        {
            return Pecas[linhas, colunas];
        }
    }
}
