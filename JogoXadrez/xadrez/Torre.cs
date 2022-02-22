using tabuleiro;

namespace xadrez
{
    internal class Torre : Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor) { }

        public bool[,] movimentosPossiveis()
        {

        }

        public override string ToString()
        {
            return "T";
        }
    }
}
