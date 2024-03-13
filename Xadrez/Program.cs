using System;
using tabuleiro;
using jogoxadrez;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicaoxadrez pos = new Posicaoxadrez('c', 7);

            Console.WriteLine(pos);
            Console.WriteLine(pos.toPosicao());

            Console.ReadLine();
        }
    }
}