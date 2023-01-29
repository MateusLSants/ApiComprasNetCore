using AppComprasNetCore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AppComprasNetCore.Infra.Data.Maps;

public class ProductMap : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("Produto");
        builder.HasKey(c => c.Id);

        builder.Property(c => c.Id)
            .HasColumnName("IdProduto")
            .UseMySqlIdentityColumn();

        builder.Property(c => c.Name)
            .HasColumnName("Nome");

        builder.Property(c => c.CodeErp)
            .HasColumnName("CodErp");

        builder.Property(c => c.Price)
            .HasColumnName("Preco");

        builder.HasMany(x => x.Purchases)
            .WithOne(p => p.Product)
            .HasForeignKey(x => x.ProductId);
    }
}
