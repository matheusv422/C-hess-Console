using CamadaTabuleiro;

namespace C_hess_Console.Tela
{
    public class Program
    {
        static void Main(string[] args)
        {
            var tabuleiro = new TabuleiroXadrez(8, 8);
            TelaJogo.ImprimirTabuleiro(tabuleiro);
            Console.ReadLine();
        }


    }
}