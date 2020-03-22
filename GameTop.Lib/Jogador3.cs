using GameTop.Interface;

namespace GameTop.Lib
{
    public class Jogador3 : iJogador
    {
        public string Chuta()
        {
            return "Teste chuta \n";
        }

        public string Corre()
        {
            return "Teste corre \n";
        }

        public string Passe()
        {
            return "Teste passa \n";
        }
    }
}