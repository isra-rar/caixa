using System;

namespace Caixa.Domain.Entities
{
    public abstract class BaseEntity
    {
        protected BaseEntity()
        {
            Id = Guid.NewGuid();
            CreationDate = DateTime.UtcNow;
        }

        public Guid Id { get; set; }
        public DateTime CreationDate { get; private set; }
    }
}
