using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TesteTec.Domain.Entities;

namespace TesteTec.Infra.Data.Mappings
{
    public class ViagemMap : IEntityTypeConfiguration<Viagem>
    {
        public void Configure(EntityTypeBuilder<Viagem> builder)
        {
            
            builder.Property(c => c.IdDimensao)
                .HasColumnName("IdDimensao");
            builder.Property(c => c.Id)
                .HasColumnName("Id");
        }
    }
}
