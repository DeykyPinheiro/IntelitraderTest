namespace IntelitraderTest.Ofertas
{
    public class Operacao
    {
        public Operacao(int posicao, int acao, double valor, int quantidade)
        {
            Posicao = posicao;
            Acao = acao;
            Valor = valor;
            Quantidade = quantidade;
        }


        public int Posicao { get; set; }

        public int Acao { get; set; }

        public double Valor { get; set; }

        public int Quantidade { get; set; }

        public void ExibirOperacao()
        {
            Console.WriteLine($"{Posicao},{Valor.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture)},{Quantidade}");
        }
    }
}