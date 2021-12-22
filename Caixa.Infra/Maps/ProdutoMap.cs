using Caixa.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Caixa.Infra.Maps
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Produtos");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome)
                .IsRequired()
                .HasColumnType("varchar(150)");

            builder.Property(p => p.Valor)
                .IsRequired();

            builder.Property(p => p.Quantidade)
                .IsRequired();

            builder.Property(p => p.TipoProduto)
            .IsRequired()
            .HasConversion<string>();
        }
    }
}
