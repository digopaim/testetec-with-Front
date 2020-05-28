using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TesteTec.Domain.Entities;

namespace TesteTec.Infra.Data.Mappings
{
    public class DimensaoMap : IEntityTypeConfiguration<Dimensao>
    {
        public void Configure(EntityTypeBuilder<Dimensao> builder)
        {
            builder.Property(c => c.NomeDimensao)
                .HasColumnName("NomeDimensao")
                .HasMaxLength(50).IsRequired();
            builder.Property(c => c.Id)
                .HasColumnName("Id");
                
        }
    }
}
