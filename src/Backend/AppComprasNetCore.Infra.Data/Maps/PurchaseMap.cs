using AppComprasNetCore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AppComprasNetCore.Infra.Data.Maps;

public class PurchaseMap : IEntityTypeConfiguration<Purchase>
{
    public void Configure(EntityTypeBuilder<Purchase> builder)
    {
        builder.ToTable("Compras");
        builder.HasKey(c => c.Id);

        builder.Property(c => c.Id)
            .HasColumnName("Idcompra")
            .UseMySqlIdentityColumn();

        builder.Property(c => c.PersonId)
            .HasColumnName("Idpessoa");

        builder.Property(c => c.ProductId)
            .HasColumnName("Idproduto");

        builder.Property(c => c.Date)
            .HasColumnName("Datacompra");

        builder.HasOne(c => c.Person)
            .WithMany(x => x.Purchases);

        builder.HasOne(c => c.Product)
            .WithMany(x => x.Purchases);
    }
}
