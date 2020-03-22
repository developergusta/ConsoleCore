using GameTop.Interface;

namespace GameTop
{
    public class JogoTop
    {
        private readonly iJogador _jogadorA;        
        private readonly iJogador _jogadorB;

        public JogoTop(iJogador jogador1, iJogador jogador2)
        {
            _jogadorA = jogador1;
            _jogadorB = jogador2;
        }
        public void IniciarJogo()
        {
            System.Console.Write(_jogadorA.Chuta());
            System.Console.Write(_jogadorA.Corre());
            System.Console.Write(_jogadorA.Passe());        
            //
                System.Console.Write("\n PRÓXIMO JOGADOR \n");
            //
            System.Console.Write(_jogadorB.Chuta());
            System.Console.Write(_jogadorB.Corre());
            System.Console.Write(_jogadorB.Passe());   
        }
    }
}