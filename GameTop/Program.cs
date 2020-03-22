using System;
using GameTop.Lib;

namespace GameTop
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoTop(
                new Jogador1("Gustavo"),
                new Jogador3());
            jogo.IniciarJogo();
        }
    }
    
}
