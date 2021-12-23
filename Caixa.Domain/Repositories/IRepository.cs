using Caixa.Domain.Entities;
using System;

namespace Caixa.Domain.Repositories
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        TEntity Get(Guid id);
        void Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(Guid id);
    }
}
