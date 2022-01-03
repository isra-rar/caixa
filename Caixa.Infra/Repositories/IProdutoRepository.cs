using Caixa.Domain.Entities;
using Caixa.Domain.Repositories;
using Caixa.Infra.Context;
using Microsoft.EntityFrameworkCore;
using System;

namespace Caixa.Infra.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly DataContext _context;

        public ProdutoRepository(DataContext context)
            => _context = context;

        public Produto Get(Guid id)
        {
            var produto = _context.Produtos.Find(id);
            return produto;
        }
        public void Create(Produto produto)
        {
            _context.Produtos.Add(produto);
            _context.SaveChanges();
        }
        public void Update(Produto produto, Guid id)
        {
            produto.Id = id;
            _context.Entry(produto).State = EntityState.Modified;
            _context.Update(produto);
            _context.SaveChanges();
        }
        public void Delete(Guid id)
        {
            var entity = _context.Produtos.Find(id);
            if (entity != null)
                _context.Produtos.Remove(entity);
        }

    }
}
