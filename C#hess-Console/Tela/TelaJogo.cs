using CamadaTabuleiro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_hess_Console.Tela
{
     class TelaJogo
    {
        public static void ImprimirTabuleiro(TabuleiroXadrez tabuleiro)
        {
            for (int linhas = 0; linhas < tabuleiro.Linhas; linhas++)
            {
                for(int colunas = 0; colunas < tabuleiro.Colunas; colunas++)
                {
                    if (tabuleiro.RetornaPecas(linhas, colunas) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tabuleiro.RetornaPecas(linhas, colunas) + " ");
                    }
                }
            Console.WriteLine();
            }
        }
    }
}
