using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colacarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colacarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 0));
                tab.colacarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));

                tab.colacarPeca(new Rei(tab, Cor.Branca), new Posicao(3, 5));

                Tela.imprimirTabuleiro(tab);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}