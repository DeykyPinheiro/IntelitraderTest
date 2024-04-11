using System.Security.Cryptography;

namespace IntelitraderTest.Ofertas
{
    public class OperacaoFactory
    {
        List<Operacao> ListaDeOperacoes = new List<Operacao>();

        public void NovaOperacao(Operacao operacao)
        {
            Operacao operacaoExistente = ListaDeOperacoes.FirstOrDefault(o => o.Posicao == operacao.Posicao);

            // 0 = INSERIR  
            if (operacao.Acao == 0 && operacaoExistente == null)
            {
                ListaDeOperacoes.Add(operacao);
            }
            // 1 = MODIFICAR
            else if (operacaoExistente != null && (operacao.Acao == 1 || operacao.Acao == 0))
            {
                operacaoExistente.Acao = operacao.Acao;
                operacaoExistente.Valor = operacao.Valor;
                operacaoExistente.Quantidade = operacao.Quantidade;
            }
            // 2 = DELETAR
            else if (operacao.Acao == 2 && operacaoExistente != null)
            {
                ListaDeOperacoes.RemoveAll(o => o.Posicao == operacao.Posicao);
            }

        }

        public void ExibirOperacoes()
        {

            var operacoesOrdenadas = ListaDeOperacoes.OrderBy(o => o.Posicao).ToList();
            foreach (Operacao operacao in operacoesOrdenadas)
            {
                operacao.ExibirOperacao();
            }
        }
    }

}