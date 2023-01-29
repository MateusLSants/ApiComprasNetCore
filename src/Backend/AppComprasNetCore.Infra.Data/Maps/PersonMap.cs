using AppComprasNetCore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AppComprasNetCore.Infra.Data.Maps;

public class PersonMap : IEntityTypeConfiguration<Person>
{
    public void Configure(EntityTypeBuilder<Person> builder)
    {
        builder.ToTable("Pessoa");

        builder.HasKey(c => c.Id);

        builder.Property(c => c.Id)
            .HasColumnName("idPessoa")
            .UseMySqlIdentityColumn();

        builder.Property(c => c.Name)
            .HasColumnName("Nome");

        builder.Property(c => c.Phone)
            .HasColumnName("Telefone");

        builder.Property(c => c.Document)
            .HasColumnName("Documento")
            .UseMySqlIdentityColumn();

        builder.HasMany(c => c.purchases)
            .WithOne(p => p.Person)
            .HasForeignKey(c => c.PersonId);
    }
}
