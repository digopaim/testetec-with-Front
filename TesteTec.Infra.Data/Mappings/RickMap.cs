using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TesteTec.Domain.Entities;

namespace TesteTec.Infra.Data.Mappings
{
    class RickMap : IEntityTypeConfiguration<Rick>
    {
        public void Configure(EntityTypeBuilder<Rick> builder)
        {
            builder.Property(c => c.IdDimensao)
                .HasColumnName("IdDimensao");
            builder.Property(c => c.Id)
                .HasColumnName("Id");

        }
    }
}
  