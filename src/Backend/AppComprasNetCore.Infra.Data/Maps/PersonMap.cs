﻿using AppComprasNetCore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AppComprasNetCore.Infra.Data.Maps;

public class PersonMap : IEntityTypeConfiguration<Person>
{
    public void Configure(EntityTypeBuilder<Person> builder)
    {
        builder.ToTable("pessoa");

        builder.HasKey(c => c.Id);

        builder.Property(c => c.Id)
            .HasColumnName("idpessoa")
            .UseMySqlIdentityColumn();

        builder.Property(c => c.Name)
            .HasColumnName("nome");

        builder.Property(c => c.Phone)
            .HasColumnName("telefone");

        builder.Property(c => c.Document)
            .HasColumnName("documento");

        builder.HasMany(c => c.Purchases)
            .WithOne(p => p.Person)
            .HasForeignKey(c => c.PersonId);
    }
}
