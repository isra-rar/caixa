using Caixa.Domain.Enums;

namespace Caixa.Domain.Entities
{
    public class Produto : BaseEntity
    {
        public Produto(string nome, decimal valor, int quantidade, ETipoProduto tipoProduto)
        {
            Nome = nome;
            Valor = valor;
            Quantidade = quantidade;
            TipoProduto = tipoProduto;
        }

        public string Nome { get; private set; }
        public decimal Valor { get; private set; }
        public int Quantidade { get; private set; }
        public ETipoProduto TipoProduto { get; private set; }
    }
}
