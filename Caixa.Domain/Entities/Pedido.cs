using Caixa.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Caixa.Domain.Entities
{
    public class Pedido : BaseEntity
    {
        private List<Produto> _produtos;
        public Pedido(Guid caixaId)
        {
            CaixaId = caixaId;
            _produtos = new List<Produto>();
        }


        public IEnumerable<Produto> Produtos { get { return _produtos.ToArray(); } }
        public decimal TotalPedido { get { return GenerateTotalOrder(); } private set { } }
        public ETipoPagamento TipoPagamento { get; private set; }
        public Caixa Caixa { get; private set; }
        public Guid CaixaId { get; private set; }


        public void AddProducts(List<Produto> products)
        {
            foreach (var produto in products)
                _produtos.Add(produto);
        }

        public decimal GenerateTotalOrder()
            => _produtos.Select(x => x.Valor).Sum();


    }
}
