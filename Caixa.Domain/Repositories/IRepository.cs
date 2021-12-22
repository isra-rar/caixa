using Caixa.Domain.Entities;
using System;

namespace Caixa.Domain.Repositories
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        void Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(Guid id);
    }
}
